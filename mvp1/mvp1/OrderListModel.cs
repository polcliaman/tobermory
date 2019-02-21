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
using MVP.Interfaces;

namespace MVP.OrderList.Model
{
    public class OrderListModel : IOrderListModel
    {

        //Interface Implementation

        public List<Order> Orders
        {
            get  { GetOrders();
                   return orders;}
            set  { }
        }
        public Order OrderToAmend { get; set; }

        //Methods

        private List<Order> orders = new List<Order>();

        public void GetOrders()
        {            
            Order Order1 = new Order() { OrderRef = "1", CustName = "John", ItemDesc = "Mallet", Qty = 3, UnitCost = 3.43 };
            Order Order2 = new Order() { OrderRef = "2", CustName = "Fred", ItemDesc = "Toupee", Qty = 2, UnitCost = 45.21 };
            Order Order3 = new Order() { OrderRef = "3", CustName = "Sue", ItemDesc = "Foal", Qty = 10, UnitCost = 1200.65 };

            orders.Add(Order1);
            orders.Add(Order2);
            orders.Add(Order3);
        }

    }
}
