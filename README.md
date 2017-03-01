Travix Tech Interview Test

# Introduction

Every engineer at Travix has to be able to come up with solutions, no matter their skill level (junior, intermediate, pre-senior, or senior) or role (pre-principal, principal I, II, or III).

This test is designed to give you a chance to show off your capabilities without taking too much time or being one of those boring online coding tests.

# Instructions

## Submission

1. Pick one of the scenarios, read the description and requirements

2. Fork the repository at [https://github.com/Travix-International/tech-test](https://github.com/Travix-International/tech-test)

3. Enter your proposed solution in your fork, following the provided skeleton setup

4. Submit your proposal as a pull request

## Solution

Your proposed solution must include:

* solution.md – a short (min two lines, max half a page) description of the solution

* assumptions.md – your assumptions when solving the challenge

* questions.md – five to ten questions for us about (e.g. questions about the design, requirements,limitations, or capacities)

* scale.md –  a description of how it will scale when the number of users/agents/consumers grows from 100 per day, to a 10000000 per day, and what changes would have to be made to keep the same quality of service

Images linked in the documents should be local to the repository, not internet URLs.

It should include at least one of the following, more if you find it necessary:

* system-context-diagram – a system context diagram (UML, whiteboard jpg photo, 8-bit pixel art gif, a phone picture of a bar's paper napkin with a crayon diagram scrawled on it, *anything* is good as long as it's legible)

* entity-diagram

* component-diagram

* class-diagram

* data-flow-diagram

* Any diagram you believe would be useful

If you can explain everything without diagrams or images, go ahead!

It shouldn’t include:

* Source code. This isn’t a coding test, but pseudo-code to explain concepts is fine

* Applications or interactive demos. We appreciate the effort, but we want to see your ability to design a solution

* Lengthy articles. Keep it pragmatic and to the point

* Copyrighted material, subject to NDA’s, or otherwise not available under a CC license (see: [https://creativecommons.org/licenses/](https://creativecommons.org/licenses/) )

All non-original materials should include attribution where required by their licenses.

## Time allotted for completion

There aren’t any formal requirements for how long this challenge should take you, complete it in ten minutes or ten hours, it’s up to you. We suggest to keep it to a maximum of one hour.

# Scenarios

## 1. URL shortener system

Here at Travix we often find ourselves using very long, ephemeral, URLs. Often times these URLs are included in emails and risk getting ruined by formatters or email readers, therefore we want to design a system which would allow us to use a the shortest URL possible in place of a "real" URL. Other times these URLs are used for machine-to-machine communication.

Some of these URLs are used for security purposes, and thus need to be one-shot only.

For this new Travix URL shortening system we have obtained the special domain trav.ix and the system should handle these input URLs:

* Of any length

* Containing query string parameters

* Containing URL fragments

* Of any scheme

* Using GET or POST

* Containing some non standard headers

* With a variable time to live, after which they shouldn’t be available

Additional requirements:

* We want to reduce the number of 404 we would return in case of an outdated short URL

* Short URL need to be quickly accessible across the world

* Short URLs need to be able to answer GETs as well as POSTs appropriately

## 2. Simple shopping cart system

Travix is jumping into the direct to consumer ecommerce realm! Help us by designing a simplified shopping cart system.

This shopping cart should be able to:

* Add an item, independent of its type

* Hold type-specific data for each item

* Automatically handle adding more items of the same kind, without listing them multiple times

* Automatically handle removing items of one kind up to removing said item completely

* Remove a group of items

* Be queried for its contents

* Be queried for a specific kind

* Automatically handle taxes for each kind, which can be different

* Automatically handle discounts

* Hold items in the cart across multiple visits to our site

* Handle the payment system’s responses (payment OK, failed, cancelled, inconclusive)

* Handle saving the cart for future purchases

Note that this system doesn’t include the inventory, fulfillment, payment systems, or other extra systems.

Additionally, know that our customers visit our site an average of seven times before completing a purchase, and spend anywhere from twenty to one hundred and twenty minutes browsing each time.

## 3. Hours tracking system

Tired of finding shortcomings in every Time Reporting System we purchased so far, Travix has decided to invest resources in creating our own Travix Hours Reporting Essential System Helper or THRESH.

This system should:

* Connect to JIRA to retrieve stories worked by our engineers or their team in the selected week

* Connect to our HR Payroll System to retrieve the org gram, approved time off, contractual number of hours per week, etc

* Connect to Google for SSO

* Hold the least amount of data per employee, because this is not a HR system, just a time recording system

* Display by default only those stories which have been worked on in the week displayed

* Allow for any number of stories to be added by the user

* Allow for managers to review other members’ hours, but only their reports and sub-reports, not just anyone

* Allow for non-stories, like "Training", “Conference”, “Hackaton”, “Urgent Hot Fix”, “Meetings”, etc

* Allow grouping stories by kind: Development, Meetings, Out of office, etc

* Generate reports for a time period, e.g. a month, including the number of hours per employee, per kind, per story, etc, in multiple dimensions

Take into consideration that if this THRESH system is successful, we might want to spin it out as its own product and offer it to the public as a SaaS.

## 4. Simple micro-blog platform

Instead of Twitter, Travix wants to launch its own specialized micro-blogging platform: Trawiller!

Trawiller takes the basic concept of Twitter, and adds its own holiday flair:

* Log in with Google, Facebook, GitHub, Slack, even Twitter! Just not with us..

* Post images, and they will be automatically tagged with everything your image metadata and device can give us! Location, camera model, date, time, weather, etc etc!!

* Automatically keep track of where you are, even if you don’t have Trawiller open, so that we can post for you where you are!

* Posting walls of text? Entire novels? Large 50 megapixel images? Videos? VR and panoramic media? High definition music? It’s all good. We take it all and provide you with ways to access it all through our timeline (e.g. snippets of text, excerpts, thumbnails, animated gifs, etc)!

* Our timeline lets you see your day, weeks, months, years as a stream of events which punctuate your online life!

* Remind users to post something at least once a day, so that nothing is lost of their day!

## 5. Fare Cache

Every day, hundreds of millions of airfare prices are being found based on searches from our customers. This can be a valuable stream of information, for example it can be used to show the cheapest recent price for a particular flight.

When a customer searches for a particular route (e.g. AMS to JFK), we return a list of zero or more fares, and on an average day we perform fifty million of these search requests, with each search returning anywhere from zero to two hundred results, but on average ten.

Each fare has a price with two decimals, and it’s valid for up to forty eight hours (and it’s a truly random number).

Roughly, there are 20,000 airports in the world, but not all airports are connected to each other, so there are only about 15,000 unique routes, combinations of a departure airport and an arrival one. Naturally not every route is equally popular, so there isn’t an even distribution of fares over the routes.

In order to make good use of this searches and reduce the strain on our poor servers, we want you to build a Fare Cache.

This Fare Cache:

* Can be queried to obtain the cheapest flight on any route in the world: When we query for the cheapest flight on a route, this is defined as "the fare with the lowest price on that route, which is still valid at the moment of querying"

* Is going to be used on our websites which receive millions of visits per day

* Different sites are specific for different countries, so the popular routes are going to be different across sites

* Subsequent search results on a route can 'replace' previous saved search results (e.g. suppose you search AMS-JFK and get 100 fares; five minutes later you search again AMS-JFK and get a slightly different result set of 101 fares. When we ask for the cheapest route AMS-JFK, we assume that the first result set is obsolete and the answer should come only from the second result set)

