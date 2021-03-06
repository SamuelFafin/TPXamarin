﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swaguin.Models
{

    public enum Gender { Male, Female };

    [Table("contact")]
    public class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public bool Favorite { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set;}
        public String PhoneNumber { get; set; }
        public string ImagePath { get; set; }
    }
}
