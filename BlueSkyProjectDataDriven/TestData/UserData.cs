using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueSkySeleniumSpecflowWaitsDataDrivenAssertionsPageObjectAndAPI.TestData
{
    public class UserData
    {
        [JsonProperty("id")]
        public string PostCode { get; set; }

        [JsonProperty("name")]
        public string user { get; set; }

        [JsonProperty("username")]
        public string username { get; set; }

        [JsonProperty("phone")]
        public string phone { get; set; }

        [JsonProperty("email")]
        public string email { get; set; }

        [JsonProperty("company")]
        public string company { get; set; }

        [JsonProperty("Address")]
        public List<AddressDetails> Address { get; set; }
    }
        
}
