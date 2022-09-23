using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    public class Pet  
    {
        // properties
        public string Name { get; set; }
        public string Species { get; set; }
        public int Hunger { get; set; }
        public int Boredom { get; set; }
        public int Health { get; set; }
     
        // Constructors

        public Pet()
        {
            Name = "";
            Species = "";
            Hunger = 60;
            Boredom = 60;
            Health = 60;
            
        }

        // Methods
        public Pet(string name, string species, int hunger, int boredom, int health)
        {
            Name=name;
            Species=species;
            Hunger=hunger;
            Boredom=boredom;
            Health=health;
            
        }
        public virtual void DisplayPet()
        {
            Console.WriteLine($"{Name,8} the {Species,8} --  Hunger = {Hunger}, Boredom = {Boredom}, Health = {Health}");
        }


        public virtual void Feed()
        {
            Hunger -= 20;
        }

        public virtual void SeeDoctor()
        {
            Health += 30;
        }

        public virtual void Play()
        {
            Hunger += 10;
            Boredom -= 20;
            Health += 10;
        }

        public virtual void Tick()
        {
            Hunger += 5;
            Boredom += 5;
            Health -= 5;
        }


    }

}
