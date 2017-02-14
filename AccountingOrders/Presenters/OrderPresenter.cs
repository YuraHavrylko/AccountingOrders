using System;
using AccountingOrders.Contracts.Presenters;
using AccountingOrders.Contracts.Views;
using AccountingOrders.Infrastrucutre;
using AccountingOrders.Services;

namespace AccountingOrders.Presenters
{
    public class OrderPresenter : PresenterCustom<IOrderView, IOrderPresenter>, IOrderPresenter
    {
        private readonly DataLayer _dataLayer;
        private IAddOrderPresenter _addOrderPresenter;
        private IEditOrderPresenter _editOrderPresenter;
        private IShowOrderPresenter _showOrderPresenter;

        public OrderPresenter(IOrderView view, IAddOrderPresenter addOrderPresenter, IEditOrderPresenter editOrderPresenter, IShowOrderPresenter showOrderPresenter) : base(view)
        {
            _dataLayer = new DataLayer();
            _addOrderPresenter = addOrderPresenter;
            _editOrderPresenter = editOrderPresenter;
            _showOrderPresenter = showOrderPresenter;
            ReInitialize();
        }

        public void AddOrder()
        {
            _addOrderPresenter.PresentOrder();
            ReInitialize();
        }

        public void EditOrder()
        {
            var editObject = View.GetSelectedOrder();
            _editOrderPresenter.PresentOrder(editObject);
            ReInitialize();
        }

        public void RemoveOrder()
        {
            var removeObject = View.GetSelectedOrder();
            _dataLayer.RemoveOrderById(removeObject.Id);
            ReInitialize();
        }

        public void ShowOrder()
        {
            var showObject = View.GetSelectedOrder();
            _showOrderPresenter.PresentOrder(showObject);
            ReInitialize();
        }

        public void FindByDate(DateTime start, DateTime end)
        {
            var orders = _dataLayer.GetAllOrderByData(start, end);
            View.Refresh(orders);
        }

        private void ReInitialize()
        {
            var orders = _dataLayer.GetAllOrder();
            View.Refresh(orders);
        }

        public void Refresh()
        {
            ReInitialize();
        }
    }
}