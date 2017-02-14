namespace AccountingOrders.Contracts.Presenters
{
    public interface IAddOrderPresenter
    {
        void SaveOrder();
        void CancelAddingOrder();
        void PresentOrder();
    }
}