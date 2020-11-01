using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_ERP
{
    class InventoryEditPermission
    {
        public Int32 prodID ;
        public Int32 count;
        public String prodNam;
        public String prodType;
        public String date;
        public double buyPrice;

        public InventoryEditPermission(int prodID, int count, String prodtype, String prodName, String date,double buyPrice)
        {

            this.prodID = prodID;
            this.count = count;
            this.prodNam = prodName;
            this.prodType = prodtype;
            this.date = date;
            this.buyPrice = buyPrice;
        }
    }
}
