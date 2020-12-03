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
