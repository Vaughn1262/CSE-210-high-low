class Deck
{
    Random generator = new Random();

    public List<Card> Cards = new List<Card>();

    public Deck() {
        BuildDeck();
    }
    
    void BuildDeck(){
        if (Cards.Count != 0) {
            return;
        }
        for (int i = 1; i <= 13; i++) {
            Card card = new Card(i);
            Cards.Add(card);
        }
    }
    public Card DrawCard() {
        int randomIndex = generator.Next(14);
        Card cardValue = Cards[randomIndex];
        Cards.RemoveAt(randomIndex);
        return cardValue;
        
    }
    
}    
