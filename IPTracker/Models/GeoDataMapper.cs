using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPTracker.Models
{
    public class GeoDataMapper
    {

        
            public string ip { get; set; }
            public string type { get; set; }
            public string continent_code { get; set; }
            public string continent_name { get; set; }
            public string country_code { get; set; }
            public string country_name { get; set; }
            public object region_code { get; set; }
            public object region_name { get; set; }
            public object city { get; set; }
            public object zip { get; set; }
            public decimal? latitude { get; set; }
            public decimal? longitude { get; set; }
            public Location location { get; set; }
        

        public class Location
        {
            public object geoname_id { get; set; }
            public string capital { get; set; }
            public Language[] languages { get; set; }
            public string country_flag { get; set; }
            public string country_flag_emoji { get; set; }
            public string country_flag_emoji_unicode { get; set; }
            public string calling_code { get; set; }
            public bool is_eu { get; set; }
        }

        public class Language
        {
            public string code { get; set; }
            public string name { get; set; }
            public string native { get; set; }
        }


    }
}
