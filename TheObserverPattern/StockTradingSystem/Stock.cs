using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTradingSystem
{
    public class Stock : Subject
    {
        public Stock(string name)
        {
            StockName = name;
            StockAmount = 0;
        }
        public void SetStockValue(double stockValue)
        {
            StockValue = stockValue;
            Notify(this);
        }
        public double StockValue { get; set; }
        public string StockName { get; private set; }
        public int StockAmount { get; set; }
    }
}
