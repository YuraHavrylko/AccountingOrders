namespace AccountingOrders.Infrastrucutre
{
    public interface IView<TPresenter>
    {
        TPresenter Presenter { get; set; }

        void ShowView();
        void CloseView();
    }
}