using AccountingOrders.Contracts.Presenters;
using AccountingOrders.Infrastrucutre;
using AccountingOrders.Models;

namespace AccountingOrders.Contracts.Views
{
    public interface IAddOrderView : IView<IAddOrderPresenter>
    {
        OrderModel GetOrder();
        void SetAddedOrder();
    }
}