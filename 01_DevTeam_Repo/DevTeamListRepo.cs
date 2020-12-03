using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DevTeam_Repo
{
    public class DevTeamListRepo
    {
        public List<DevTeamList> _listOfTeam = new List<DevTeamList>();

        //Create
        public void AddDevTeamsToList(DevTeamList team)
        {
            _listOfTeam.Add(team);

        }

        //Read
        public List<DevTeamList> GetDevTeamList()
        {
            return _listOfTeam;
        }

        //Update
        public bool UpdateExistingDevTeamList(string originalTeamList, DevTeamList newTeamList)
        {
            //Find member list
            DevTeamList oldList = GetTeamByID(originalTeamList);

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
            DevTeamList teamNum = GetTeamByID(devTeamNumber);

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
        private DevTeamList GetTeamByID(string devTeamNumber)
        {
            foreach (DevTeamList team in _listOfTeam)
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
