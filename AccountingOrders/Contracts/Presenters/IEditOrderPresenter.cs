using AccountingOrders.Models;

namespace AccountingOrders.Contracts.Presenters
{
    public interface IEditOrderPresenter
    {
        void PresentOrder(OrderModel order);
        void SaveOrder();
        void CancelEditingOrder();
    }
}