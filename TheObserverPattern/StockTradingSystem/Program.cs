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

            Stock google = new Stock("google");
            Stock facebook = new Stock("facebook");


            portfolio1.AddStock(google, 3);
            portfolioDisplay1.Display(portfolio1);

            portfolio2.AddStock(google, 5);
            portfolioDisplay1.Display(portfolio2);

            portfolioDisplay1.Display(portfolio1);

            portfolio2.RemoveStock(google,4);
            portfolioDisplay1.Display(portfolio2);
            portfolio2.RemoveStock(google, 1);
            portfolioDisplay1.Display(portfolio2);
        }
    }
}
