using _01_DevTeam_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace DevTeam_Tests
{
    [TestClass]
    public class DevTeamTests
    {
        private DevTeamRepo _repo;
        private DevTeam _team;

        [TestInitialize]
        public void Prep()
        {
            _repo = new DevTeamRepo();
            _team = new DevTeam();

            _repo.AddDevTeamsToList(_team);
        }

        // Add Dev Team
        [TestMethod]
        public void AddToDevTeamList_ShoultNotGetNull()
        {
            //Arrange
            DevTeam name = new DevTeam();
            name.DevTeamName = "Team 1";
            DevTeamRepo repo = new DevTeamRepo();

            //Act by add
            repo.AddDevTeamsToList(name);
            List<DevTeam> teamsFromRepo = repo.GetDevTeamList(); 

            //Assert
            //Assert.IdNotNull(teamsFromRepo);
        }
        //Update

        [TestMethod]
        public void UpdateExistingDevTeamList_ShouldReturnTrue()
        {
            // Arrange
            // TestInitialize
            Prep();
            DevTeam newTeam = new DevTeam();

            //Act
            bool updateTeam = _repo.UpdateExistingDevTeamList("1 d", newTeam);

            // Assert
            Assert.IsTrue(updateTeam);
         }
        [DataTestMethod]
        [DataRow("Team 1", true)]
        [DataRow("Team 2", true)]
        public void UpdateExistingTeamList_ShouldMatchBool(string originalTeamList, bool shouldUpdate)
        {
            // Arrange
            // TestInitialize
            Prep();
            DevTeam newTeam = new DevTeam();

            //Act
            bool updateTeam = _repo.UpdateExistingDevTeamList("1 d", newTeam);

            // Assert
            Assert.AreEqual(shouldUpdate, updateTeam);
        }
        // Delete
        [TestMethod]
        public void RemoveTeamFromList_ShouldMatchBool()
        {
            // Arrange
            
            // Act

            bool deleteTeam = _repo.RemoveDevTeamFromList("1 d", "Team 1");

            // Assert
            Assert.IsTrue(deleteTeam);
        }
    }
}
