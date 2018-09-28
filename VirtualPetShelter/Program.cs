using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet harry = new Pet("Harry", "2 years old. Energetic and lovable. Loves to cuddle.", "Beagle", "wet food");
            Pet dingle = new Pet("Dingle", "1.5 years old. Talkative and needs lots of exercise!", "Husky", "wet food");
            Pet lola = new Pet("Lola", "8 years old. Couch potato looking for someone to chill with.", "Boxer", "dry food");
            lola.PetName = "Lola";
        }
    } 
}
