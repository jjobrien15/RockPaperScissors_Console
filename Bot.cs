using System;

namespace RockPaperScissors_Console;

public class Bot {

    private string botChoice;

    public string GetChoice() {
        return botChoice;
    }
    public void SetChoice(string[] choices) {

        //Use random num generator to decide for bot
        //Can produce 1,2 or 3
        Random randChoice = new Random();
        int selection = randChoice.Next(1, choices.Length);

        //Setting bot choice
        this.botChoice = choices[selection];
    }

}
