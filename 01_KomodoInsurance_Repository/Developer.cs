using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_KomodoInsurance_Repository
{
    //POCO for Developers
    public class Developer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyID { get; set; }
        public string DevTeamId { get; set; }
        public string DevTeamName { get; set; }
        public string Pluralsight { get; set; }
        public Developer() { }
        public Developer(string firstName, string lastName, string companyID, string pluralsight)
        {
            FirstName = firstName;
            LastName = lastName;
            CompanyID = companyID;
            Pluralsight = pluralsight;
        }
    }
}
