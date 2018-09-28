using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelter
{
    class Managers:Employee
    {
        //PROPERTIES
        public int YearsEmployed { get; set; }

        //CONSTRUCTOR
        public Managers()
        {
        }
        public Managers(string name, int years)
        {
            EmployeeName = name;
            YearsEmployed = years;
        }
        //METHODS
        public override void ClockIn()
        {
           Console.WriteLine("Clock in time: 7:00AM");
        }

        public override void ShowID()
        {
            Console.WriteLine("Welcome Bob, your ID picture looks very handsome.");
        }
        public void Play(string pet)
        {
            Console.WriteLine("You played with {0}", pet);
        }
        public void AdoptPet()
        {
            int i = 1;
            Console.WriteLine("Select the dog you want to adopt");
            foreach (string pet in VirtualPetShelter.AllPets)
            {
                Console.WriteLine(i + ". " + pet);
                i++;
            }
            
            // display pet name + description of pet
        }        
    }
}
