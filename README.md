Simple-CSharp-BreweryDB-Wrapper
===============================

Simple wrapper that takes endpoint and parameters then returns raw response in string format.

Currently only working with GET requests.

Example:
```csharp
string key = "bb8642292705a51ea7022ef4b28968aa";
string format = "json";
BreweryDB target = new BreweryDB(key, format);
target.Endpoint = "beer";
Dictionary<string, string> parameters = new Dictionary<string, string>();
parameters.Add("withBreweries", "Y");
string result = target.DirectCallById("t7SnlC", parameters);
```
Output:
```json
{
  "message":"Request Successful",
  "data":{
    "id":"t7SnlC",
    "name":"Blackout Stout",
    "description":"A Russian Imperial Stout with a hearty malt body and bold hop flavor.\r\n\r\nYes, it's a dark brew. And much like the \"Blackout of 2003\" that left the northeastern United States in complete darkness, this hearty stout can also give rise to old-fashioned neighborhood get-togethers and down-home fun.",
    "abv":"9",
    "ibu":"85",
    "glasswareId":8,
    "srmId":41,
    "availableId":8,
    "styleId":43,
    "isOrganic":"N",
    "labels":{
      "icon":"https:\/\/s3.amazonaws.com\/brewerydbapi\/beer\/t7SnlC\/upload_CyH8xt-icon.png",
      "medium":"https:\/\/s3.amazonaws.com\/brewerydbapi\/beer\/t7SnlC\/upload_CyH8xt-medium.png",
      "large":"https:\/\/s3.amazonaws.com\/brewerydbapi\/beer\/t7SnlC\/upload_CyH8xt-large.png"
    },
    "status":"verified",
    "statusDisplay":"Verified",
    "createDate":"2012-01-03 02:42:51",
    "updateDate":"2013-04-08 12:42:20",
    "glass":{
      "id":8,
      "name":"Tulip",
      "createDate":"2012-01-03 02:41:33"
    },
    "srm":{
      "id":41,
      "name":"Over 40",
      "hex":"000000"
    },
    "available":{
      "id":8,
      "name":"Winter",
      "description":"Available during the winter months."
    },
    "style":{
      "id":43,
      "categoryId":3,
      "category":{
        "id":3,
        "name":"North American Origin Ales",
        "createDate":"2012-03-21 20:06:45"
      },
      "name":"American-Style Imperial Stout",
      "description":"Black in color, American-style imperial stouts typically have a high alcohol content. Generally characterized as very robust. The extremely rich malty flavor and aroma are balanced with assertive hopping and fruity-ester characteristics. Bitterness should be moderately high to very high and balanced with full sweet malt character. Roasted malt astringency and bitterness can be moderately perceived but should not overwhelm the overall character. Hop aroma is usually moderately-high to overwhelmingly hop-floral, -citrus or -herbal. Diacetyl (butterscotch) levels should be absent.",
      "ibuMin":"50",
      "ibuMax":"80",
      "abvMin":"7",
      "abvMax":"12",
      "srmMin":"40",
      "srmMax":"40",
      "ogMin":"1.08",
      "fgMin":"1.02",
      "fgMax":"1.03",
      "createDate":"2012-03-21 20:06:46"
    },
    "breweries":[
      {
        "id":"uSFO4T",
        "name":"Great Lakes Brewing Company",
        "description":"In the 1870s, Cleveland had 30 breweries. By the early 1980s, the last one had shuttered its doors. So when brothers Patrick and Daniel Conway opened Great Lakes Brewing Company on September 6, 1988, it not only signaled a new era in Cleveland brewing, it was also the first microbrewery in the state of Ohio. And the idea of a craft brewery in Cleveland caught on fast, as curious patrons hurried in for a pint crafted in the styles of old and drawn from the taps of the beautiful Victorian era bar. The company's commitment to sustainable business practices greatly contributed to its early popularity and success. Before long, Great Lakes Brewing Company had become one of Cleveland's most popular destinations for both dining and a fun night out.",
        "website":"http:\/\/www.greatlakesbrewing.com\/",
        "established":"1988",
        "isOrganic":"N",
        "images":{
          "icon":"https:\/\/s3.amazonaws.com\/brewerydbapi\/brewery\/uSFO4T\/upload_O5TpB8-icon.png",
          "medium":"https:\/\/s3.amazonaws.com\/brewerydbapi\/brewery\/uSFO4T\/upload_O5TpB8-medium.png",
          "large":"https:\/\/s3.amazonaws.com\/brewerydbapi\/brewery\/uSFO4T\/upload_O5TpB8-large.png"
        },
        "status":"verified",
        "statusDisplay":"Verified",
        "createDate":"2012-01-03 02:41:56",
        "updateDate":"2013-08-12 13:06:19",
        "locations":[
          {
            "id":"8dIvZw",
            "name":"Main Brewery",
            "streetAddress":"1947 West 28th Street",
            "locality":"Cleveland",
            "region":"Ohio",
            "postalCode":"44113",
            "phone":"216-771-4404",
            "website":"http:\/\/www.greatlakesbrewing.com\/",
            "hoursOfOperation":"Monday - Thursday: 11:30 AM - 10:30 PM (bar open until 12:00 AM)\r\nFriday and Saturday: 11:30 AM - 11:30 PM (bar open until 1:00 AM)\r\nSundays: Closed",
            "latitude":41.484295,
            "longitude":-81.705375,
            "isPrimary":"Y",
            "inPlanning":"N",
            "isClosed":"N",
            "openToPublic":"Y",
            "locationType":"micro",
            "locationTypeDisplay":"Micro Brewery",
            "countryIsoCode":"US",
            "yearOpened":"1988",
            "status":"verified",
            "statusDisplay":"Verified",
            "createDate":"2012-01-03 02:41:56",
            "updateDate":"2014-07-23 19:11:34",
            "country":{
              "isoCode":"US",
              "name":"UNITED STATES",
              "displayName":"United States",
              "isoThree":"USA",
              "numberCode":840,
              "createDate":"2012-01-03 02:41:33"
            }
          },
          {
            "id":"xSmsLL",
            "name":"Great Lakes Brewpub",
            "streetAddress":"2516 Market Avenue",
            "locality":"Cleveland",
            "region":"Ohio",
            "postalCode":"44113",
            "phone":"216-771-4404",
            "website":"http:\/\/www.greatlakesbrewing.com\/brewpub\/around-the-brewpub",
            "hoursOfOperation":"Monday - Thursday: 11:30 AM - 10:30 PM (bar open until 12:00 AM)\r\nFriday and Saturday: 11:30 AM - 11:30 PM (bar open until 1:00 AM)\r\nSundays: Closed",
            "latitude":41.484446,
            "longitude":-81.704436,
            "isPrimary":"N",
            "inPlanning":"N",
            "isClosed":"N",
            "openToPublic":"Y",
            "locationType":"brewpub",
            "locationTypeDisplay":"Brewpub",
            "countryIsoCode":"US",
            "status":"verified",
            "statusDisplay":"Verified",
            "createDate":"2013-12-10 17:48:32",
            "updateDate":"2014-07-23 19:11:34",
            "country":{
              "isoCode":"US",
              "name":"UNITED STATES",
              "displayName":"United States",
              "isoThree":"USA",
              "numberCode":840,
              "createDate":"2012-01-03 02:41:33"
            }
          }
        ]
      }
    ]
  },
  "status":"success"
}
```
