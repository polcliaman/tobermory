using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVP.OrderList.View;
using mvp1;

namespace MVP.OrderList.Model
{
    public class OrderListModel
    {
        public IEnumerable<Order> GetOrders()
        {

            List<Order> OrderList = new List<Order>();

            Order Order1 = new Order() { OrderRef = "1", CustName = "John", ItemDesc = "Mallet", Qty = 3, UnitCost = 3.43 };
            Order Order2 = new Order() { OrderRef = "2", CustName = "Fred", ItemDesc = "Toupee", Qty = 2, UnitCost = 45.21 };
            Order Order3 = new Order() { OrderRef = "3", CustName = "Sue", ItemDesc = "Foal", Qty = 10, UnitCost = 1200.65 };
            
            OrderList.Add(Order1);
            OrderList.Add(Order2);
            OrderList.Add(Order3);
                         
            return(OrderList);
        }

    }
}
