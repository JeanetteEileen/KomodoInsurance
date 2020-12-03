using _01_KomodoInsurance_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Developer_Tests
{
    [TestClass]
    public class DeveloperTests
    {
        [TestMethod]
        public void SetDeveloperCompanyID_ShouldGetCorrectID()
        {
            DeveloperList id = new DeveloperList();

            id.CompanyID = "123456D";

            string expectId = "123456D";
            string actualId = id.CompanyID;

            Assert.AreEqual(expectId, actualId);
        }
        [TestMethod]
        public void SetDeveloperFirstName_ShouldGetCorrectName()
        {
            DeveloperList firstName = new DeveloperList();

            firstName.FirstName = "Joe";

            string expectedFirst = "Joe";
            string actualFirst = firstName.FirstName;

            Assert.AreEqual(expectedFirst, actualFirst);
        }
        [TestMethod]
        public void SetDeveloperLasttName_ShouldGetCorrectLastName()
        {
            DeveloperList lastName = new DeveloperList();

            lastName.LastName = "Smith";

            string expectedLast = "Smith";
            string actualLast = lastName.LastName;

            Assert.AreEqual(expectedLast, actualLast);
        }
        [TestMethod]
        public void SetDevTeamID_ShouldGetCorrectID()
        {
            DeveloperList teamid = new DeveloperList();

            teamid.DevTeamId = "1d";

            string expectedID = "1d";
            string actualID = teamid.DevTeamId;

            Assert.AreEqual(expectedID, actualID);
        }
        [TestMethod]
        public void SetDevTeamName_ShouldGetCorrectName() 
        {
            DeveloperList teamName = new DeveloperList();

            teamName.DevTeamName = "Team 1";

            string expectTeamName = "Team 1";
            string actualTeamName = teamName.DevTeamName;

            Assert.AreEqual(expectTeamName, actualTeamName);
        }
        [TestMethod]
        public void Pluralsight_Shouldgettrue()
        {
            DeveloperList plural = new DeveloperList();

            plural.Pluralsight = "yes";

            string expectPlural = "yes";
            string actualPlural = plural.Pluralsight;

            Assert.AreEqual(expectPlural, actualPlural);
        }
    }
}
