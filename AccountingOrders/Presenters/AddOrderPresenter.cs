using AccountingOrders.Contracts.Presenters;
using AccountingOrders.Contracts.Views;
using AccountingOrders.Infrastrucutre;
using AccountingOrders.Services;

namespace AccountingOrders.Presenters
{
    public class AddOrderPresenter : PresenterCustom<IAddOrderView, IAddOrderPresenter>, IAddOrderPresenter
    {
        private readonly DataLayer _dataLayer;

        public AddOrderPresenter(IAddOrderView view) : base(view)
        {
            _dataLayer = new DataLayer();
        }

        public void SaveOrder()
        {
            var order = View.GetOrder();
            _dataLayer.AddOrder(order);
            View.CloseView();
        }

        public void CancelAddingOrder()
        {
            View.CloseView();
        }

        public void PresentOrder()
        {
            View.SetAddedOrder();
            View.ShowView();
        }
    }
}