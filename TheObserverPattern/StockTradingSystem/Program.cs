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

            Stock google = new Stock("google");
            Stock facebook = new Stock("facebook");

            portfolio1.AddStock(google, 3);
            

        }
    }
}
