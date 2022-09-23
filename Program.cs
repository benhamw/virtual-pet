
using System.Runtime.InteropServices;
using template_csharp_virtual_pet;

Console.BackgroundColor = ConsoleColor.Cyan;
Console.ForegroundColor = ConsoleColor.Black;

Pet currentPet = new RoboticPet();
Pet activePet; 
OrganicPet pet1 = new OrganicPet("Fido", "dog", 60, 60, 60);
OrganicPet pet2= new OrganicPet("Fluffy", "cat", 60, 60, 60);
OrganicPet pet3= new OrganicPet("Lucky", "gold fish", 60, 60, 60);
OrganicPet pet4 = new OrganicPet("Polly", "parrot", 60, 60, 60);
OrganicPet pet5 = new OrganicPet("Ray", "Gecko", 60, 60, 60);

RoboticPet pet6 = new RoboticPet("Rex", "dog", 60, 60);
RoboticPet pet7 = new RoboticPet("Lola", "cat", 60, 60);

List<Pet> petShelter = new List<Pet>() { pet1, pet2, pet3, pet4, pet5, pet6, pet7};

bool continueRunning = true;
bool petNotCreated = true;
while(petNotCreated)
{
    var speciesOrType = "";
    Console.Clear();
    Console.WriteLine("Welcome to Virtual Pet!\n");
    Console.WriteLine("Let's create a pet to start you off.\nWould you like:\nA. An organic pet\nB. A robotic pet");
    var petChoice = Console.ReadLine().ToLower();
    if(petChoice == "a")
    {
        OrganicPet oPet = new OrganicPet();
        Console.WriteLine("What's the name of your pet?");
        var petName = Console.ReadLine();
        Console.WriteLine("What species is your pet?");
        var petSpecies = Console.ReadLine();
        oPet.Name = petName;
        oPet.Species = petSpecies;
        speciesOrType = "organic";
        currentPet = oPet;
    }
    else if(petChoice == "b")
    {
        RoboticPet rPet = new RoboticPet();
        Console.WriteLine("What's the name of your pet?");
        var petName = Console.ReadLine();
        Console.WriteLine("What's the type of your pet?");
        var petType = Console.ReadLine();
        rPet.Name = petName;
        rPet.Type = petType;
        speciesOrType = "robotic";
        currentPet = rPet;
    }
    else
    {
        Console.WriteLine("Please select a valid type.\n");
        continue;
    }
    petNotCreated = false;
    Console.WriteLine("Congratulations! You have a new " + speciesOrType + " pet:");
    currentPet.DisplayPet();
    Console.WriteLine("\nPress any key to go to the menu.");
    Console.ReadKey();
}

