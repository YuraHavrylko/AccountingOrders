using AccountingOrders.Contracts.Presenters;
using AccountingOrders.Infrastrucutre;
using AccountingOrders.Models;

namespace AccountingOrders.Contracts.Views
{
    public interface IAddItemOrderView : IView<IAddItemOrderPresenter>
    {
        OrderItemModel GetItemOrder();
        void SetItemAddedOrder(OrderModel order);
    }
}