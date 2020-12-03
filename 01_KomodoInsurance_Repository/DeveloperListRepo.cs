using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_KomodoInsurance_Repository
{
    public class DeveloperListRepo
    {
        private List<DeveloperList> _listOfDevelopers = new List<DeveloperList>();

        //Create
        public void AddDevelopersToList(DeveloperList member)
        {
            _listOfDevelopers.Add(member);

        }

        //Read
        public List<DeveloperList> GetDeveloperList()
        {
            return _listOfDevelopers;
        }

        //UPdate
        public bool UpdateExistingDeveloperList(string originalDeveloperList, DeveloperList newDeveloperList)
        {
            //Find member list
            DeveloperList oldList = GetMemberByID(originalDeveloperList);

            //Update member list
            if (oldList != null)
            {
                oldList.FirstName = newDeveloperList.FirstName;
                oldList.LastName = newDeveloperList.LastName;
                oldList.Pluralsight = newDeveloperList.Pluralsight;
                oldList.CompanyID = newDeveloperList.CompanyID;
                oldList.DevTeamId = newDeveloperList.DevTeamId;
                oldList.DevTeamName = newDeveloperList.DevTeamName;
                oldList.Pluralsight = newDeveloperList.Pluralsight;
                oldList.PluralsightExpiration = newDeveloperList.PluralsightExpiration;
                return true;
            }
            else
            {
                return false;
            }
        }


        //Delete
        public bool RemoveDeveloperFromList(string companyID, string lastName)
        {
            DeveloperList member = GetMemberByID(companyID);
            
            if (member == null)
            {
                return false;
            }

            int initialCount = _listOfDevelopers.Count;
            _listOfDevelopers.Remove(member);
            if (initialCount > _listOfDevelopers.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Helper method
        private DeveloperList GetMemberByID(string companyID)
        {
            foreach (DeveloperList member in _listOfDevelopers)
            {
                if(member.CompanyID == companyID)
                {
                    return member;
                }
            }

            return null;
        }
        
    }
}
