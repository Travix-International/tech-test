# Solution.md
ulr shortening algorithm (here coded in fsharp), taken from [this stackoverflow question](https://stackoverflow.com/questions/742013/how-to-code-a-url-shortener/742047#742047) and reworked.

```fs
open System

type TempUrl = {
    Key: int; //retrieved from an IDENTITY generated in external database
    Short: string; //short url
    Long : string; //original long url
    Timestamp : System.DateTime; //support for time to live
}

let ExpiryPolicyTimeout = TimeSpan.FromMinutes(1.0)

let UrlsCache = System.Collections.Generic.Dictionary<string,TempUrl>()

//also mind uri parsing
let Alphabet = [for i in 48..90 do yield (char)i] |> Seq.toArray

let rec generateDigitsForKey key (alphabet : char array) digits =
        let counterBase = alphabet.Length
        if key > 0 then
            let remainder = key % counterBase
            let digits2 = alphabet.[remainder].ToString() :: digits |> List.rev
            let num2 = key / counterBase
            generateDigitsForKey num2 alphabet digits2
        else
            digits |> Seq.fold (+) ""

let GrabNewKeyFromStorageMock (_:unit) = 
    System.Random(DateTime.Now.Millisecond).Next()

let insertNewAndReturn long =
    let key = GrabNewKeyFromStorageMock ()
    let short = generateDigitsForKey key Alphabet []
    let newShortUrl = { Key = key; Short = short; Long = long; Timestamp = DateTime.UtcNow }
    UrlsCache.Add(long, newShortUrl);
    newShortUrl

let checkExpired tempUrl =
     DateTime.UtcNow > (tempUrl.Timestamp + ExpiryPolicyTimeout)

let shorten long =
    let result = UrlsCache.[long]
    match (checkExpired result) with
    |false -> result
    |true -> 
        UrlsCache.Remove(long) |> ignore ;
        insertNewAndReturn long

```
