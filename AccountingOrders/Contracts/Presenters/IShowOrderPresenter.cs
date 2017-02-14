using AccountingOrders.Models;

namespace AccountingOrders.Contracts.Presenters
{
    public interface IShowOrderPresenter
    {
        void AddItemOrder();
        void RemoveItemOrder();
        void PresentOrder(OrderModel order);
    }
}