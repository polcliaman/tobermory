using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mvp1;

namespace MVP.Interfaces
{
    public interface IOrderListModel
    {
        List<Order> Orders { get; set; }
        Order OrderToAmend { get; set; }
    }
}
