namespace PayDesk
{
    class BronzeCard: Card
    {
        public BronzeCard(string name, string surname, int number, int turnover)
            : base(name, surname, number, turnover,0)
        {
            
        }

        public override void CalculateDiscountRate()
        {
            if (turnover > 100 && turnover < 300)
                discountRate = 0.01;
            else if(turnover >= 300)
                discountRate = 0.025;

        }
    }
}
