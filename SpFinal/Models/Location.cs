using System;
using System.Collections.Generic;
using System.Text;

namespace SpFinal.Models
{
    /// <summary>
    /// This class used as model for the news loaction 
    /// </summary>
    public class Location
    {
        /// <summary>
        /// its hold the locaion 
        /// </summary>
        public double @long { get; set; }
        /// <summary>
        /// this is user crunt cpountry orrgion
        /// </summary>
        public string countryOrRegion { get; set; }
        /// <summary>
        /// this is used as Province or State
        /// </summary>
        public object provinceOrState { get; set; }
        /// <summary>
        /// This is for the Country 
        /// </summary>
        public object county { get; set; }
        /// <summary>
        /// This is for user Country code 
        /// </summary>
        public string isoCode { get; set; }

        /// <summary>
        /// this is used for latitude for loaction 
        /// </summary>
        public double lat { get; set; }
    }

    /// <summary>
    /// This class used for data parsing json to model for news imges
    /// </summary>
    public class Image
    {
        /// <summary>
        /// Image Path url
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// Image With
        /// </summary>
        public int width { get; set; }
        /// <summary>
        /// Image Height
        /// </summary>
        public int height { get; set; }
        /// <summary>
        /// Image titel
        /// </summary>
        public object title { get; set; }
        /// <summary>
        /// this is object for attribution
        /// </summary>
        public object attribution { get; set; }
        /// <summary>
        /// this is for image isCached bool is true our not
        /// </summary>
        public bool isCached { get; set; }
    }


    /// <summary>
    /// this class used to json to text data get from news api provider is web site where from news used 
    /// </summary>
    public class Provider
    {
        /// <summary>
        /// this is for proveder name
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// this for domain of provider used
        /// </summary>
        public string domain { get; set; }
        /// <summary>
        /// this is for images of provider
        /// </summary>
        public object images { get; set; }
        /// <summary>
        /// this is for publishers
        /// </summary>
        public object publishers { get; set; }
        /// <summary>
        /// this for authors thst is the publisged this news
        /// </summary>
        public object authors { get; set; }
    }
    /// <summary>
    /// This class used as model for data parsing jsonto text 
    /// </summary>
    public class News
    {
        /// <summary>
        /// This is news path
        /// </summary>
        public string path { get; set; }
        /// <summary>
        /// titel
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// this is for export
        /// </summary>
        public string excerpt { get; set; }
        /// <summary>
        /// this is for sourse url
        /// </summary>
        public object sourceUrl { get; set; }
        /// <summary>
        /// this is for web url
        /// </summary>
        public string webUrl { get; set; }
        /// <summary>
        /// this is for originalUrl
        /// </summary>
        public string originalUrl { get; set; }
        /// <summary>
        /// this is for featuredContent
        /// </summary>
        public object featuredContent { get; set; }
        /// <summary>
        /// this is for highlight
        /// </summary>
        public object highlight { get; set; }
        /// <summary>
        /// this for heat
        /// </summary>
        public int heat { get; set; }
        /// <summary>
        /// this for tags list 
        /// </summary>
        public List<string> tags { get; set; }
        /// <summary>
        /// this for images list
        /// </summary>
        public List<Image> images { get; set; }
        public string content { get; set; }
        /// <summary>
        /// this is for news contant
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// this is for web url
        /// </summary>
        public string ampWebUrl { get; set; }
        /// <summary>
        /// this is for cdnAmpWebUrl
        /// </summary>
        public string cdnAmpWebUrl { get; set; }
        /// <summary>
        /// this is for new published date time
        /// </summary>
        public DateTime publishedDateTime { get; set; }
        /// <summary>
        /// this is for update date time
        /// </summary>
        public object updatedDateTime { get; set; }
        /// <summary>
        /// this is for provider name
        /// </summary>
        public Provider provider { get; set; }
        /// <summary>
        /// this is for news location
        /// </summary>
        public string locale { get; set; }
        /// <summary>
        /// this for news categories list 
        /// </summary>
        public List<string> categories { get; set; }
        /// <summary>
        /// this for new topic list
        /// </summary>
        public List<string> topics { get; set; }
    }
    /// <summary>
    /// this is the news root class that is used to json data get from news api conver to text formats
    /// </summary>
    public class NewsRoot
    {
        /// <summary>
        /// This for lis of loaction of news 
        /// </summary>
        public Location location { get; set; }
        /// <summary>
        /// this is for updated DateTime
        /// </summary>
        public DateTime updatedDateTime { get; set; }
        //this for news arry that is json formate return by news api 
        public News[] news { get; set; }
    }


}
