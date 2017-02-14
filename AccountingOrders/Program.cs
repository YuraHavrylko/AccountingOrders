using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccountingOrders.Contracts.Presenters;
using AccountingOrders.Contracts.Views;
using AccountingOrders.Infrastrucutre;

namespace AccountingOrders
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var presenter = ServiceLocator.Instance.Resolve<IOrderPresenter>();
            var orderPresenter = presenter as PresenterCustom<IOrderView, IOrderPresenter>;
            var view = orderPresenter.View as Form;

            Application.Run(view);
        }
    }
}
