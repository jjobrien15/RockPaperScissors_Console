
using RockPaperScissors_Console;

bool running = true;

Game game = new();
Player player = new();

Console.WriteLine("Welcome to RPS!");
Console.Write("Enter your name: ");
player.SetName(Console.ReadLine());

void menu() {

    Console.WriteLine($"\nChoose an option, {player.GetName()}:");
    Console.WriteLine("1: Play Rock Paper Scissors");
    Console.WriteLine("2: Show score");
    Console.WriteLine("3: Erase score");
    Console.WriteLine("Q: Quit\n");

    string? menuChoice = Console.ReadLine();

    switch (menuChoice) {
        case "1":
            game.play(player);
            break;
        case "2":
            Console.WriteLine("Case 2: Show Score");
            break;
        case "3":
            Console.WriteLine("Case 3: Erase Score");
            break;
        case "q":
        case "Q":
        case "quit":
        case "Quit":
            Console.WriteLine($"\nThanks for playing RPS, {player.GetName()}!");
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
