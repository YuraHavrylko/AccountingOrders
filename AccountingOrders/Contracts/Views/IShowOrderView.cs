using System.Collections.Generic;
using AccountingOrders.Contracts.Presenters;
using AccountingOrders.Infrastrucutre;
using AccountingOrders.Models;

namespace AccountingOrders.Contracts.Views
{
    public interface IShowOrderView : IView<IShowOrderPresenter>
    {
        void Refresh(IEnumerable<OrderItemModel> orderItem);
        OrderItemModel GetSelectedItemOrder();
        void SetShowOrder(OrderModel order);
    }
}