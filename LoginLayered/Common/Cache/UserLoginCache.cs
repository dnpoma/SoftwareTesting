using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public static class UserLoginCache
    {
        public static string IdUser { get; set; }
        public static string Name { get; set; }
        public static string LastName { get; set; }
        public static string Address { get; set; }
        public static string Phone { get; set; }
        public static string Email { get; set; }
        public static string Dni { get; set; }
        public static DateTime DateBirth { get; set; }
        public static DateTime DateAdmission { get; set; }
        public static DateTime DateDeparture { get; set; }
        public static string Photo { get; set; }
        public static Decimal CarFarm { get; set; }
        public static string Passport { get; set; }
        public static string Discapacity { get; set; }
        public static string Password { get; set; }
        public static string RecPassword { get; set; }
        public static bool Captcha { get; set; }
    }
}
