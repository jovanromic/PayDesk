namespace PayDesk
{
    class GoldCard: Card
    {
        public GoldCard(string name, string surname, int number, int turnover)
            : base(name, surname, number, turnover, 0.02)
        {

        }

        public override void CalculateDiscountRate()
        {
            if (turnover > 100)
            {
                int percentage = (int)turnover / 100;
                if (percentage < 10)
                    discountRate = percentage / 100;
                else discountRate = 0.1;
            }
            else discountRate = 0.02;
        }
    }
}
