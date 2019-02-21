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
using MVP.OrderList.Presenter;
using MVP.OrderList.Model;
using mvp1;
using MVP.Interfaces;

namespace MVP.OrderList.View
{

    public partial class OrderListView : Form, IOrderListView
    {

        //Interface Implementation

        public List<Order> Orders { get; set; }
        public Order OrderToAmend { get; set; }

        public event EventHandler ViewLoaded;
        public event EventHandler AddButtonClicked;
        public event EventHandler AmendButtonClicked;
        public event EventHandler DeleteButtonClicked;

        public void BindData()
        {
            _bsOrders.DataSource = Orders;
            listBox1.DataSource = _bsOrders;
        }

        //Constructor      

        public OrderListView()
        {
            InitializeComponent();
            OrderListPresenter PresenterLayer = new OrderListPresenter();
            PresenterLayer.SetView(this);
        }

        //Local Variables

        private BindingSource _bsOrders = new BindingSource();

        //Local Methods

        private void HomeView_Load(object sender, EventArgs e)
        {
           ViewLoaded?.Invoke(this, new EventArgs());
        }



        private void AmendButton_Click(object sender, EventArgs e)
        {
            OrderToAmend = (Order)(listBox1.SelectedItem);                        
            AmendButtonClicked?.Invoke(this, EventArgs.Empty);
            _bsOrders.ResetBindings(false);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddButtonClicked?.Invoke(this, EventArgs.Empty);
            _bsOrders.ResetBindings(false);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            OrderToAmend = (Order)(listBox1.SelectedItem);
            DeleteButtonClicked?.Invoke(this, EventArgs.Empty);
            _bsOrders.ResetBindings(false);
        }
    }
}