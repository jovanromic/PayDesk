namespace PayDesk
{
    class Program
    {
        static void Main(string[] args)
        {
            Card bronze, silver, gold;
            bronze = new BronzeCard("Mickey", "Pierce", 1234, 0);
            silver = new SilverCard("Chandler", "Bing", 2345, 600);
            gold = new GoldCard("Marge", "Simpson", 3456, 1500);

            PayDesk.MakePayment(bronze, 150);
            PayDesk.MakePayment(silver, 850);
            PayDesk.MakePayment(gold, 1300);
        }
    }
}
