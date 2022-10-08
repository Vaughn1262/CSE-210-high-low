class Deck
{   
    //This class generates a list or deck of cards from 1 to 13
    public Random generator = new Random();

    public List<Card> Cards = new List<Card>();

    public Deck() {
        BuildDeck();
    }
    
    public void BuildDeck(){
        if (Cards.Count != 0) {
            return;
        }
        for (int i = 1; i <= 13; i++) {
            Card card = new Card(i);
            Cards.Add(card);
        }
    }
    public Card DrawCard() {
        
        // This function draws a random card out of the deck for the user
        int randomIndex = generator.Next(Cards.Count);
        Card cardValue = Cards[randomIndex];
        Cards.RemoveAt(randomIndex);
        return cardValue;
        
    }
    
}    
