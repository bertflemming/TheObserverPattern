using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTradingSystem
{
    public class PortfolioDisplay : IObserver, IDisplay
    {
        public void Update(Subject subject)
        {
            Portfolio portfolio = (Portfolio)subject;
          
        }

        public void Display()
        {

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
