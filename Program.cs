
using System.Runtime.InteropServices;
using template_csharp_virtual_pet;

Pet thisPet;
thisPet = new Pet();
Pet pet1 = new Pet("Fido", "dog", 60, 60, 60);
Pet pet2 = new Pet("Fluffy", "cat", 60, 60, 60);
Pet pet3= new Pet("Lucky", "gold fish", 60, 60, 60);
Pet pet4= new Pet("Polly", "parrot", 60, 60, 60);
Pet pet5= new Pet("Ray", "Gecko", 60, 60, 60);

List<Pet> petShelter = new List<Pet>() { pet1, pet2, pet3, pet4, pet5};

bool continueRunning = true;
while (continueRunning)
{
    Console.Clear();
    Console.WriteLine("Welcome to Virtual Pet!\n");
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. Create your pet.");
    Console.WriteLine("2. See your pet's status.");
    Console.WriteLine("3. Feed your pet.");
    Console.WriteLine("4. Play with your pet.");
    Console.WriteLine("5. Take your pet to the doctor.");
    Console.WriteLine("6. Admit or adopt out a pet.");
    Console.WriteLine("7. List pets in shelter.");
    Console.WriteLine("8. Interact with pets.");
    Console.WriteLine("9. Interact with a particular pet.");

    Console.WriteLine("Press Q to quit");

    var playerChoice = Console.ReadLine().ToLower();

    switch (playerChoice)
    {
        case "1":
            Console.WriteLine("What's the name of your pet?");
            var petName = Console.ReadLine();
            Console.WriteLine("What species is your pet?");
            var petSpecies = Console.ReadLine();
            thisPet.Name = petName;
            thisPet.Species = petSpecies;
            break;
        case "2":
            Console.WriteLine($"\n Name {thisPet.Name} Species {thisPet.Species} Health {thisPet.Health} Hunger {thisPet.Hunger} Boredom {thisPet.Boredom}");
            Console.Write("\nPress enter to return to the Main Menu");
            Console.ReadLine();
            break;
        case "3":
            thisPet.Feed();
                Console.WriteLine($"\n Feeding your pet has changed it's status: Health {thisPet.Health} Hunger {thisPet.Hunger} Boredom {thisPet.Boredom}");
            Console.ReadLine();
            break;
        case "4":
            thisPet.Play();
            Console.WriteLine($"\n Playing with your pet has changed it's status: Health {thisPet.Health} Hunger {thisPet.Hunger} Boredom {thisPet.Boredom}");
            Console.ReadLine();
            break;
        case "5":
            thisPet.SeeDoctor();
            Console.WriteLine($"\n Taking your pet to the doctor has changed it's status: Health {thisPet.Health} Hunger {thisPet.Hunger} Boredom {thisPet.Boredom}");
            Console.ReadLine();
            break;
        case "6":
            Console.WriteLine("What do you want to do? \n A. Admit another pet. \n B. Adopt a pet out. \n");
            var response = Console.ReadLine();
            if (response == "A")

            {
                var newShelterPet = new Pet();
                Console.WriteLine("what is the name?");
                var name = Console.ReadLine();
                Console.WriteLine("What is the species?");
                var species = Console.ReadLine();
                var hunger = 60;
                var health = 60;
                var boredom = 60;
                newShelterPet = new Pet(name, species, hunger, boredom, health);
                
                petShelter.Add(newShelterPet);
                Console.WriteLine($"{name} the {species} has been added");
            }
            else if (response == "B")
            {
                Console.WriteLine("Name of the pet you want to adopt out?");
                var adoptName = Console.ReadLine();
                for (int j = 0; j < petShelter.Count; j++)
                {
                    if(petShelter[j].Name == adoptName)
                    {
                        petShelter.RemoveAt(j);
                        Console.WriteLine("That pet has been adopted out!");
                    }



                }
            }
            Console.Write("\nPress enter to return to the Main Menu");
            Console.ReadLine();

            break;
        case "7":
            Console.WriteLine("Here's a list of the pets in the shelter: ");
            for (int i = 0; i < petShelter.Count; i++)
            {
                

                Console.WriteLine($"\n {petShelter[i].Name} The {petShelter[i].Species} --  Health = {petShelter[i].Health}, Hunger = {petShelter[i].Hunger}, Boredom = {petShelter[i].Boredom}");
               
            }

            Console.Write("\nPress enter to return to the Main Menu");
            Console.ReadLine();

            break;
        case "8":
            //thisPet.SeeDoctor();
            //Console.WriteLine($"\n Taking your pet to the doctor has changed it's status: Health {thisPet.Health} Hunger {thisPet.Hunger} Boredom {thisPet.Boredom}");
            //Console.ReadLine();
            break;
        case "q":
            continueRunning = false;
            Console.WriteLine("Thanks for playing!");
            Console.Beep();
            break;
        default:
            break;

    }

    thisPet.Tick();

} 