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
        public int Salary { get; set; }

        //CONSTRUCTOR
        public Managers()
        {
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
        public void AdoptPet()
        {
            
            // display pet name + description of pet
            Console.WriteLine("You adopted a pet!");

        }

        public void PetStatus()
        {
            //FILL IN
        }
    }
}
