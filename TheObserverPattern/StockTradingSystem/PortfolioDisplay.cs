using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTradingSystem
{
    public class PortfolioDisplay : IObserver, IDisplay
    {
        public void Update(Subject subject) // Display kaldes når der sker ændringer
        {
            Stock _subject = (Stock)subject;
            Display(_subject);
        }
        public void Display(Stock stock) // Udskriver info om stock
        {
                Console.WriteLine("Stock Name: {0}", stock.StockName);
                Console.WriteLine("Stock Value: {0}", stock.StockValue);
        }

        public void DisplayPortfolio(Portfolio portfolio) // Udskriver alle stocks i portfolio
        {
            foreach (Portfolio.Pstock s in portfolio._stocks)
            {
                Console.WriteLine("Stock Name: {0}", s.stock_.StockName);
                Console.WriteLine("Stock Value: {0}", s.stock_.StockValue);
                Console.WriteLine("Stock Amount: {0}", s.stockAmount_);
            }
        }

        public void AddPortfolio(Portfolio portfolio)
        {
            portfolio.Attach(this);
        }

        public void RemovePortfolio(Portfolio portfolio)
        {
            portfolio.Detach(this);
        }
    }
}
