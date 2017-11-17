using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using Wcf.Entities;
using Wcf.Client.WcfServices;

namespace Wcf.Client
{
    public class MainWindowViewModel : BindableBase
    {

        private ObservableCollection<OrderItemModel> _Items = new ObservableCollection<OrderItemModel>();
        private Order _CurrentOrder = new Order();

        public MainWindowViewModel()
        {
            _CurrentOrder.OrderDate = DateTime.Now;
            _CurrentOrder.OrderStatusId = 1;
            SubmitOrderCommand = new DelegateCommand(OnSubmitOrder);
            if (!DesignerProperties.GetIsInDesignMode(new DependencyObject()))
            {
                LoadProductsAndCustomers();
            }
        }

        public ObservableCollection<OrderItemModel> Items
        {
            get { return _Items; }
            set { SetProperty(ref _Items, value); }
        }

        public Order CurrentOrder
        {
            get { return _CurrentOrder; }
            set { SetProperty(ref _CurrentOrder, value); }
        }

        public DelegateCommand SubmitOrderCommand { get; private set; }

        private void LoadProductsAndCustomers()
        {
           // WcfProxy proxy = new WcfProxy("NetTcpBinding_IWcfService");
            WcfServiceClient proxy = new WcfServiceClient("NetTcpBinding_IWcfService");
            try
            {
                Order = proxy.GetOrders();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load server data. " + ex.Message);
            }
            finally
            {
                proxy.Close();
            }

        }

        private void OnSubmitOrder()
        {
            if (_CurrentOrder.CustomerId != Guid.Empty && _CurrentOrder.OrderItems.Count > 0)
            {
                WcfServiceClient proxy = new WcfServiceClient("NetTcpBinding_IWcfService");
                try
                {
                    proxy.CloseOrder(_CurrentOrder);
                    CurrentOrder = new Order();
                    CurrentOrder.OrderDate = DateTime.Now;
                    CurrentOrder.OrderStatusId = 1;
                    Items = new ObservableCollection<OrderItemModel>();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving order, please try again later.");
                    // Log it
                }
                finally
                {
                    proxy.Close();
                }
            }
            else
            {
                MessageBox.Show("You must select a customer and add order items to submit an order");
            }
        }
    }
}
