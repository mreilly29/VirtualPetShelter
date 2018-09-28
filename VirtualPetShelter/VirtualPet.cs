using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelter
{
    class VirtualPet
    {
        //properties
        public string PetName { get; set; }
        public string PetDescription { get; set; }
        public int Hunger { get; set; }
        public int Thirst { get; set; }
        public int Affection { get; set; }

        //constructors
        public VirtualPet(string name, string desciption)
        {
            PetName = name;
            PetDescription = desciption;
        }

        public VirtualPet(int hunger, int thirst, int affection)
        {
            Hunger = hunger;
            Thirst = thirst;
            Affection = affection;
        }
    }
}
