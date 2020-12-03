using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DevTeam_Repo
{
    public class DevTeamList
    {
        public string DevTeamName { get; set; }
        public string DevTeamNumber { get; set; }

        public DevTeamList()
        {

        }
        public DevTeamList(string devTeamName, string devTeamNumber)
        {
            DevTeamName = devTeamName;
            DevTeamNumber = devTeamNumber;
        }
    }
}
