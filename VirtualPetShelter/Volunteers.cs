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
        public string VolunteerRank { get; set; }

        //CONSTRUCTOR
        public Volunteers()
        {
        }
        public Volunteers(string name, string rank)
        {
            EmployeeName = name;
            VolunteerRank = rank;
        }
        //METHODS
        public void FeedAll(List<Pet> allDogs)
        {
            foreach (Pet dog in allDogs)
            {
                dog.Feed();
            }
            Console.WriteLine("All pets have been fed.\n");
        }

        public void WaterAll(List<Pet> allDogs)
        {
            foreach (Pet dog in allDogs)
            {
                dog.Water();
            }
            Console.WriteLine("All pets have gotten water.\n");
        }

        public void Play(Pet dog)
        {
            dog.PlayTime();
            Console.WriteLine("\nYou played with {0}\n", dog.PetName);
            //return dog;
        }

        public void PetStatus(List<Pet> allDogs)
        {
            Console.WriteLine("Pet status\n");
            Console.WriteLine("  Name    | Hunger | Thirst | Affection");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("  {0}   | {1}     | {2}     | {3}", allDogs[0].PetName, allDogs[0].Hunger, allDogs[0].Thirst, allDogs[0].Affection);
            Console.WriteLine("  {0}  | {1}     | {2}     | {3}", allDogs[1].PetName, allDogs[1].Hunger, allDogs[1].Thirst, allDogs[1].Affection);
            Console.WriteLine("  {0}    | {1}     | {2}     | {3}", allDogs[2].PetName, allDogs[2].Hunger, allDogs[2].Thirst, allDogs[2].Affection);

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
