using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelter
{
    class Pet : VirtualPet
    {
        //PROPERTIES
        public string PetType { get; set; }
        public string Diet{ get; set; }

        //CONSTRUCTOR
        public Pet()
        {
        }
        public Pet(string name, string desciption,string type, string diet, int hunger, int thirst, int affection)
        {
            PetName = name;
            PetDescription = desciption;
            PetType = type;
            Diet = diet;
            Hunger = hunger;
            Thirst = thirst;
            Affection = affection;
        }
    }
}