while (continueRunning)
{
    Console.Clear();
    Console.WriteLine("Welcome to Virtual Pet!\n");
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. See your pet's status.");
    Console.WriteLine("2. Feed your pet.");
    Console.WriteLine("3. Play with your pet.");
    Console.WriteLine("4. Take your pet to the doctor.");
    Console.WriteLine("5. Admit an organic pet to the shelter or adopt an organic pet out.");
    Console.WriteLine("6. Admit a robotic pet to the shelter or adopt a robotic pet out.");
    Console.WriteLine("7. List pets in the shelter.");
    Console.WriteLine("8. Interact with all pets in the shelter.");
    Console.WriteLine("9. Interact with a particular shelter pet.");

    Console.WriteLine("Press Q to quit");

    var playerChoice = Console.ReadLine().ToLower();
    switch (playerChoice)
    {
        case "1":
            // Display pet info
            currentPet.DisplayPet();
            Console.Write("\nPress enter to return to the Main Menu");
            Console.ReadLine();
            break;
        case "2":
            //Feed your pet
            currentPet.Feed();
            Console.WriteLine($"\n Feeding your pet has changed it's status: Health {currentPet.Health} Hunger {currentPet.Hunger} Boredom {currentPet.Boredom}");
            Console.ReadLine();
            break;
        case "3":
            // Play with your pet
            currentPet.Play();
            Console.WriteLine($"\n Playing with your pet has changed it's status: Health {currentPet.Health} Hunger {currentPet.Hunger} Boredom {currentPet.Boredom}");
            Console.ReadLine();
            break;
        case "4":
            // Take pet to the doctor
            currentPet.SeeDoctor();
            Console.WriteLine($"\n Taking your pet to the doctor has changed it's status: Health {currentPet.Health} Hunger {currentPet.Hunger} Boredom {currentPet.Boredom}");
            Console.ReadLine();
            break;
        case "5":
            // Add an organic pet to the shelter or adopt an organic pet out
            Console.WriteLine("What do you want to do? \n A. Admit another organic pet to the shelter. \n B. Adopt an organic pet out of the shelter. \n");
            var response = Console.ReadLine().ToLower();
            if (response == "a")
            {
                var newShelterPet = new OrganicPet();
                Console.WriteLine("What is the organic pet's name?");
                var name = Console.ReadLine();
                Console.WriteLine("What is the organic pet's species?");
                var species = Console.ReadLine();
                var hunger = 60;
                var health = 60;
                var boredom = 60;
                newShelterPet = new OrganicPet(name, species, hunger, boredom, health);
                
                petShelter.Add(newShelterPet);
                Console.WriteLine($"\n{name} the {species} has been added");
            }
            else if (response == "b")
            {
                Console.WriteLine("Name of the organic pet you want to adopt out?");
                var adoptName = Console.ReadLine();
                for (int j = 0; j < petShelter.Count; j++)
                {
                    if(petShelter[j].Name == adoptName)
                    {
                        petShelter.RemoveAt(j);
                        Console.WriteLine($"{adoptName} has been adopted out!");
                    }
                }
            }
            break;
        case "6":
            // Add a robotic pet to the shelter or adopt a robotic pet out
            Console.WriteLine("What do you want to do? \n A. Admit another robotic pet to the shelter. \n B. Adopt a robotic pet out of the shelter. \n");
            var response1 = Console.ReadLine().ToLower();
            if (response1 == "a")
            {
                var newShelterPet = new RoboticPet();
                Console.WriteLine("What is the robotic pet's name?");
                var name = Console.ReadLine();
                Console.WriteLine("What is the robotic pet's species?");
                var type = Console.ReadLine();
                var charge = 60;
                var maintenance = 60;
                newShelterPet = new RoboticPet(name, type, charge, maintenance);

                petShelter.Add(newShelterPet);
                Console.WriteLine($"\n{name} the {type} has been added");
            }
            else if (response1 == "b")
            {
                Console.WriteLine("Name of the robotic pet you want to adopt out?");
                var adoptName = Console.ReadLine();
                for (int k = 0; k < petShelter.Count; k++)
                {
                    if (petShelter[k].Name == adoptName)
                    {
                        petShelter.RemoveAt(k);
                        Console.WriteLine($"\n{adoptName} has been adopted out!\n");
                    }
                }
            }

            Console.Write("\nPress enter to return to the Main Menu");
            Console.ReadLine();
            break;
        case "7":
            // List pets in the shelter
            Console.WriteLine("\nHere's a list of the pets in the shelter:\n");
            for (int i = 0; i < petShelter.Count; i++)
            {
               // activePet = new OrganicPet(petShelter[i].Name, petShelter[i].Species, petShelter[i].Hunger, petShelter[i].Boredom, petShelter[i].Health);
               activePet = petShelter[i];
               activePet.DisplayPet();
            }  

            Console.Write("\nPress enter to return to the Main Menu");
            Console.ReadLine();
            break;
        case "8":
            // Interact with all pets
            Console.WriteLine("How would you like to interact with all pet in the shelter?\nF. Feed\nP. Play\nD. See Doctor");
            var interactOptionAll = Console.ReadLine().ToLower();
            for (int l = 0; l < petShelter.Count; l++)
            {
                activePet = petShelter[l];
                if (interactOptionAll == "f")
                {
                    activePet.Feed();
                    petShelter[l] = activePet;
                }
                else if (interactOptionAll == "p")
                {
                    activePet.Play();
                    petShelter[l] = activePet;
                }
                else if (interactOptionAll == "d")
                {
                    activePet.SeeDoctor();
                    petShelter[l] = activePet;
                }
                activePet.DisplayPet();
            }
            var action = "";
            if(interactOptionAll == "f")
            {
                action = "fed";
            }
            else if(interactOptionAll == "p") 
            {
                action = "played with";
            }
            else if(interactOptionAll=="d")
            {
                action = "took to the doctor";
            }
               
            Console.WriteLine("\nYou " + action + " all the pets.");
            Console.Write("\nPress enter to return to the Main Menu");
            Console.ReadLine();
            break;
        case "9":
            // Interact with a particular pet
            Console.WriteLine("Name of the pet you want to interact with?");
            var interactName = Console.ReadLine();
            for (int k = 0; k < petShelter.Count; k++)
            {
                if (petShelter[k].Name == interactName)
                {
                    activePet = petShelter[k];
                    Console.WriteLine($"{activePet.Name} is in the Shelter.\n");
                    Console.WriteLine("How would you like to interact with this pet?\nF. Feed\nP. Play\nD. See Doctor");
                    var interactOption = Console.ReadLine().ToLower();
                    if (interactOption == "f")
                    {
                        activePet.Feed();
                        petShelter[k] = activePet;
                        Console.WriteLine($"You fed {petShelter[k].Name}. Well done!");
                    }
                    else if (interactOption == "p") 
                    {
                        activePet.Play();
                        petShelter[k] = activePet;
                        Console.WriteLine($"You played with {petShelter[k].Name}.");
                    }
                    else if (interactOption == "d")
                    {
                        activePet.SeeDoctor();
                        petShelter[k] = activePet;
                        Console.WriteLine($"{petShelter[k].Name} is extra healthy after seeing the doctor!");
                    }
                }
            }

            Console.Write("\nPress enter to return to the Main Menu");
            Console.ReadLine();
            break;
        case "q":
            // Quit the app
            continueRunning = false;
            Console.WriteLine("Thanks for playing!");
            Console.Beep();
            break;
        default:
            break;

    }

    currentPet.Tick();

}