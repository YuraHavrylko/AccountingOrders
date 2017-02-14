using AccountingOrders.Contracts.Presenters;
using AccountingOrders.Contracts.Views;
using AccountingOrders.Infrastrucutre;
using AccountingOrders.Models;
using AccountingOrders.Services;

namespace AccountingOrders.Presenters
{
    public class ShowOrderPresenter : PresenterCustom<IShowOrderView, IShowOrderPresenter>, IShowOrderPresenter
    {
        private OrderModel _showOrderModel;
        private readonly DataLayer _dataLayer;
        private readonly AddItemOrderPresenter _addItemOrderPresenter;

        public ShowOrderPresenter(IShowOrderView view, AddItemOrderPresenter addItemOrderPresenter) : base(view)
        {
            _addItemOrderPresenter = addItemOrderPresenter;
            _dataLayer = new DataLayer();
        }

        public void AddItemOrder()
        {
            _addItemOrderPresenter.PresentItemOrder(_showOrderModel);
            ReInitialize();
        }

        public void RemoveItemOrder()
        {
            var removeObject = View.GetSelectedItemOrder();
            _dataLayer.RemoveOrderItemById(removeObject.Id);
            ReInitialize();
        }

        public void PresentOrder(OrderModel order)
        {
            
            _showOrderModel = order;
            View.SetShowOrder(order);
            ReInitialize();
            View.ShowView();
        }

        private void ReInitialize()
        {
            var orders = _dataLayer.GetOrderItemById(_showOrderModel.Id);
            View.Refresh(orders);
        }

        public void Refresh()
        {
            ReInitialize();
        }
    }
}