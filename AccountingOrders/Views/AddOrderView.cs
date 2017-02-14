using System;
using System.Windows.Forms;
using AccountingOrders.Contracts.Presenters;
using AccountingOrders.Contracts.Views;
using AccountingOrders.Models;

namespace AccountingOrders.Views
{
    public partial class AddOrderView : Form, IAddOrderView
    {
        public AddOrderView()
        {
            InitializeComponent();
        }

        public IAddOrderPresenter Presenter { get; set; }
        public void ShowView()
        {
            ShowDialog();
        }

        public void CloseView()
        {
            Close();
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

        public void SetAddedOrder()
        {
            edtNumber.Text = "";
            edtFName.Text = "";
            edtLName.Text = "";
            edtMName.Text = "";
            dateTimePicker.Text = "";
            errorLabel.Text = "";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            CloseView();
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
    }
}
