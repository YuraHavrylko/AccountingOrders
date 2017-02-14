using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccountingOrders.Contracts.Presenters;
using AccountingOrders.Contracts.Views;
using AccountingOrders.Models;

namespace AccountingOrders.Views
{
    public partial class AddItemOrderView : Form, IAddItemOrderView
    {
        public AddItemOrderView()
        {
            InitializeComponent();
        }

        public IAddItemOrderPresenter Presenter { get; set; }
        public void ShowView()
        {
            ShowDialog();
        }

        public void CloseView()
        {
            Close();
        }

        public OrderItemModel GetItemOrder()
        {
            return new OrderItemModel()
            {
                Name = Convert.ToString(name.Text),
                Price = Convert.ToDouble(price.Text),
                Count = Convert.ToInt32(count.Text)
            };
        }

        public void SetItemAddedOrder(OrderModel order)
        {
            name.Text = "";
            count.Text = "";
            price.Text = "";
            errorLabel.Text = "";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                errorLabel.Text = null;
                Presenter.SaveItemOrder();
            }
            catch (Exception exception)
            {
                errorLabel.Text = exception.Message;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            CloseView();
        }
    }
}
