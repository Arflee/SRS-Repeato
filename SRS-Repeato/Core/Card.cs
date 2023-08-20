namespace SRS_Repeato.Core
{
    public class Card
    {
        private string content;
        private DateTime lastRepetition;
        private DateTime nextRepetition;

        public DateTime NextRepetition { get => nextRepetition; set => nextRepetition = value; }
    }
}