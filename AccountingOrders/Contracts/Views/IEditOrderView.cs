using AccountingOrders.Contracts.Presenters;
using AccountingOrders.Infrastrucutre;
using AccountingOrders.Models;

namespace AccountingOrders.Contracts.Views
{
    public interface IEditOrderView : IView<IEditOrderPresenter>
    {
        void SetEditedOrder(OrderModel order);
        OrderModel GetOrder();
    }
}