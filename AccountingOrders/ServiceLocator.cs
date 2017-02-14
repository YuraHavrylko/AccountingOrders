using AccountingOrders.Contracts.Presenters;
using AccountingOrders.Contracts.Views;
using AccountingOrders.Presenters;
using AccountingOrders.Views;
using Microsoft.Practices.Unity;

namespace AccountingOrders
{
    public class ServiceLocator
    {
        private IUnityContainer _container;
        private static ServiceLocator _servsceLocator;
        public static ServiceLocator Instance
        {
            get
            {
                return _servsceLocator ?? (_servsceLocator = new ServiceLocator());
            }
        }

        private ServiceLocator()
        {
            _container = new UnityContainer();

            InitiaizeServices(_container);
            InitializeViews(_container);
        }

        public T Resolve<T>()
        {
            return _container.Resolve<T>();
        }

        private void InitiaizeServices(IUnityContainer container)
        {
            //container.RegisterType<ISerializer, Serializer>(new ContainerControlledLifetimeManager());
         //   container.RegisterType<IDataStorage, DataStorage>();
        }

        private void InitializeViews(IUnityContainer container)
        {
            container.RegisterType<IOrderPresenter, OrderPresenter>();
            container.RegisterType<IAddOrderPresenter, AddOrderPresenter>();
            container.RegisterType<IEditOrderPresenter, EditOrderPresenter>();
            container.RegisterType<IShowOrderPresenter, ShowOrderPresenter>();
            container.RegisterType<IAddItemOrderPresenter, AddItemOrderPresenter>();

            container.RegisterType<IOrderView, OrderView>();
            container.RegisterType<IAddOrderView, AddOrderView>();
            container.RegisterType<IEditOrderView, EditOrderView>();
            container.RegisterType<IShowOrderView, ShowOrderView>();
            container.RegisterType<IAddItemOrderView, AddItemOrderView>();
        }
    }
}