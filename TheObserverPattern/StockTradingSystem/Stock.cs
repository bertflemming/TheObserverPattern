using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTradingSystem
{
    public class Stock : Subject
    {
        public void StockChanged()
        { }
        
        public double StockValue { get; set; }
        public string StockName { get; set; }
    }
}
