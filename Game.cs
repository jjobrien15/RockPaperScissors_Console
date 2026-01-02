using System;

namespace RockPaperScissors_Console;

public class Game {
    Bot bot = new();
    //Create array of string choices for bot to pick
    string[] choices = { "Rock", "Paper", "Scissors" };
    private int rounds;
    public Game() {
        rounds = 0;
    }

    public void play(Player player) {
        //Add logic to quit play method

        bool playing = true;

        do {
            Console.WriteLine("Select an option: (Rock, Paper, Scissors)");
            player.SetChoice(Console.ReadLine());
            bot.SetChoice(choices);

            if (choices.Any(choice => choice == player.GetChoice())) {

                Console.WriteLine($"\nPlayer choice: {player.GetChoice()}");
                Console.WriteLine($"Bot choice: {bot.GetChoice()}\n");

                GetWinner(player.GetName(), player.GetChoice().ToUpper(), bot.GetChoice().ToUpper());
            }
            else {
                Console.WriteLine("Invalid choice...");
            }
        } while (playing);

    }

    public int GetRounds() {
        return rounds;
    }

    public void SetRounds(int rounds) {
        this.rounds = rounds;
    }

    public void AddRound() {
        this.rounds += 1;
    }

    private void GetWinner(string playerName, string playerChoice, string botChoice) {

        if (playerChoice == "ROCK" && botChoice == "SCISSORS" ||
            playerChoice == "PAPER" && botChoice == "ROCK" ||
            playerChoice == "SCISSORS" && botChoice == "PAPER") {

            Console.WriteLine($"{playerName} wins!");

        }
        else if (playerChoice == botChoice) {

            Console.WriteLine($"It's a tie!");

        }
        else {

            Console.WriteLine($"{playerName} lost!");

        }
    }

}
