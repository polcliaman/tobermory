using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVP.OrderList.Presenter;
using MVP.OrderList.Model;
using MVP.Interfaces;

namespace MVP.OrderList.View
{
    static class main

        {
            static void Main()
            {            
                Application.Run(new OrderListView());
            }
        }
}
