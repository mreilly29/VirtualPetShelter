using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelter
{
    class Volunteers:Employee
    {
        //PROPERTY
        public string Specialty { get; set; }
        
        //CONSTRUCTOR
        public Volunteers()
        {
        }
        //METHODS
        public void FeedAll()
        {
            Console.WriteLine("All pets have been fed.");
        }

        public void WaterAll()
        {
            Console.WriteLine("All pets have gotten water.");
        }

        public void Cuddle(string pet)
        {
            Console.WriteLine("You cuddled with {0}", pet);
        }

        public void PetStatus()
        {
            //FILL IN
        }
        
        //override methods
        public override void ClockIn()
        {
            Console.WriteLine(EmployeeName + " clocked in at 8:00AM");
        }

        public override void ShowID()
        {
            Console.WriteLine("Welcome {0}. The animals are waiting for your", EmployeeName);
        }
        
    }
}
