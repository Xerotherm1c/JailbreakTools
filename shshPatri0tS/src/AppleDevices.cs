using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shshPatri0tS {

    class AppleDevices {

        public static List<AppleDevice> iPhones = new List<AppleDevice> {

            new AppleDevice("iPhone 2G",             "iPhone1,1", "M68AP"),
            new AppleDevice("iPhone 3G",             "iPhone1,2", "N82AP"),
            new AppleDevice("iPhone 3G[S]",          "iPhone2,1", "N88AP"),

            new AppleDevice("iPhone 4 (GSM)",        "iPhone3,1", "N90AP"),
            new AppleDevice("iPhone 4 (GSM 2012)",   "iPhone3,2", "N90BAP"),
            new AppleDevice("iPhone 4 (CDMA)",       "iPhone3,3", "N92AP"),
            new AppleDevice("iPhone 4[S]",           "iPhone4,1", "N94AP"),

            new AppleDevice("iPhone 5 (GSM)",        "iPhone5,1", "N41AP"),
            new AppleDevice("iPhone 5 (Global)",     "iPhone5,2", "N42AP"),

            new AppleDevice("iPhone 5c (GSM)",       "iPhone5,3", "N48AP"),
            new AppleDevice("iPhone 5c (Global)",    "iPhone5,4", "N49AP"),
            new AppleDevice("iPhone 5s (GSM)",       "iPhone6,1", "N51AP"),
            new AppleDevice("iPhone 5s (Global)",    "iPhone6,2", "N53AP"),

            new AppleDevice("iPhone 6",              "iPhone7,2", "N61AP"),
            new AppleDevice("iPhone 6+",             "iPhone7,1", "N56AP"),

            new AppleDevice("iPhone 6s",             "iPhone8,1", "N71AP;N71mAP"),
            new AppleDevice("iPhone 6s+",            "iPhone8,2", "N66AP;N66mAP"),
            new AppleDevice("iPhone SE",             "iPhone8,4", "N69AP;N69uAP"),

            new AppleDevice("iPhone 7 (GSM)",        "iPhone9,3", "D101AP"),
            new AppleDevice("iPhone 7 (Global)",     "iPhone9,1", "D10AP"),

            new AppleDevice("iPhone 7+ (GSM)",       "iPhone9,4", "D111AP"),
            new AppleDevice("iPhone 7+ (Global)",    "iPhone9,2", "D11AP"),

            new AppleDevice("iPhone 8",              "iPhone10,1", "D20AP;D20AAP"),
            new AppleDevice("iPhone 8",              "iPhone10,4", "D201AP;D201AAP"),

            new AppleDevice("iPhone 8+",             "iPhone10,2", "D21AP;D21AAP"),
            new AppleDevice("iPhone 8+",             "iPhone10,5", "D211AP;D211AAP"),

            new AppleDevice("iPhone X (GSM)",        "iPhone10,3", "D22AP"),
            new AppleDevice("iPhone X (Global)",     "iPhone10,6", "D221AP"),

            new AppleDevice("iPhone XR", "iPhone11,8", "N841AP"),
            new AppleDevice("iPhone XS", "iPhone11,2", "D321AP"),
            new AppleDevice("iPhone XS Max", "iPhone11,4", "D331AP"),
            new AppleDevice("iPhone XS Max (China)", "iPhone11,6", "D331pAP"),


        };

        public static List<AppleDevice> iPods = new List<AppleDevice> {
            
            new AppleDevice("iPod Touch 1G", "iPod1,1", "N45AP"),
            new AppleDevice("iPod Touch 2G", "iPod2,1", "N72AP"),
            new AppleDevice("iPod Touch 3",  "iPod3,1", "N18AP"),
            new AppleDevice("iPod Touch 4",  "iPod4,1", "N81AP"),
            new AppleDevice("iPod Touch 5",  "iPod5,1", "N78AP;N78aAP"),
            new AppleDevice("iPod Touch 6",  "iPod7,1", "N102AP"),

        };

        public static List<AppleDevice> iPads = new List<AppleDevice> {

            new AppleDevice("iPad 1",                       "iPad1,1",  "K48AP"),
                                                                        
            new AppleDevice("iPad 2 (WiFi)",                "iPad2,1",  "K93AP"),
            new AppleDevice("iPad 2 (GSM)",                 "iPad2,2",  "K94AP"),
            new AppleDevice("iPad 2 (CDMA)",                "iPad2,3",  "K95AP"),
            new AppleDevice("iPad 2 (Mid 2012)",            "iPad2,4",  "K93AAP"),
                                                                        
            new AppleDevice("iPad Mini (WiFi)",             "iPad2,5",  "P105AP"),
            new AppleDevice("iPad Mini (GSM)",              "iPad2,6",  "P106AP"),
            new AppleDevice("iPad Mini (Global)",           "iPad2,7",  "P107AP"),
                                                                        
            new AppleDevice("iPad 3 (WiFi)",                "iPad3,1",  "J1AP"),
            new AppleDevice("iPad 3 (CDMA)",                "iPad3,2",  "J2AP"),
            new AppleDevice("iPad 3 (GSM)",                 "iPad3,3",  "J2AAP"),
                                                                        
            new AppleDevice("iPad 4 (WiFi)",                "iPad3,4",  "P101AP"),
            new AppleDevice("iPad 4 (GSM)",                 "iPad3,5",  "P102AP"),
            new AppleDevice("iPad 4 (Global)",              "iPad3,6",  "P103AP"),
                                                                        
            new AppleDevice("iPad Air (WiFi)",              "iPad4,1",  "J71AP"),
            new AppleDevice("iPad Air (Cellular)",          "iPad4,2",  "J72AP"),
            new AppleDevice("iPad Air (China)",             "iPad4,3",  "J73AP"),
                                                                        
            new AppleDevice("iPad Mini 2 (WiFi)",           "iPad4,4",  "J85AP"),
            new AppleDevice("iPad Mini 2 (Cellular)",       "iPad4,5",  "J86AP"),
            new AppleDevice("iPad Mini 2 (China)",          "iPad4,6",  "J87AP"),
                                                                        
            new AppleDevice("iPad Mini 3 (WiFi)",           "iPad4,7",  "J85mAP"),
            new AppleDevice("iPad Mini 3 (Cellular)",       "iPad4,8",  "J86mAP"),
            new AppleDevice("iPad Mini 3 (China)",          "iPad4,9",  "J87mAP"),
                                                                        
            new AppleDevice("iPad Mini 4 (WiFi)",           "iPad5,1",  "J96AP"),
            new AppleDevice("iPad Mini 4 (Cellular)",       "iPad5,2",  "J97AP"),
                                                                        
            new AppleDevice("iPad Air 2 (WiFi)",            "iPad5,3",  "J81AP"),
            new AppleDevice("iPad Air 2 (Cellular)",        "iPad5,4",  "J82AP"),
                                                                        
            new AppleDevice("iPad Pro 9.7 (WiFi)",          "iPad6,3",  "J127AP"),
            new AppleDevice("iPad Pro 9.7 (Cellular)",      "iPad6,4",  "J128AP"),
                                                                        
            new AppleDevice("iPad Pro 12.9 (WiFi)",         "iPad6,7",  "J98aAP"),
            new AppleDevice("iPad Pro 12.9 (Cellular)",     "iPad6,8",  "J99aAP"),
                                                                        
            new AppleDevice("iPad 5 (WiFi)",                "iPad6,11",  "J71sAP"),
            new AppleDevice("iPad 5 (Cellular)",            "iPad6,12",  "J72sAP"),
                                                                        
            new AppleDevice("iPad Pro 2 12.9 (Wifi)",       "iPad7,1",  "J120AP"),
            new AppleDevice("iPad Pro 2 12.9 (Cellular)",   "iPad7,2",  "J121AP"),
                                                                        
            new AppleDevice("iPad Pro 10.5 (Wifi)",         "iPad7,3",  "J207AP"),
            new AppleDevice("iPad Pro 10.5 (Cellular)",     "iPad7,4",  "J208AP"),

            new AppleDevice("iPad 6 (Wifi)",                "iPad7,5",  "J71bAP"),
            new AppleDevice("iPad 6 (Cellular)",            "iPad7,6",  "J72bAP"),

        };


        public static List<AppleDevice> appleTVs = new List<AppleDevice> {

            new AppleDevice("Apple TV 2G",       "AppleTV2,1", "K66AP"),
            new AppleDevice("Apple TV 3",        "AppleTV3,1", "J33AP"),
            new AppleDevice("Apple TV 3 (2013)", "AppleTV3,2", "J33IAP"),
            new AppleDevice("Apple TV 4 (2015)", "AppleTV5,3", "J42dAP"),
            new AppleDevice("Apple TV 4K",       "AppleTV6,2", "J105aAP"),

        };

    }


    public class AppleDevice {

        private string mGeneration;
        private string mIdentifier;
        private string mInternalName;

        public AppleDevice(string generation, string identifier, string internalName) {

            mGeneration = generation;
            mIdentifier = identifier;
            mInternalName = internalName;

        }


        public string Generation { get { return mGeneration; } set { mGeneration = value; } }
        public string Identifier { get { return mIdentifier; } set { mIdentifier = value; } }
        public string InternalName { get { return mInternalName; } set { mInternalName = value; } }

    }

}
