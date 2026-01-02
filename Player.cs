using System;

namespace RockPaperScissors_Console;

public class Player {

    private string name;
    private string choice;

    public string GetName() {
        return name;
    }

    public void SetName(string name) {
        this.name = name;
    }

    public string GetChoice() {
        return choice;
    }

    public void SetChoice(string choice) {
        this.choice = choice;
    }

}
