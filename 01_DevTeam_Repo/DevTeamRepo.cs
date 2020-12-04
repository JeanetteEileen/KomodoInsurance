using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DevTeam_Repo
{
    public class DevTeamRepo
    {
        public List<DevTeam> _listOfTeam = new List<DevTeam>();

        //Create
        public void AddDevTeamsToList(DevTeam team)
        {
            _listOfTeam.Add(team);

        }
        //Build Team
        public void AddDevelopersToTeam(string devTeamID, string companyID)

        {
            //Find team to add developers to

            GetDevTeamList();
           
            //Pick team to add developer to
            GetTeamByID(devTeamID);

            //Get Developer ID
            GetMemberByID(companyID);

            //Add developer to team
        }
        //Read
        public List<DevTeam> GetDevTeamList()
        {
            return _listOfTeam;
        }

        //Update
        public bool UpdateExistingDevTeamList(string originalTeamList, DevTeam newTeamList)
        {
            //Find member list
            DevTeam oldList = GetTeamByID(originalTeamList);

            //Update member list
            if (oldList != null)
            {
                oldList.DevTeamName = newTeamList.DevTeamName;
                oldList.DevTeamID = newTeamList.DevTeamID;
                
                return true;
            }
            else
            {
                return false;
            }
        }
         
        //Delete
        public bool RemoveDevTeamFromList(string devTeamID)
        {
            DevTeam teamNum = GetTeamByID(devTeamID);

            if (teamNum == null)
            {
                return false;
            }

            int initialCount = _listOfTeam.Count;
            _listOfTeam.Remove(teamNum);
            if (initialCount > _listOfTeam.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //helper method
        private DevTeam GetTeamByID(string devTeamID)
        {
            foreach (DevTeam team in _listOfTeam)
            {
                if (team.DevTeamID == devTeamID)
                {
                    return team;
                }
            }

            return null;
        }
    }
}
