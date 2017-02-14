using System.Collections.Generic;
using AccountingOrders.Contracts.Presenters;
using AccountingOrders.Infrastrucutre;
using AccountingOrders.Models;

namespace AccountingOrders.Contracts.Views
{
    public interface IOrderView : IView<IOrderPresenter>
    {
        void Refresh(IEnumerable<OrderModel> orders);
        OrderModel GetSelectedOrder();
    }
}