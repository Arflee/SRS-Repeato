namespace SRS_Repeato.Core
{
    public class Deck
    {
        private List<Card> cards;

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public bool RemoveCard(Card card)
        {
            return cards.Remove(card);
        }

        public IEnumerable<Card> GetCard(string content)
        {
            yield return cards.First();
        }

        public IEnumerable<Card> GetNextRepetion(DateTime currentTime)
        {
            yield return cards.First();
        }
    }
}
