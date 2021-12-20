using System;
using System.Collections.Generic;
using System.Text;

namespace SpFinal.Models
{
    public class DListModel
    {
        //Disease Rnak
        public double DRank { get; set; }

        //Disease Name
        public string DName { get; set; }

        //Disease Description
        public string DDescription { get; set; }

        //Lowest age group the disease accures in
        public int DAgeLow { get; set; }

        //Highest age group the disease accures in
        public int DAgeHigh { get; set; }

        //Most common gender the disease accures in
        public string MGender { get; set; }

        //List of symptoms for the diease
        public string DSymptoms { get; set; }
    }
}
