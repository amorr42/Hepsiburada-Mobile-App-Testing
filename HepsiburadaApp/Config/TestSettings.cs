using HepsiburadaApp.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiburadaApp.Config
{
    class TestSettings
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("autPath")]
        public string AUTPath { get; set; }


        [JsonProperty("deviceName")]
        public string DeviceName { get; set; }

        [JsonProperty("mobileType")]
        public MobileType MobileType { get; set; }

        [JsonProperty("platformName")]
        public PlatformName PlatformName { get; set; }

        [JsonProperty("appPackage")]
        public string AppPackage { get; set; }

        [JsonProperty("appActivity")]
        public string AppActivity { get; set; }

        [JsonProperty("chromeDriverPath")]
        public string ChromeDriverPath { get; set; }

    }
}
