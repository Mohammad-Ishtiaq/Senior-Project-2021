using System;
using System.Collections.Generic;
using System.Text;

namespace SpFinal.Models
{
    public class Root
    {
        /// <summary>
        /// this id of list of data
        /// </summary>
        public string _id { get; set; }
        /// <summary>
        /// this the name of Combined name 
        /// </summary>
        public string combined_name { get; set; }
        /// <summary>
        /// this is for confirmed deaths
        /// </summary>
        public int confirmed { get; set; }
        /// <summary>
        /// this for deaily deaths
        /// </summary>
        public int confirmed_daily { get; set; }
        /// <summary>
        /// this for counry 
        /// </summary>
        public string country { get; set; }
        /// <summary>
        /// this is for country code 
        /// </summary>
        public int country_code { get; set; }
        /// <summary>
        /// this is for country ios 
        /// </summary>
        public string country_iso2 { get; set; }
        public string country_iso3 { get; set; }
        public string county { get; set; }
        public DateTime date { get; set; }
        /// <summary>
        /// this is for deaths 
        /// </summary>
        public int deaths { get; set; }
        /// <summary>
        /// this is for deaths for daily
        /// </summary>
        public int deaths_daily { get; set; }
        /// <summary>
        /// this for fips 
        /// </summary>
        public int fips { get; set; }
        /// <summary>
        /// this for location of covid
        /// </summary>
        public Loc loc { get; set; }
        /// <summary>
        /// this for population of area
        /// </summary>
        public int population { get; set; }
        /// <summary>
        /// this for covid state where from dtata used 
        /// </summary>
        public string state { get; set; }
        /// <summary>
        /// this for uid
        /// </summary>
        public int uid { get; set; }
    }
}
