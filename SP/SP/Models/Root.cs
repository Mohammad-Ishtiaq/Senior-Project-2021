using System;
using System.Collections.Generic;
using System.Text;

namespace SP.Models
{
    public class Root
    {
        public string _id { get; set; }
        public string combined_name { get; set; }
        public int confirmed { get; set; }
        public int confirmed_daily { get; set; }
        public string country { get; set; }
        public int country_code { get; set; }
        public string country_iso2 { get; set; }
        public string country_iso3 { get; set; }
        public string county { get; set; }
        public DateTime date { get; set; }
        public int deaths { get; set; }
        public int deaths_daily { get; set; }
        public int fips { get; set; }
        public Loc loc { get; set; }
        public int population { get; set; }
        public string state { get; set; }
        public int uid { get; set; }
    }
}
