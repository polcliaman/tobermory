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
using mvp1;

namespace MVP.OrderAddAmend.Presenter
{
    class OrderAddAmendPresenter
    {
        private OrderListView _viewOrderList;
        private OrderAddAmendView _viewAddAmend;

        public string _OrderRef;
        public string _ItemDesc;
        public string _Customer;
        public int _Qty;
        public double _UnitCost;

        public void SetView(OrderAddAmendView viewAddAmend, OrderListView viewOrderList)
        {
            _viewOrderList = viewOrderList;
            _viewAddAmend = viewAddAmend;
            _viewAddAmend.ViewLoaded += ViewLoaded;
            _viewAddAmend.CloseButtonClicked += CloseButtonClicked;
            _viewAddAmend.SaveButtonClicked += SaveButtonClicked;

        }

        protected void ViewLoaded(object sender, EventArgs e)
        {
                //_OrderRef = _viewOrderList.objToAmend.OrderRef;
                //_ItemDesc = _viewOrderList.objToAmend.ItemDesc;
                //_Customer = _viewOrderList.objToAmend.CustName;
                //_Qty = _viewOrderList.objToAmend.Qty;
                //_UnitCost = _viewOrderList.objToAmend.UnitCost;
            
        }

        protected void CloseButtonClicked(object sender, EventArgs e)
        {
            _viewAddAmend.Close();

        }

        protected void SaveButtonClicked(object sender, EventArgs e)
        {
            
            //if (_viewOrderList.OrderAmend)
            //{
            //    _viewOrderList.objToAmend.ItemDesc = _ItemDesc;
            //    _viewOrderList.objToAmend.UnitCost = _UnitCost;
            //    _viewOrderList.objToAmend.Qty = _Qty;
            //    _viewOrderList.objToAmend.OrderRef = _OrderRef;
            //    _viewOrderList.objToAmend.CustName = _Customer;
            //}
            //else
            //{
            //    Order newOrder = new Order();

            //    newOrder.ItemDesc = _ItemDesc;
            //    newOrder.UnitCost = (_UnitCost);
            //    newOrder.Qty = _Qty;
            //    newOrder.OrderRef = _OrderRef;
            //    newOrder.CustName = _Customer;

            //    _viewOrderList.Orders.Add(newOrder);

            //}
           
            _viewAddAmend.Close();

        }


    }
}
