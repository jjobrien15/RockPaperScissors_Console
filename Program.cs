
using RockPaperScissors_Console;

bool running = true;

Game game = new();

Console.WriteLine("Welcome to RPS!");

void menu() {

    string choice;

    Console.WriteLine("\nChoose an option:");
    Console.WriteLine("1: Play Rock Paper Scissors");
    Console.WriteLine("2: Show score");
    Console.WriteLine("3: Erase score");
    Console.WriteLine("Q: Quit");


    choice = Console.ReadLine();

    switch (choice) {
        case "1":
            game.play();
            break;
        case "2":
            Console.WriteLine("Show Score");
            break;
        case "3":
            Console.WriteLine("Erase Score");
            break;
        case "q":
        case "Q":
        case "quit":
        case "Quit":
            Console.WriteLine("\nThanks for playing RPS!");
            running = false;
            break;
        default:
            Console.WriteLine("Invalid input...");
            break;
    }

}

do {

    menu();

} while (running);
