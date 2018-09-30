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
        public void Play(Pet dog)
        {
            dog.PlayTime();
            Console.WriteLine("You played with {0}", dog.PetName);
        }
        public void AdoptPet(int element)
        {
            VirtualPetShelter.AllPets.RemoveAt(element);
        }
    }
}
