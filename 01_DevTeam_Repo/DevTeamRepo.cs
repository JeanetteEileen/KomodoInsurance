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
                oldList.DevTeamNumber = newTeamList.DevTeamNumber;
                
                return true;
            }
            else
            {
                return false;
            }
        }

        //Delete
        public bool RemoveDevTeamFromList(string devTeamNumber, string teamName)
        {
            DevTeam teamNum = GetTeamByID(devTeamNumber);

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
        private DevTeam GetTeamByID(string devTeamNumber)
        {
            foreach (DevTeam team in _listOfTeam)
            {
                if (team.DevTeamNumber == devTeamNumber)
                {
                    return team;
                }
            }

            return null;
        }
    }
}
