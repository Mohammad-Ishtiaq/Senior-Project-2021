using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace SP.Datasets
{
    public class SignInInformation
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        [MaxLength(3)]
        public string Age { get; set; }

        [MaxLength(6)]
        public string Sex { get; set; }
    }
}
