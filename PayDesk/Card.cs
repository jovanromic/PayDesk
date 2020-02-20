namespace PayDesk
{
    abstract class Card
    {
        protected string ownerName;
        protected string ownerSurname;
        protected int cardNumber;
        protected double turnover;
        protected double discountRate;

        public double Turnover
        {
            get { return turnover; }
            set { turnover = value; }
        }

        public double DiscountRate
        {
            get { return discountRate; }
        }

        public Card()
        {
            turnover = 0;
            discountRate = 0;
        }

        public Card(string name, string surname, int number, double turnover, double discount)
        {
            ownerName = name;
            ownerSurname = surname;
            cardNumber = number;
            this.turnover = turnover;
            discountRate = discount;
        }

        public abstract void CalculateDiscountRate();
    }
}
