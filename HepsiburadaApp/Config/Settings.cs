using HepsiburadaApp.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiburadaApp.Config
{
    class Settings
    {
        public static string AUTPath { get; set; }
        public static string ChromeDriverPath { get; set; }
        public static PlatformName PlatformName { get; set; }
        public static string DeviceName { get; set; }

        public static MobileType MobileType { get; set; }
        public static string AppPackage { get; set; }
        public static string AppActivity { get; set; }
    }
}
