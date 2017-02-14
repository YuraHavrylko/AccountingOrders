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
    public partial class OrderView : Form, IOrderView
    {
        public OrderView()
        {
            InitializeComponent();
        }

        public IOrderPresenter Presenter { get; set; }
        public void ShowView()
        {
            ShowView();
        }

        public void CloseView()
        {
            CloseView();
        }

        public void Refresh(IEnumerable<OrderModel> orders)
        {
            dataGridViewOrder.DataSource = orders;
            dataGridViewOrder.Refresh();
        }

        public OrderModel GetSelectedOrder()
        {
            if (dataGridViewOrder.SelectedRows.Count < 1)
                return null;
            return dataGridViewOrder.SelectedRows[0].DataBoundItem as OrderModel;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Presenter.AddOrder();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                labelError.Text = null;
                Presenter.RemoveOrder();
            }
            catch (Exception)
            {
                labelError.Text = "Select object!";
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                labelError.Text = null;
                Presenter.EditOrder();
            }
            catch (Exception)
            {
                labelError.Text = "Select object!";
            }
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            try
            {
                labelError.Text = null;
                Presenter.ShowOrder();
            }
            catch (Exception)
            {
                labelError.Text = "Select object!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Presenter.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Presenter.FindByDate(start.Value, finish.Value);
        }
    }
}
