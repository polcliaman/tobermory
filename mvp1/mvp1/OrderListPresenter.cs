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
using MVP.OrderList.Model;
using MVP.OrderAddAmend.View;
using MVP.Interfaces;

namespace MVP.OrderList.Presenter

{
    public class OrderListPresenter
    {

        IOrderListView _view;
        IOrderListModel _model;    

        public void SetView(OrderListView view)
        {
            _view = view;
            _view.ViewLoaded += ViewLoaded;
            _view.AddButtonClicked += AddButtonClicked;
            _view.AmendButtonClicked += AmendButtonClicked;
            _view.DeleteButtonClicked += DeleteButtonClicked;

            _model = new OrderListModel();
        }

        protected void ViewLoaded(object sender, EventArgs e)
        {
            _view.Orders = _model.Orders;
            _view.BindData();
        }       

        protected void AddButtonClicked(object sender, EventArgs e)
        {
            //OrderAddAmendView AddAmend = new OrderAddAmendView(_view);
            //using (AddAmend)
            //{
            //    AddAmend.ShowDialog();
            //}                            

        }

        protected void AmendButtonClicked(object sender, EventArgs e)
        {
            //if (_view.OrderToAmend != null)
            //{
            //    OrderAddAmendView AddAmend = new OrderAddAmendView(_view);
            //    using (AddAmend)
            //    {
            //        AddAmend.ShowDialog();
            //    }
            //}

        }

        protected void DeleteButtonClicked(object sender, EventArgs e)
        {
            _view.Orders.Remove(_view.OrderToAmend);
        }

    }
}
