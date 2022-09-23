using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    internal class OrganicPet : Pet
    {
        // Constructors

        public OrganicPet()
        {
            Name = "";
            Species = "";
            Hunger = 60;
            Boredom = 60;
            Health = 60;

        }

        // Methods
        public OrganicPet(string name, string species, int hunger, int boredom, int health)
        {
            Name = name;
            Species = species;
            Hunger = hunger;
            Boredom = boredom;
            Health = health;

        }
     

    }
}

    



