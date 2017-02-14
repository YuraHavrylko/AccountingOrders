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
    public partial class ShowOrderView : Form, IShowOrderView
    {
        public ShowOrderView()
        {
            InitializeComponent();
        }

        public IShowOrderPresenter Presenter { get; set; }
        public void ShowView()
        {
            ShowDialog();
        }

        public void CloseView()
        {
            Close();
        }

        public void Refresh(IEnumerable<OrderItemModel> orderItem)
        {
            dataGridViewOrderItem.DataSource = orderItem;
            dataGridViewOrderItem.Refresh();
        }

        public OrderItemModel GetSelectedItemOrder()
        {
            if (dataGridViewOrderItem.SelectedRows.Count < 1)
                return null;
            return dataGridViewOrderItem.SelectedRows[0].DataBoundItem as OrderItemModel;
        }

        public void SetShowOrder(OrderModel order)
        {
            edtId.Text = Convert.ToString(order.Id);
            edtNumber.Text = Convert.ToString(order.Number);
            edtFName.Text = Convert.ToString(order.FirstName);
            edtLName.Text = Convert.ToString(order.LastName);
            edtMName.Text = Convert.ToString(order.MidleName);
            dateTimePicker.Text = Convert.ToString(order.Date);
            totalAmount.Text = Convert.ToString(order.TotalAmount);
            errorLabel.Text = "";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Presenter.AddItemOrder();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                labelError.Text = null;
                Presenter.RemoveItemOrder();
            }
            catch (Exception)
            {
                labelError.Text = "Select object!";
            }
        }
    }
}
