using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelter
{
    public class Pet : VirtualPet
    {
        //PROPERTIES
        public string PetType { get; set; }
        public string Diet { get; set; }

        //CONSTRUCTOR
        public Pet()
        {
        }
        public Pet(string name, string desciption, string type, string diet, int hunger, int thirst, int affection)
        {
            PetName = name;
            PetDescription = desciption;
            PetType = type;
            Diet = diet;
            Hunger = hunger;
            Thirst = thirst;
            Affection = affection;
        }

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
