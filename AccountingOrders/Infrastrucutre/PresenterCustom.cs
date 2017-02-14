namespace AccountingOrders.Infrastrucutre
{
    public abstract class PresenterCustom<TView, TPresenter>
        where TView : IView<TPresenter>
        where TPresenter : class
    {
        public TView View { set; get; }

        protected PresenterCustom(TView view)
        {
            View = view;
            View.Presenter = this as TPresenter;
        }
    }
}