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
            bool isVolunteer = true;
            bool isManager = true;

            //instantiate 3 pets
            Pet harry = new Pet("Harry", "2 years old. Energetic and lovable. Loves to cuddle.", "Beagle", "wet food", 67 , 85, 43);
            Pet dingle = new Pet("Dingle", "1.5 years old. Talkative and needs lots of exercise!", "Husky", "wet food", 33, 76, 87);
            Pet lola = new Pet("Lola", "8 years old. Couch potato looking for someone to chill with.", "Boxer", "dry food", 88, 53, 79);
            //instantiate 2 employees: 1 volunteer, 1 manager
            Volunteers tiffany = new Volunteers("Tiffany", "Pro Volunteer");
            Managers greg = new Managers("Greg", 7);

            //add pet names to static list
            VirtualPetShelter.AllPets.Add(harry.PetName);
            VirtualPetShelter.AllPets.Add(dingle.PetName);
            VirtualPetShelter.AllPets.Add(lola.PetName); 
            //add employees static list
            VirtualPetShelter.AllEmployees.Add(tiffany.EmployeeName);
            VirtualPetShelter.AllEmployees.Add(greg.EmployeeName);

            Console.WriteLine("Welcome to Dogs-R-Cool Virtual Pet Shelter. \nWhat employee type are you? \n1) Volunteer \n2) Manager\n");
            int input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                Console.WriteLine("\nThank you for volunteering {0}!", tiffany.EmployeeName);
                isManager = false;
            }
            else if (input == 2)
            {
                Console.WriteLine("Thank you for working at Dogs-R-Cool Virtual Pet Shelter!");
                isVolunteer = false;
            }
            else
            {
                Console.WriteLine("Invalid entry.");
                isManager = false;
                isVolunteer = false;
            }

            while (isVolunteer == true) {
                // tiffany.PetStatus();
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1. Feed the pets");
                Console.WriteLine("2. Give the pets water");
                Console.WriteLine("3. Play with a pet");
                Console.WriteLine("4. Quit\n");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        tiffany.FeedAll();
                        break;
                    case 2:
                        tiffany.WaterAll();
                        break;
                    case 3:
                        Console.WriteLine("Which pet would you like to play with?");
                        Console.WriteLine("1. {0}\n2. {1}\n3. {2}\n", harry.PetName, dingle.PetName, lola.PetName);
                        int value = int.Parse(Console.ReadLine());
                        if (value == 1)
                        {
                            tiffany.Play(harry.PetName);
                            harry.Affection += 10;
                        } else if (value == 2)
                        {
                            tiffany.Play(dingle.PetName);
                            dingle.Affection += 10;
                        }
                        else if (value == 3)
                        {
                            tiffany.Play(lola.PetName);
                            lola.Affection += 10;
                        }
                        else { Console.WriteLine("invalid entry."); }
                        break;
                    case 4:
                        Console.WriteLine("\nThanks for volunteering! Come back soon!");
                        isVolunteer = false;
                        break;
                    default:
                        break;

                }
            }

            while(isManager == true)
            { 
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1. Adopt a pet");
                Console.WriteLine("2. Pay the bills");
                Console.WriteLine("3. Play with a pet");
                Console.WriteLine("4. Quit\n");
                int inputTwo = int.Parse(Console.ReadLine());
                switch (inputTwo)
                {
                    case 1:
                        greg.AdoptPet();
                        int value = int.Parse(Console.ReadLine());
                        
                        if (value == 1)
                        {
                            Console.WriteLine("{0} was adopted!", harry.PetName);
                        }
                        else if (value == 2)
                        {
                            Console.WriteLine("{0} was adopted!", dingle.PetName);
                        }
                        else if (value == 3)
                        {
                            Console.WriteLine("{0} was adopted!", lola.PetName);
                        }
                        break;

                    case 2:
                        Console.WriteLine("You paid the bills");
                        break;

                    case 3:
                        Console.WriteLine("Which pet would you like to play with?");
                        Console.WriteLine("1. {0}\n2. {1}\n3. {2}", harry.PetName, dingle.PetName, lola.PetName);
                        int valueOne = int.Parse(Console.ReadLine());
                        if (valueOne == 1)
                        {
                            greg.Play(harry.PetName);
                            harry.Affection += 10;
                        }
                        else if (valueOne == 2)
                        {
                            greg.Play(dingle.PetName);
                            dingle.Affection += 10;
                        }
                        else if (valueOne == 3)
                        {
                            greg.Play(lola.PetName);
                            lola.Affection += 10;
                        }
                        else { Console.WriteLine("invalid entry."); }
                        break;

                    case 4:
                        Console.WriteLine("Have a good day!");
                        isManager = false;
                        break;

                    default:
                        break;
                }
            }            
        }
    } 
}
