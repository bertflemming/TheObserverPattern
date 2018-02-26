using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTradingSystem
{
    public class Portfolio : Subject, IObserver
    {
        private List<Stock> _stocks;
        public Portfolio()
        {
            _stocks = new List<Stock>();
        }
        public void Update(Subject subject)
        {
            Stock stock = (Stock) subject;
            _stocks[_stocks.IndexOf(stock)].StockValue = stock.StockValue;
            Notify(this);
        }

        public void AddStock(Stock stock, int stockAmount)
        {
            stock.StockAmount = stockAmount;
            _stocks.Add(stock);

           stock.Attach(this);
        }

        public void RemoveStock(Stock stock, int stockAmount)
        {
            stock.StockAmount -= stockAmount;
            if (stock.StockAmount <= 0)
            {
                _stocks.Remove(stock);
                stock.Detach(this);
            }
        }
    }
}
