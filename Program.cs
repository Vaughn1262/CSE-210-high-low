// See https://aka.ms/new-console-template for more information
// This sets the users initial score to 300.
Score totalScore = new Score(300);

// This creates a deck object in the program
Deck deck1 = new Deck();

//This while loop keeps the game going if the user says y
while (keepPlaying()){

    // These 2 lines draw 2 random cards from the deck
    Card card1 = deck1.DrawCard();
    Card card2 = deck1.DrawCard();

    // These lines tell the user what the card is and asks for their guess
    Console.WriteLine($"The card is {card1.value}");
    Console.WriteLine("Higher or Lower (h/l)?");
    string guess = Console.ReadLine()??"";

    // This sets the score for the turn equal to 0
    Score turnScore = new Score(0);

    // These statements determine if the user was correct and assigns points
    if (card2.value > card1.value && guess == "h")
    {
        turnScore.value = 100;
    }
    else if (card2.value < card1.value && guess == "l"){
        turnScore.value = 100;
    }
    else
    {
       turnScore.value = -75; 
    }

    // These lines tell the user the second card then calculates the total score and displays it.
    Console.WriteLine($"The card was {card2.value}");
    totalScore.value += turnScore.value;
    Console.WriteLine(totalScore.value);
    
}

// This line is an exit message for when the game is over.
Console.WriteLine("Thanks for playing");


bool keepPlaying()
{   
    // This function determines if the user wants to keep playing and continue the while loop
    Console.WriteLine("Do you want to keep playing? (y/n)");
    string choice = Console.ReadLine()??"";
    if (choice == "n"){
        return false;
    } 
    else {
        return true;
    }

}
