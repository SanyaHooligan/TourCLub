using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TourClub.Models
{
    public enum Human { Турист, Туристка }
    public class Account
    {
        public Int32 AccountID { get; set; }
        public String Login { get; set; }
        public String Password { get; set; }
        public String ConfirmPassword { get; set; } // скорее всего не нужно в модели
        public String Surname { get; set; }
        public String Name { get; set; }
        public String Patronymic { get; set; }
        public String University { get; set; }
        public String Faculty { get; set; }
        public String Group { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Human Sex { get; set; }
        public HttpPostedFileBase Avatar { get; set; }
    }
}