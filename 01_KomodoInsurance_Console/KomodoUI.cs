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
        private static DeveloperRepo _developerRepo = new DeveloperRepo();
        private DevTeamRepo _devTeamRepo = new DevTeamRepo(_developerRepo);

      
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
                        RemoveDeveloper();
                        break;
                    case "10":
                        // Remove Developer from List
                        RemoveDeveloperFromTeam();
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
                //string continu;
                //do
                //{
                //    continu = Console.ReadLine().ToLower();
                //    if (!continu.Equals("yes") && !continu.Equals("no"))
                //    {
                //        Console.WriteLine("Please enter yes or no");
                //    }
                //}
                //while (!continu.Equals("yes") && !continu.Equals("no"));

                //if (continu.Equals("yes"))
                //{
                //    add = true;
               //}
                //else if (continu.Equals("no"))
                //{
                //    add = false;
                //}
                

                _developerRepo.AddDevelopersToList(newDeveloper);

                //Add another developer
                

                string contin;
                Console.WriteLine("Do you want to add another developer?");
                do
                {
                    contin = Console.ReadLine().ToLower();
                    if (!contin.Equals("yes") && !contin.Equals("no"))
                    {
                        Console.WriteLine("Please enter yes or no");
                    }
                }
                while (!contin.Equals("yes") && !contin.Equals("no"));

                if (contin.Equals("yes"))
                {
                    add = true;
                }
                else if (contin.Equals("no"))
                {
                    add = false;
                }
            }
        }
        //Add Team Name
        private void AddNewTeam()
        {
            bool add = true;
            while (add)
            {
                // Get Dev Team Name
                Console.WriteLine("What is new Team name: ");
                string devTeamName = Console.ReadLine().ToLower();
                //Add Dev Team ID
                Console.WriteLine("What is new Teamm ID: ");
                string devTeamID = Console.ReadLine().ToLower();

                
                DevTeam newDevTeam = new DevTeam(devTeamName, devTeamID);
                _devTeamRepo.AddDevTeamsToList(newDevTeam);

                //Add another devteam

                string contin;
                Console.WriteLine("Do you want to add another Team?");
                do
                {
                    contin = Console.ReadLine().ToLower();
                    if (!contin.Equals("yes") && !contin.Equals("no"))
                    {
                        Console.WriteLine("Please enter yes or no");
                    }
                } 
                while (!contin.Equals("yes") && !contin.Equals("no"));

                if (contin.Equals("yes"))
                {
                    add = true;
                }
                else if (contin.Equals("no"))
                {
                    add = false;
                } 
            }
        }

        //Add Team Members  dpesmt work
        private void AddTeamMembers()  
        {
            //Console.Clear();
            ViewTeamNames();
            List<DevTeam> listOfTeams = _devTeamRepo.GetDevTeamList();

            Console.WriteLine("Which Team do you want to add memebers to?  please give Team ID");
            string newT = Console.ReadLine().ToLower();

            ViewDeveloperList();

            Console.WriteLine("Which developer do you want to add?  Please give developers CompanyID");
            string newD = Console.ReadLine().ToLower();
            Console.WriteLine(newD);

            _devTeamRepo.AddDevelopersToTeam(newT, newD);



     
        }

        //View List of Developers
        private void ViewDeveloperList()
        {
            //Console.Clear();
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
            ViewDeveloperList();

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
            //Show list of developers that can be updated

            ViewDeveloperList();

            Console.WriteLine("Enter the Developer Company ID that you want to update:");
            
            // set the developer that you want changed
            string oldDeveloper = Console.ReadLine().ToLower();
            

            Developer newDeveloper = new Developer();

            Console.WriteLine("What is Developers first name: ");
            newDeveloper.FirstName = Console.ReadLine().ToLower();

            Console.WriteLine("What is Developers last name: ");
            newDeveloper.LastName = Console.ReadLine().ToLower();

            Console.WriteLine("What is Developers Company ID: ");
            newDeveloper.CompanyID = Console.ReadLine().ToLower();

            Console.WriteLine("Does the developer have Pluralsight: ");
            newDeveloper.Pluralsight = Console.ReadLine().ToLower();

            //add the new information on the developer
            _developerRepo.AddDevelopersToList(newDeveloper);

            //remove the old information on the developer
            _developerRepo.RemoveDeveloperFromList(oldDeveloper);
        }
        //Remove Developer from Team
        private void RemoveDeveloperFromTeam()
        {

        }
        //Remove Developer from list
        private void RemoveDeveloper()
        {
            ViewDeveloperList();

            Console.WriteLine("Which developer do you want to remove from the list? (please provide CompanyID");
            string inputs = Console.ReadLine().ToLower();

            bool wasDeleted = _developerRepo.RemoveDeveloperFromList(inputs);

            //Check to be sure content was removed

            if (wasDeleted)
            {
                Console.WriteLine("\nThe developer was successfully deleted.\n");
            }
            else
            {
                Console.WriteLine("\nThe developer could not be deleted.\n");
            }

            //display updated developer list
            Console.WriteLine("Updated developer list:\n");

            ViewDeveloperList();
        }
        // Remove Team from List
        private void RemoveDevTeamFromList()
        {

            ViewTeamNames();

            Console.WriteLine("Which DevTeam do you want to remove from the list? (please provide DevTeam ID");
            string inputs = Console.ReadLine().ToLower();

            bool wasDeleted = _devTeamRepo.RemoveDevTeamFromList(inputs);

            //List<DevTeam> listOfTeams = _devTeamRepo.GetDevTeamList();

            //foreach (DevTeam team in listOfTeams)
            //{
            //    Console.WriteLine($"Team Name: {team.DevTeamName}\n" +
            //        $"Team ID: {team.DevTeamID}\n" +
            //        $"");
            //}

            //Check to be sure content was removed

            if (wasDeleted == true)
            {
                Console.WriteLine("\nThe DevTeam was successfully deleted.\n");
            }
            else
            {
                Console.WriteLine("\nThe DevTeam could not be deleted.\n");
            }
            Console.WriteLine("Updated Team List\n");
            ViewTeamNames();
        }

    }
}

