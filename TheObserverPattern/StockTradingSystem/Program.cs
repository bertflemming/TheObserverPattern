using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTradingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Portfolio portfolio1 = new Portfolio();
            Portfolio portfolio2 = new Portfolio();

            PortfolioDisplay portfolioDisplay1 = new PortfolioDisplay();
            portfolioDisplay1.AddPortfolio(portfolio1);
            Stock google = new Stock("google");
            Stock facebook = new Stock("facebook");

            google.SetStockValue(500);

            portfolio1.AddStock(google, 3);

            Console.WriteLine("{0}", portfolio1.CalcTotalStockValue());

            portfolio2.AddStock(google, 5);

            google.SetStockValue(300);

            portfolio2.RemoveStock(google,4);
            portfolio2.RemoveStock(google, 1);

            Console.WriteLine("{0}",portfolio1.CalcTotalStockValue());
            


            //while (true)
            //{
            //    System.Threading.Thread.Sleep(4000);

            //    portfolioDisplay1.DisplayPortfolio(portfolio1);
            //}
        }
    }
}
