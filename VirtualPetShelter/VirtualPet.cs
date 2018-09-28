using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelter
{
    class VirtualPet
    {
        //PROPERTIES
        public string PetName { get; set; }
        public string PetDescription { get; set; }
        public int Hunger { get; set; }
        public int Thirst { get; set; }
        public int Affection { get; set; }

        //CONSTRUCTORS
        public VirtualPet()
        {
        }
        public VirtualPet(string name, string desciption)
        {
            PetName = name;
            PetDescription = desciption;
        }
        public VirtualPet(string name, string desciption, int hunger, int thirst, int affection)
        {
            PetName = name;
            PetDescription = desciption;
            Hunger = hunger;
            Thirst = thirst;
            Affection = affection;
        }

        //METHODS
        //public void Feed()
        //{
        //    Hunger += 7;
        //    Thirst -= 2;
        //    Affection--;
        //    Console.WriteLine("You fed {0}.", PetName);
        //    Console.WriteLine();
        //}
        //public void Drink()
        //{
        //    Thirst += 10;
        //    Affection--;
        //    Console.WriteLine("You gave {0} water.", PetName);
        //    Console.WriteLine();
        //}
        //public void Play()
        //{
        //    Affection += 7;
        //    Console.WriteLine("You cuddled with {0}.", PetName);
        //    Console.WriteLine();
        //}
    }
}
