using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_ERP
{
    class StockItem
    {
        private int count;
        private double buyPrice;

        public StockItem(int count, double buyPrice)
        {
            this.count = count;
            this.buyPrice = buyPrice;
        }

        public void setCount(int count)
        {
            this.count = count;
        }

        public void setBuyPrice(double buyPrice)
        {
            this.buyPrice = buyPrice;
        }

        public int getCount()
        {
            return count;
        }

        public double getBuyPrice()
        {
            return buyPrice;
        }
    }
}
