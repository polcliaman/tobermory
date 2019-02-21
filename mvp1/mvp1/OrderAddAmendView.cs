using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVP.OrderList.View;
using MVP.OrderList.Presenter;
using MVP.OrderAddAmend.Presenter;
using mvp1;

namespace MVP.OrderAddAmend.View
{
    public partial class OrderAddAmendView : Form
    {

        public event EventHandler ViewLoaded;
        public event EventHandler SaveButtonClicked;
        public event EventHandler CloseButtonClicked;

        private OrderAddAmendPresenter _presenterAddAmend;

        public OrderAddAmendView(OrderListView viewOrderList)
        {
            InitializeComponent();

            OrderAddAmendPresenter PresenterLayer = new OrderAddAmendPresenter();
            PresenterLayer.SetView(this, viewOrderList);

            _presenterAddAmend = PresenterLayer;
            
        }

        private void OrderAddAmendView_Load(object sender, EventArgs e)
        {

            ViewLoaded?.Invoke(this, EventArgs.Empty);
            
            this.OrderRef.Text = _presenterAddAmend._OrderRef;
            this.Item.Text = _presenterAddAmend._ItemDesc;
            this.Customer.Text = _presenterAddAmend._Customer;
            this.Qty.Text = _presenterAddAmend._Qty.ToString();
            this.UnitCost.Text = _presenterAddAmend._UnitCost.ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _presenterAddAmend._OrderRef = this.OrderRef.Text;
            _presenterAddAmend._ItemDesc = this.Item.Text;
            _presenterAddAmend._Customer = this.Customer.Text;
            _presenterAddAmend._Qty = Int32.Parse(this.Qty.Text);
            _presenterAddAmend._UnitCost = Double.Parse(this.UnitCost.Text);

            SaveButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
