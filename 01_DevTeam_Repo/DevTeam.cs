using _01_KomodoInsurance_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DevTeam_Repo
{
    public class DevTeam
    {
        public string DevTeamName { get; set; }
        public string DevTeamNumber { get; set; }
        public List<Developer> Members { get; set; }

        public DevTeam()        {

        }
        public DevTeam(string devTeamName, string devTeamNumber, List<Developer> members)
        {
            DevTeamName = devTeamName;
            DevTeamNumber = devTeamNumber;
            Members = members;
            
        }
    }
}
