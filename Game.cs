using System;

namespace RockPaperScissors_Console;

public class Game {
    Player player = new ();
    private int rounds;
    public Game() {
        rounds = 0;
    }

    public void play() {
        Console.WriteLine("In game Play() method");
    }

    public int GetRounds() {
        return rounds;
    }

    public void SetRounds(int rounds) {
        this.rounds = rounds;
    }

    public void addRound() {
        this.rounds += 1;
    }

}
