using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpFinal.Models
{
    public class PersonInfo
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(3)]
        public int PAge { get; set; }

        [MaxLength(6)]
        public string PGender { get; set; }
        public string PSymptoms { get; set; }
    }
}
