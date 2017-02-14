using AccountingOrders.Models;

namespace AccountingOrders.Contracts.Presenters
{
    public interface IAddItemOrderPresenter
    {
        void SaveItemOrder();
        void CancelItemAddingOrder();
        void PresentItemOrder(OrderModel order);
    }
}