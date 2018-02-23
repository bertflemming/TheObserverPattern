using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTradingSystem
{
    public class Portfolio : Subject, IObserver
    {
        Stock myStock = new Stock();
        private double _stockAmount;
        public void Update(double stockValue, string stockName, int stockAmount)
        {
            myStock.StockValue = stockValue;
            myStock.StockName = stockName;

            
        }

        public void PortfolioChanged()
        { }



        public int StockAmount { get; set; }
    }
}
