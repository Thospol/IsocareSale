using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Salecoop.Models
{
    public class Employee
    {
        [Key]
        public int IdEmployee { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Idcard { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Position { get; set; }
    }
}