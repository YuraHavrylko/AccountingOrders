using AccountingOrders.Contracts.Presenters;
using AccountingOrders.Contracts.Views;
using AccountingOrders.Infrastrucutre;
using AccountingOrders.Models;
using AccountingOrders.Services;

namespace AccountingOrders.Presenters
{
    public class EditOrderPresenter : PresenterCustom<IEditOrderView, IEditOrderPresenter>, IEditOrderPresenter
    {
        private OrderModel _editOrderModel;
        private readonly DataLayer _dataLayer;

        public EditOrderPresenter(IEditOrderView view) : base(view)
        {
            _dataLayer = new DataLayer();
        }

        public void PresentOrder(OrderModel order)
        {
            _editOrderModel = order;
            View.SetEditedOrder(order);
            View.ShowView();
        }

        public void SaveOrder()
        {
            var order = View.GetOrder();
            //order.Id = _editOrderModel.Id;
            _dataLayer.EditOrderById(_editOrderModel.Id, order);
            View.CloseView();
        }

        public void CancelEditingOrder()
        {
            View.CloseView();
        }
    }
}