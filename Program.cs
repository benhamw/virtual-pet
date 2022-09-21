
using System.Runtime.InteropServices;
using template_csharp_virtual_pet;

Pet thisPet;
thisPet = new Pet();
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
            break;
        case "4":
            break;
        case "5":
            break;
        case "q":
            continueRunning = false;
            Console.WriteLine("Thanks for playing!");
            Console.Beep();
            break;
        default:
            break;

    }

} 