using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueSkySeleniumSpecflowWaitsDataDrivenAssertionsPageObjectAndAPI.TestData
{
    public class Geo
    {
        [JsonProperty("lat")]
        public string lat { get; set; }
        [JsonProperty("lng")]
        public string lng { get; set; }

    }
}
