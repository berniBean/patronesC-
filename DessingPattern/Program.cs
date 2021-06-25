using DessingPattern.FactoryPattern;
using System;

namespace DessingPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesFactory storeSaleFactory = new StoreSaleFactory(10);
            SalesFactory internetSaleFactory = new InternetSaleFactory(2);

            ISale sale1 = storeSaleFactory.GetSale();
            sale1.Sell(15);

            ISale sale2 = internetSaleFactory.GetSale();
            sale2.Sell(15);
        }
    }
}
