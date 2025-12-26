
bool running = true;

Console.WriteLine("Welcome to RPS!");

void menu() {

    string choice;

    Console.WriteLine("\nChoose an option:");
    Console.WriteLine("1: Test case one");
    Console.WriteLine("Q: Quit");


    choice = Console.ReadLine();

    switch (choice) {
        case "1":
            Console.WriteLine("Within case 1");
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
