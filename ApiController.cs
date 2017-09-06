using Flurl.Http;
using PROJECT.Services;
using PROJECT.WebApi.ViewModels;
using System;
using System.Diagnostics.Contracts;
using System.Net;
using System.Net.Http;
using System.Runtime.Caching;
using System.Threading.Tasks;
using System.Web.Http;

namespace PROJECT.WebApi.Controllers
{
    public class UrlController : ApiController
    {
        public readonly IUrlManagementService urlManagementService;
        public readonly int cacheInMinutes = 60;
        public UrlController(IUrlManagementService UrlManagementService)
        {
            urlManagementService = UrlManagementService;
        }

        /// <summary>
        /// The API Endpoint for getting short urls. This method handles all the GET requests
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/GetUrl/{key}")]
        public HttpResponseMessage Get(string key)
        {
            string resolvedURL;

            Lazy<String> lazyObject = new Lazy<String>(() => urlManagementService.GetUrl(key));
            var returnedLazyObject = MemoryCache.Default.AddOrGetExisting(key, lazyObject, new DateTimeOffset(DateTime.Now.AddMinutes(cacheInMinutes)));
            if (returnedLazyObject == null)
            {
                resolvedURL = lazyObject.Value;
            }
            else
            {
                resolvedURL = ((Lazy<String>)returnedLazyObject).Value;
            }

            var response = Request.CreateResponse(HttpStatusCode.Moved);
            if (!String.IsNullOrWhiteSpace(resolvedURL))
            {
                //TODO: if resolved url contains ? remove ? from RequestUrl.Query
                response.Headers.Location = new Uri(resolvedURL + Request.RequestUri.Query);
                return response;
            }

            return Request.CreateResponse(HttpStatusCode.NotFound);
        }

        /// <summary>
        /// The API Endpoint for getting short urls. This method handles all the POST requests
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/GetUrl/{key}")]
        public async Task<HttpResponseMessage> Post(string key)
        {
            string resolvedURL;

            Lazy<String> lazyObject = new Lazy<String>(() => urlManagementService.GetUrl(key));
            var returnedLazyObject = MemoryCache.Default.AddOrGetExisting(key, lazyObject, new DateTimeOffset(DateTime.Now.AddMinutes(cacheInMinutes)));
            if (returnedLazyObject == null)
            {
                resolvedURL = lazyObject.Value;
            }
            else
            {
                resolvedURL = ((Lazy<String>)returnedLazyObject).Value;
            }

            var res = Request.Content.ReadAsStringAsync().Result;

            if (!String.IsNullOrWhiteSpace(resolvedURL))
            {
                var responseString = await resolvedURL
                .PostUrlEncodedAsync(res);

                return responseString;
            }

            return Request.CreateResponse(HttpStatusCode.NotFound);
        }

        /// <summary>
        /// This method creates short URL's
        /// </summary>
        /// <param name="urlVM"></param>
        /// <returns></returns>
        [HttpPost]
        [ActionName("ShortenUrl")]
        public HttpResponseMessage Post([FromBody]AddUrlViewModel urlVM)
        {
            Contract.Requires(!string.IsNullOrEmpty(urlVM.LongUrl), "URL cannot be Null");

            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            return Request.CreateResponse(HttpStatusCode.OK, urlManagementService.AddShortUrl(urlVM.LongUrl, urlVM.Expiry));
        }

        /// <summary>
        /// TEST method for veryfing GET
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/TestUrl/{key}")]
        public HttpResponseMessage TestGet(string key)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        /// <summary>
        ///  TEST method for veryfing POST
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/TestUrl/{key}")]
        public HttpResponseMessage TestPost(string key)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
