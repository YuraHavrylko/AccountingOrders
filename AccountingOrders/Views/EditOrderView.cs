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
    public partial class EditOrderView : Form, IEditOrderView
    {
        public EditOrderView()
        {
            InitializeComponent();
        }

        public IEditOrderPresenter Presenter { get; set; }
        public void ShowView()
        {
            ShowDialog();
        }

        public void CloseView()
        {
            Close();
        }

        public void SetEditedOrder(OrderModel order)
        {
            edtNumber.Text = Convert.ToString(order.Number);
            edtFName.Text = Convert.ToString(order.FirstName);
            edtLName.Text = Convert.ToString(order.LastName); 
            edtMName.Text = Convert.ToString(order.MidleName);
            dateTimePicker.Text = Convert.ToString(order.Date);
            errorLabel.Text = "";
        }

        public OrderModel GetOrder()
        {
            return new OrderModel()
            {
                Number = Convert.ToInt32(edtNumber.Text),
                Date = Convert.ToDateTime(dateTimePicker.Text),
                FirstName = Convert.ToString(edtFName.Text),
                LastName = Convert.ToString(edtLName.Text),
                MidleName = Convert.ToString(edtMName.Text),
            };
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                errorLabel.Text = null;
                Presenter.SaveOrder();
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
