using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTradingSystem
{

    public class Portfolio : Subject, IObserver
    {
        public class Pstock
        {
            public Stock stock_ { get; set; }
            public int stockAmount_ { get; set; }

            public Pstock(Stock stock, int stockAmount)
            {
                stock_ = stock;
                stockAmount_ = stockAmount;
            }
        }

        public List<Pstock> _stocks;
        private double _totalValue { get; set; }

        public Portfolio()
        {
            _stocks = new List<Pstock>();
        }
        public void Update(Subject subject)
        {
            Notify(subject);
        }

        public void AddStock(Stock stock, int stockAmount)
        {
            Pstock newStock = new Pstock(stock, stockAmount);

            _stocks.Add(newStock);

            stock.Attach(this);
        }

        public void RemoveStock(Stock stock, int stockAmount)
        {
            for (int i = 0; i < _stocks.Count; i++)
            {
                if (_stocks[i].stock_.StockName == stock.StockName)
                {
                    _stocks[i].stockAmount_ -= stockAmount;
                    if (_stocks[i].stockAmount_ <= 0)
                    {
                        _stocks.Remove(_stocks[i]);
                        stock.Detach(this);
                    }
                }
            }
        }

        public double CalcTotalStockValue()
        {
            double sum = 0;
            foreach (Pstock ps in _stocks)
            {
                sum += ps.stockAmount_ * ps.stock_.StockValue;
            }

            _totalValue = sum;
            return _totalValue;
        }
    }
}
