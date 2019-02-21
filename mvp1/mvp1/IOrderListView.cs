using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mvp1;

namespace MVP.Interfaces
{
    public interface IOrderListView
    {

        event EventHandler ViewLoaded;
        event EventHandler AddButtonClicked;
        event EventHandler AmendButtonClicked;
        event EventHandler DeleteButtonClicked;

        List<Order> Orders { get; set; }
        Order OrderToAmend { get; set; }

        void BindData();
        void Show();
    }
}
