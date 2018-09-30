using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Managers:Employee
    {
        //properties
        public int YearsEmployed { get; set; }

        //constructors
        public Managers()
        {
        }
        public Managers(string name, int years)
        {
            EmployeeName = name;
            YearsEmployed = years;
        }
        //override methods
        public override void ClockIn()
        {
            Console.WriteLine("Clock in time: 7:00AM");
        }

        public override void ShowID()
        {
            Console.WriteLine("Welcome Bob, your ID picture looks very handsome.");
        }
        
        //methods
        public void Play(Pet dog)
        {            
            dog.PlayTime();
            Console.WriteLine("You played with {0}", dog.PetName);
        }

        public void AdoptPet(int element)
        {
            //removes pet from list
            VirtualPetShelter.AllPets.RemoveAt(element);
        }
    }
}
