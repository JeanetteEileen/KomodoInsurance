using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_KomodoInsurance_Repository
{
    public class DeveloperRepo
    {
        private List<Developer> _listOfDevelopers = new List<Developer>();

        //Create
        public void AddDevelopersToList(Developer member)
        {
            _listOfDevelopers.Add(member);

        }

        //Read
        public List<Developer> GetDeveloperList()
        {
            return _listOfDevelopers;
        }

        //UPdate
        public bool UpdateExistingDeveloperList(string originalDeveloperList, Developer newDeveloperList)
        {
            //Find member list
            Developer oldList = GetMemberByID(originalDeveloperList);

            //Update member list
            if (oldList != null)
            {
                oldList.FirstName = newDeveloperList.FirstName;
                oldList.LastName = newDeveloperList.LastName;
                oldList.CompanyID = newDeveloperList.CompanyID;
                oldList.Pluralsight = newDeveloperList.Pluralsight;               
                return true;
            }
            else
            {
                return false;
            }
        }
     

        //Delete
        public bool RemoveDeveloperFromList(string companyID)
        {
            Developer member = GetMemberByID(companyID);
            
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
        public Developer GetMemberByID(string companyID)
        {
            foreach (Developer member in _listOfDevelopers)
            {
                if (member.CompanyID == companyID)
                {
                    return member;
                }
            }

            return null;
        }



    }
}
