using System;

namespace PayDesk
{
    class PayDesk
    {
        public static void MakePayment(Card card, double purchaseValue)
        {
            card.CalculateDiscountRate();
            double discount = purchaseValue * card.DiscountRate;
            double totalValue = purchaseValue - discount;
            card.Turnover += totalValue;

            Console.WriteLine("Purchase value: ${0}", purchaseValue);
            Console.WriteLine("Discount rate: {0}%", card.DiscountRate * 100);
            Console.WriteLine("Discount: ${0}", discount);
            Console.WriteLine("Total: ${0}\n", totalValue);
        }
    }
}
