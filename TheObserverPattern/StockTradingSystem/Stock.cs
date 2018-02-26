using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StockTradingSystem
{
    public class Stock : Subject
    {

        public Stock(string name)
        {
            StockName = name;
            Thread stockThread = new Thread(UpdateStockValue);
            stockThread.Start();
        }
        public void SetStockValue(double stockValue)
        {
            StockValue = stockValue;
            Notify(this);
        }

        public void UpdateStockValue()
        {
            while (true)
            {
                Random rand1 = new Random();
                int randpercent = rand1.Next(95, 105);

                SetStockValue(StockValue*(double)randpercent/100);

                Thread.Sleep(3000);
            }

        }
        public double StockValue { get; private set; }
        public string StockName { get; private set; }
    }
}
