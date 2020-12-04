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
        public string DevTeamID { get; set; }
        public List<Developer> Members { get; set; }

        public DevTeam()        {

        }
        public DevTeam(string devTeamName, string devTeamID, List<Developer> members)
        {
            DevTeamName = devTeamName;
            DevTeamID = devTeamID;
            Members = members;
            
        }
    }
}
