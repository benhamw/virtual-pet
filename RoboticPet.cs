using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace template_csharp_virtual_pet
{
    internal class RoboticPet : Pet
    {
        //Properties 

        public string Type { get; set; }
        public int Charge { get; set; }
        public int Maintenance { get; set; }


        // Constructors

        public RoboticPet()
        {
            Name = "";
            Type = "";
            Charge = 60;
            Maintenance = 60;
        }

        // Methods
        public RoboticPet(string name, string type, int charge, int maintenance)
        {
            Name = name;
            Type = type;
            Charge = charge;
            Maintenance = maintenance;

        }
        public override void DisplayPet()
        {
            Console.WriteLine($"{Name,8} the {Type,8} --  Maintenance = {Maintenance}, Charge = {Charge}");
        }
        public override void Feed()
        {
            Charge += 10;
        }

        public override void SeeDoctor()
        {
            Maintenance -= 10;
        }

        public override void Play()
        {
            Charge -= 10;
            Maintenance += 10;
        }
        public override void Tick()
        {
            Charge -= 5;
            Maintenance += 5;
        }
    }

}
