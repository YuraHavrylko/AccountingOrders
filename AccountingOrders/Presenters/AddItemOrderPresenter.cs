using AccountingOrders.Contracts.Presenters;
using AccountingOrders.Contracts.Views;
using AccountingOrders.Infrastrucutre;
using AccountingOrders.Models;
using AccountingOrders.Services;

namespace AccountingOrders.Presenters
{
    public class AddItemOrderPresenter : PresenterCustom<IAddItemOrderView, IAddItemOrderPresenter>, IAddItemOrderPresenter
    {
        private readonly DataLayer _dataLayer;
        private OrderModel _addOrderModel;

        public AddItemOrderPresenter(IAddItemOrderView view) : base(view)
        {
            _dataLayer = new DataLayer();
        }

        public void SaveItemOrder()
        {
            var orderItem = View.GetItemOrder();
            orderItem.OrderModelId = _addOrderModel.Id;
            _dataLayer.AddOrderItem(orderItem);
            View.CloseView();
        }

        public void CancelItemAddingOrder()
        {
            View.CloseView();
        }

        public void PresentItemOrder(OrderModel order)
        {
            _addOrderModel = order;
            View.SetItemAddedOrder(order);
            View.ShowView();
        }
    }
}