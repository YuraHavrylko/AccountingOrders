using System;

namespace AccountingOrders.Contracts.Presenters
{
    public interface IOrderPresenter
    {
        void AddOrder();
        void EditOrder();
        void RemoveOrder();
        void ShowOrder();
        void FindByDate(DateTime start, DateTime end);
        void Refresh();
    }
}