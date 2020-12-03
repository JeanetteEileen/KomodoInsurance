using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_KomodoInsurance_Repository
{
    //POCO for Developers
    public class DeveloperList
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyID { get; set; }
        public string DevTeamId { get; set; }
        public string DevTeamName { get; set; }
        public string Pluralsight { get; set; }
        public DateTime PluralsightExpiration { get; set; }

        public DeveloperList() { }
        public DeveloperList(string firstName, string lastName, string companyID, string devTeamID, string devTeamName, string pluralsight, DateTime pluralsightExpiration)  
        {
            FirstName = firstName;
            LastName = lastName;
            CompanyID = companyID;
            DevTeamId = devTeamID;
            DevTeamName = devTeamName;
            Pluralsight = pluralsight;
            PluralsightExpiration = pluralsightExpiration;
        }
    }
}
