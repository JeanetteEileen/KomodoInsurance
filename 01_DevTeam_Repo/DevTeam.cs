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
        public List<Developer> Members = new List<Developer>();
       
        public DevTeam(string devTeamName, string devTeamID)
        {
            DevTeamName = devTeamName;
            DevTeamID = devTeamID;
            
        }
    }
}
