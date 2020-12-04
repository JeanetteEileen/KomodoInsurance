using _01_DevTeam_Repo;
using _01_KomodoInsurance_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_KomodoInsurance_Console
{
    class KomodoUI
    {
        private DeveloperRepo _developerRepo = new DeveloperRepo();
        private DevTeamRepo _devTeamRepo = new DevTeamRepo();
        public void Run()
        {
            KomodoMenu();
        }
        // Menu
        private void KomodoMenu()
        {
            bool stayRunning = true;
            while (stayRunning)
            {



                //Display options
                Console.WriteLine("Please select an option from the list\n" +
                    "1.  Add Developer\n" +
                    "2.  Add Team Name\n" +
                    "3.  Add Team Members to Team\n" +
                    "4.  View List of Developers \n" +
                    "5.  View Team Name\n" +
                    "6.  View Team Members\n" +
                    "7.  View Developer Pluralsight status\n" +
                    "8.  Update Developer Information\n" +
                    "9.  Remove Developer from List\n" +
                    "10. Remove Team Members\n" +
                    "11. Remove Team from List\n" +
                    "12. Exit");

                //Get the user input
                string userinput = Console.ReadLine();

                //Evaluate input and act on input
                switch (userinput)
                {
                    case "1":
                        // Add Developer
                        AddNewDeveloper();
                        break;
                    case "2":
                        // Add Team Name
                        AddNewTeam();
                        break;
                    case "3":
                        // Add Team Members
                        AddTeamMembers();
                        break;
                    case "4":
                        // View List of Developers
                        ViewDeveloperList();
                        break;
                    case "5":
                        // View Team Names
                        ViewTeamNames();
                        break;
                    case "6":
                        // View Team Members
                        ViewTeamMembers();
                        break;
                    case "7":
                        // View Pluralsight status
                        ViewPluralsight();
                        break;
                    case "8":
                        // Update Developer Information
                        UpdateDeveloperInfo();
                        break;
                    case "9":
                        // Remove Developer from Team
                        RemoveDeveloperFromTeam();
                        break;
                    case "10":
                        // Remove Developer from List
                        RemoveDeveloper();
                        break;
                    case "11":
                        // Remove Team from List
                        RemoveDevTeamFromList();
                        break;
                    case "12":
                        // Exit menu
                        Console.WriteLine("Thanks Goodbye");
                        stayRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number");
                        break;
                }
                Console.WriteLine("Please Press any key to Continue...");



                Console.ReadKey();
                Console.Clear();
            }
        }
        //Add Developer
        private void AddNewDeveloper()
        {
            bool add = true;
            while (add)
            {
                Developer newDeveloper = new Developer();
                // Get Developer first name
                Console.WriteLine("Enter developer's first name:");
                newDeveloper.FirstName = Console.ReadLine().ToLower();

                // Get Developer last name
                Console.WriteLine("Enter developer's last name:");
                newDeveloper.LastName = Console.ReadLine().ToLower();

                // Get Developer CompanyID
                Console.WriteLine("Enter developer's Company ID");
                newDeveloper.CompanyID = Console.ReadLine().ToLower();

                // Get Pluralsight yes/no
                Console.WriteLine("Does developer have Pluralsight license? (yes/no)");
                newDeveloper.Pluralsight = Console.ReadLine().ToLower();

                _developerRepo.AddDevelopersToList(newDeveloper);

                //Add another developer
                Console.WriteLine("Do you want to add another developer?");
                string contin = Console.ReadLine().ToLower();
                if (contin == "yes")
                {
                    add = true;
                }
                else
                {
                    add = false;
                }
                Console.Clear();
            }
        }
        //Add Team Name
        private void AddNewTeam()
        {
       
            DevTeam newDevTeam = new DevTeam();
            // Get Dev Team Name
            Console.WriteLine("What is new Team name: ");
            newDevTeam.DevTeamName = Console.ReadLine().ToLower();
            //Add Dev Team ID
            Console.WriteLine("What is new Teamm ID: ");
            newDevTeam.DevTeamID = Console.ReadLine().ToLower();

            _devTeamRepo.AddDevTeamsToList(newDevTeam);
        }

        //Add Team Members
        private void AddTeamMembers()  //needs work
        {
            Console.Clear();
            List<DevTeam> listOfTeams = _devTeamRepo.GetDevTeamList();

            foreach (DevTeam team in listOfTeams)
            {
                Console.WriteLine($"Team Name: {team.DevTeamName}\n" +
                    $"Team ID: {team.DevTeamID}\n" +
                    $"");
                Console.WriteLine("Which team do you want to add members?  please give the TeamID");
                string newteam = Console.ReadLine().ToLower();

                Console.WriteLine("Which developer CompanyID do you want to add to the team?");
                string newMember = Console.ReadLine();

               

               

            }
        }

        //View List of Developers
        private void ViewDeveloperList()
        {
            Console.Clear();
            List<Developer> listOfDevelopers = _developerRepo.GetDeveloperList();

            foreach (Developer developer in listOfDevelopers)
            {
                Console.WriteLine($"Name: {developer.FirstName} {developer.LastName}\n" +
                    $"CompanyID: { developer.CompanyID}\n" +
                    $"Pluralsight: {developer.Pluralsight}\n" +
                    $"");
            }
        }

        //View Team Names
        private void ViewTeamNames()
        {
            Console.Clear();
            List<DevTeam> listOfTeams = _devTeamRepo.GetDevTeamList();

            foreach (DevTeam team in listOfTeams)
            {
                Console.WriteLine($"Team Name: {team.DevTeamName}\n" +
                    $"Team ID: {team.DevTeamID}\n" +
                    $"");
            }

        }
        //View Team Members  still need to finish********
        private void ViewTeamMembers()
        {
            Console.Clear();
            List<DevTeam> listOfTeams = _devTeamRepo.GetDevTeamList();

        }
        //View if Developer has Pluralsight
        private void ViewPluralsight()
        {
            List<Developer> listOfDevelopers = _developerRepo.GetDeveloperList();

            foreach (Developer developer in listOfDevelopers)
            {
                string plural = developer.Pluralsight;
                if (plural == "no")
                {
                    Console.WriteLine($"Name: {developer.FirstName} {developer.LastName}\n" +
                $"CompanyID: { developer.CompanyID}\n" +
                $"Pluralsight: {developer.Pluralsight}\n" +
                $"");
                }
                else
                {
                    break;  
                }
                Console.WriteLine("All Developers have Pluralsight");
            }

        }
        //Update Developer Information
        private void UpdateDeveloperInfo()
        {
            Console.WriteLine("Enter the Developer Company ID that you want to update Pluralsight:");
            //string oldDeveloper = Console.ReadLine().ToLower();

            Developer newDeveloper = new Developer();

            Console.WriteLine("What is Developers first name: ");
            newDeveloper.FirstName = Console.ReadLine().ToLower();

            Console.WriteLine("What is Developers last name: ");
            newDeveloper.LastName = Console.ReadLine().ToLower();

            Console.WriteLine("What is Developers Company ID: ");
            newDeveloper.CompanyID = Console.ReadLine().ToLower();

            Console.WriteLine("What is Developers Pluralsight status: ");
            newDeveloper.Pluralsight = Console.ReadLine().ToLower();
        }
        //Remove Developer from Team
        private void RemoveDeveloperFromTeam()
        {

        }
        //Remove Developer from list
        private void RemoveDeveloper()
        {
            List<Developer> listOfDevelopers = _developerRepo.GetDeveloperList();
            foreach (Developer developer in listOfDevelopers)
            {
                Console.WriteLine($"Name: {developer.FirstName} {developer.LastName}\n" +
                    $"CompanyID: { developer.CompanyID}\n" +
                    $"Pluralsight: {developer.Pluralsight}\n" +
                    $"");
            }

            Console.WriteLine("Which developer do you want to remove from the list? (please provide CompanyID");
            string inputs = Console.ReadLine().ToLower();

            bool wasDeleted = _developerRepo.RemoveDeveloperFromList(inputs);

            //Check to be sure content was removed

            if (wasDeleted)
            {
                Console.WriteLine("The developer was successfully deleted.");
            }
            else
            {
                Console.WriteLine("The developer could not be deleted.");
            }


        }
        // Remove Team from List
        private void RemoveDevTeamFromList()
        {
            
            Console.Clear();
            List<DevTeam> listOfTeams = _devTeamRepo.GetDevTeamList();

            foreach (DevTeam team in listOfTeams)
            {
                Console.WriteLine($"Team Name: {team.DevTeamName}\n" +
                    $"Team ID: {team.DevTeamID}\n" +
                    $"");
            }
            Console.WriteLine("Which DevTeam do you want to remove from the list? (please provide DevTeam ID");
            string inputs = Console.ReadLine().ToLower();

            bool wasDeleted = _devTeamRepo.RemoveDevTeamFromList(inputs);

            //Check to be sure content was removed

            if (wasDeleted)
            {
                Console.WriteLine("The DevTeam was successfully deleted.");
            }
            else
            {
                Console.WriteLine("The DevTeam could not be deleted.");
            }
        }

    }
}

