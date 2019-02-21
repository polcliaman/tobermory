using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvp1
{
    public class Order
    {

        public string OrderRef { get; set; }
        public string CustName { get; set; }
        public string ItemDesc { get; set; }
        public int    Qty      { get; set; }
        public double UnitCost { get; set; }

        public override string ToString()
        {
            return String.Format("Order Ref: {0} : Customer: {1} : Item {2} : Qty {3} : Unit Cost {4}", 
                                 this.OrderRef, this.CustName, this.ItemDesc, this.Qty, this.UnitCost);
        }

    }
}
