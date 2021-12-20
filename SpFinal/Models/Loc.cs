using System.Collections.Generic;

namespace SpFinal.Models
{
    /// <summary>
    /// /This class is used for location coordinates as model class
    /// </summary>
    public class Loc
    {
        /// <summary>
        /// this property hold the list of coordinates of get from crunt locaton 
        /// </summary>
        public List<double> coordinates { get; set; }

        /// <summary>
        /// This property used to type of data
        /// </summary>
        public string type { get; set; }
    }
}