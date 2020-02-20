namespace PayDesk
{
    class SilverCard:Card
    {
        public SilverCard(string name, string surname, int number, int turnover)
            :base(name,surname,number,turnover,0.02)
        {

        }

        public override void CalculateDiscountRate()
        {
            if (turnover > 300)
                discountRate = 0.035;
        }
    }
}
