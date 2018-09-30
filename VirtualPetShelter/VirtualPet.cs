using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelter
{
    public class VirtualPet
    {
        //propetries
        public string PetName { get; set; }
        public string PetDescription { get; set; }
        public int Hunger { get; set; }
        public int Thirst { get; set; }
        public int Affection { get; set; }

        //constructors
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
        //methods
        public void Feed()
        {
            Hunger = 100;
            Thirst -= 20;
            Affection--; ;
        }
        public void Water()
        {
            Thirst = 100;
            Hunger -= 20;
            Affection--;
        }
        public void PlayTime()
        {
            Affection += 5;
            Thirst -= 15;
            Hunger -= 15;
        }
    }
}
