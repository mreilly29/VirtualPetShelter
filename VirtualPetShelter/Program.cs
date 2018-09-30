using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelter
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //bools for while loops
            bool isVolunteer = true;
            bool isManager = true;

            //instantiate 3 pet objects
            Pet harry = new Pet("Harry", "2 years old. Energetic and lovable. Loves to cuddle!", "Beagle", "wet food", 67, 85, 43);
            Pet dingle = new Pet("Dingle", "1.5 years old. Talkative and needs lots of exercise!", "Husky", "wet food", 33, 76, 87);
            Pet lola = new Pet("Lola", "8 years old. Couch potato looking for someone to chill with.", "Boxer", "dry food", 88, 53, 79);
            //instantiate 1 volunteer object and 1 manager object
            Volunteers tiffany = new Volunteers("Tiffany", "Pro Volunteer");
            Managers greg = new Managers("Greg", 7);

            //add pet names to static list in VirtualPetShelter
            VirtualPetShelter.AllPets.Add(harry);
            VirtualPetShelter.AllPets.Add(dingle);
            VirtualPetShelter.AllPets.Add(lola);
            //add employees static list in VirtualPetShelter
            VirtualPetShelter.AllEmployees.Add(tiffany);
            VirtualPetShelter.AllEmployees.Add(greg);

            //asks user to input which employee type they are
            Console.WriteLine("Welcome to Dogs-R-Cool Virtual Pet Shelter. \nWhat employee type are you? \n1) Volunteer \n2) Manager\n");
            int input = int.Parse(Console.ReadLine());
            
            if (input == 1)//enter 1, user is volunteer
            {
                Console.WriteLine("\nThank you for volunteering {0}!", tiffany.EmployeeName);
                //changes isManager to false. Will not enter into while loop for manager 
                isManager = false;
            }
            else if (input == 2)//enter 1, user is manager
            {
                Console.WriteLine("Thank you for working at Dogs-R-Cool Virtual Pet Shelter!");
                //changes isVolunteer to false. Will not enter into while loop for volunteer 
                isVolunteer = false;
            }
            else
            {
                //if user input is invalid 
                Console.WriteLine("Invalid entry.");
                isManager = false;
                isVolunteer = false;
            }

            //Enters loop if isVolunteer is true
            while (isVolunteer == true)
            {
                //displays current status of pets
                tiffany.PetStatus(VirtualPetShelter.AllPets);
                //displays menu options for volunteer choose from
                VolunteerMenu();
                int option = int.Parse(Console.ReadLine());
                //an action will happen based on selected menu item
                switch (option)
                {
                    case 1: //feed all pets
                        tiffany.FeedAll(VirtualPetShelter.AllPets);
                        break;

                    case 2: //Water all pets
                        tiffany.WaterAll(VirtualPetShelter.AllPets);
                        break;

                    case 3: //Play with pet                       
                        DisplayNames();
                        //takes in input to use as index in list
                        int valueOne = int.Parse(Console.ReadLine()) - 1;
                        //selects pet from the list in VirtualPetShelter at the element index of value
                        Pet dogPlay = VirtualPetShelter.AllPets.ElementAt(valueOne);
                        //passes selected dog into play method
                        tiffany.Play(dogPlay);                       
                        break;

                    case 4: //exits application
                        Console.WriteLine("\nThanks for volunteering! Come back soon!");
                        isVolunteer = false;
                        break;

                    default: //invalid input
                        Console.WriteLine("Invalid entry.");
                        break;
                }
            }

            //Enters loop if isManager is true
            while (isManager == true)
            {
                //displays manager menu of options to choose from
                ManagerMenu();
                int inputTwo = int.Parse(Console.ReadLine());
                //an action will happen based on selected menu item
                switch (inputTwo)
                {
                    case 1://Adopt a pet
                        //enters if statement only when all pets have been adopted
                        if (VirtualPetShelter.AllPets.Count() == 0)
                        {
                            Console.WriteLine("All dogs have been adopted!");
                            break;
                        }
                        //displays pet and their descriptions
                        Console.WriteLine("Which pet would you like to adopt?");
                        int i = 1;
                        foreach (Pet dog in VirtualPetShelter.AllPets)
                        {
                            Console.WriteLine("{0}. {1}: {2}", i, dog.PetName, dog.PetDescription);
                            i++;
                        }
                        //takes in input to use as index in list
                        int value = int.Parse(Console.ReadLine()) - 1;
                        //selects pet from the list in VirtualPetShelter at the element index of value
                        Pet adoptedPet = VirtualPetShelter.AllPets.ElementAt(value);
                        Console.WriteLine("{0} was adopted!", adoptedPet.PetName);
                        //calls AdoptPet method - uses parameter to remove pet at that index of the list
                        greg.AdoptPet(value);
                        break;

                    case 2: //pay the bills
                        Console.WriteLine("You paid the bills");
                        break;

                    case 3: //play with pet
                        //displays pet names
                        DisplayNames();
                        //takes in input to use as index in list
                        int valueOne = int.Parse(Console.ReadLine()) - 1;
                        //selects pet from the list in VirtualPetShelter at the element index of value
                        Pet dogPlay = VirtualPetShelter.AllPets.ElementAt(valueOne);
                        //passes selected dog into play method
                        greg.Play(dogPlay);
                        break;

                    case 4: //exits application
                        Console.WriteLine("Have a good day!");
                        isManager = false;
                        break;

                    default: //invalid input
                        Console.WriteLine("Invalid entry.");
                        break;
                }
            }
        }

        //method that displays menu for volunteer
        public static void VolunteerMenu()
        {
            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("1. Feed the pets");
            Console.WriteLine("2. Give the pets water");
            Console.WriteLine("3. Play with a pet");
            Console.WriteLine("4. Quit\n");
        }

        //method that displays menu for manager
        public static void ManagerMenu()
        {
            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("1. Adopt a pet");
            Console.WriteLine("2. Pay the bills");
            Console.WriteLine("3. Play with a pet");
            Console.WriteLine("4. Quit\n");
        }

        //method that displays pet names using list in VirtualPetShelter
        public static void DisplayNames()
        {
            Console.WriteLine("\nWhich pet would you like to play with?");
            int i = 1;
            foreach (Pet dog in VirtualPetShelter.AllPets)
            {
                Console.WriteLine("{0}. {1}", i, dog.PetName);
                i++;
            }
        }
    }    
}
