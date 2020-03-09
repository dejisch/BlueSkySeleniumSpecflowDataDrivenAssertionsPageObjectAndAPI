using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueSkySeleniumSpecflowWaitsDataDrivenAssertionsPageObjectAndAPI.TestData
{
    public class AddressDetails
    {
        [JsonProperty("street")]
        public string street { get; set; }
        [JsonProperty("suite")]
        public string suite { get; set; }
        [JsonProperty("city")]
        public string city { get; set; }
        [JsonProperty("zipcode")]
        public string zipcode { get; set; }

        [JsonProperty("geo")]
        public List<Geo> GeoData { get; set; }


    }
}
