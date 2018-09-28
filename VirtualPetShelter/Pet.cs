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
    }
}
