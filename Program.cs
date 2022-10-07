// See https://aka.ms/new-console-template for more information
Score totalScore = new Score(300);
while (keepPlaying()){
    
    Deck deck1 = new Deck();
    Card card1 = deck1.Cards[0];
    Card card2 = deck1.Cards[1];
    Console.WriteLine($"The card is {card1.number}");
    Console.WriteLine("Higher or Lower (h/l)?");
    string guess = Console.ReadLine()??"";
    Score turnScore = new Score(0);
    if (card2.number > card1.number && guess == "h")
    {
        turnScore.value = 100;
    }
    else if (card2.number < card1.number && guess == "l"){
        turnScore.value = 100;
    }
    else
    {
       turnScore.value = -75; 
    }
    Console.WriteLine($"The card was {card2.number}");
    totalScore.value += turnScore.value;
    Console.WriteLine(totalScore.value);
    
}
Console.WriteLine("Thanks for playing");
bool keepPlaying()
{
    Console.WriteLine("Do you want to keep playing? (y/n)");
    string choice = Console.ReadLine()??"";
    if (choice == "n"){
        return false;
    } 
    else {
        return true;
    }

}
