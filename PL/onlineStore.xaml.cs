﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Collections.ObjectModel; // ariel
using System.Collections; // ariel

using Backend;
using BL;
namespace PL
{
    /// <summary>
    /// Interaction logic for onlineStore.xaml
    /// </summary>
    [Serializable]
    public partial class onlineStore : Window
    {
        BL_Manager BL_manager;
        ObservableCollection<string> zoneList = new ObservableCollection<string>(); // ariel
        ListBox dragSource = null; // ariel

        public onlineStore(BL_Manager BL_manager)
        {
            this.BL_manager=BL_manager;
            InitializeComponent();
        }

        private void loadTypes(object sender, RoutedEventArgs e)
        {
            foreach (string type in Enum.GetNames(typeof(Product.Type)))
            {
                types.Items.Add(type);
                Console.WriteLine(type);
            }
            types.Items.Add("All");
            types.SelectedItem = "All";
        }
        private void loadProductView(object sender, RoutedEventArgs e)
        {
            List<Product> selectedProducts;
            //BL_manager.updatebestSeller();
            if(types.SelectedValue=="All")
            {
                selectedProducts = BL_manager.BL_product.getAllProductsList();
            }
            else
            {
                selectedProducts = BL_manager.BL_product.getProductsListByType((Product.Type)Enum.Parse(typeof(Product.Type), (string)types.SelectedValue));
            }
           // ObservableCollection<Product> myCollection = new ObservableCollection<Product>(selectedProducts);
            
            ProductView.ItemsSource=selectedProducts;
            ProductView.SelectedIndex = 0;
            amount.Text = "1";
            
        }
       
        private void closeClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void maximaizeB_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
                this.WindowState = WindowState.Normal;
            else
            {
                this.WindowState = WindowState.Maximized;
            }
        }

        private void minimaizeClick(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Console.WriteLine(types.SelectedValue);
            this.loadProductView(sender, e);
        }

        private void ListBox_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) ///// ariel
        {
            ListBox parent = (ListBox)sender;
            dragSource = parent;
            object data = GetDataFromListBox(dragSource, e.GetPosition(parent));

            if (data != null)
            {
                DragDrop.DoDragDrop(parent, data, DragDropEffects.Move);
            }
        }

        private void ListBox_Drop(object sender, DragEventArgs e)
        {
            ListBox parent = (ListBox)sender;
            Product p = (Product)e.Data.GetData(typeof(Product));
           // ((IList)dragSource.ItemsSource).Remove(data);
            Tuple<Product, int> data = new Tuple<Product, int>(p, int.Parse(amount.Text));
            parent.Items.Add(data);
        }

        #region GetDataFromListBox(ListBox,Point)
        private static object GetDataFromListBox(ListBox source, Point point)
        {
            UIElement element = source.InputHitTest(point) as UIElement;
            if (element != null)
            {
                object data = DependencyProperty.UnsetValue;
                while (data == DependencyProperty.UnsetValue)
                {
                    data = source.ItemContainerGenerator.ItemFromContainer(element);
                    if (data == DependencyProperty.UnsetValue)
                    {
                        element = VisualTreeHelper.GetParent(element) as UIElement;
                    }
                    if (element == source)
                    {
                        return null;
                    }
                }
                if (data != DependencyProperty.UnsetValue)
                {
                    return data;
                }
            }
            return null;
        }

        #endregion

        private void addToCart_Click(object sender, RoutedEventArgs e)
        {
            Product p = (ProductView.SelectedItem as Product);
            int m=int.Parse(amount.Text);
            Tuple<Product, int> item = new Tuple<Product, int>(p, m);
            ShoppingCart.Items.Add(item);

        }

        private void buy_Click(object sender, RoutedEventArgs e)
        {
            Window1 a = new Window1(BL_manager);
            a.Show();
            List<Tuple<Product,int>> list = ShoppingCart.Items.OfType<Tuple<Product,int>>().ToList();
            Dictionary<string, int> receipt = new Dictionary<string, int>();
            Dictionary<string, double> products = new Dictionary<string, double>();
            foreach (Tuple<Product,int> p in list)
            {
                if(receipt.ContainsKey(p.Item1.name))
                {
                    receipt[p.Item1.name]+=p.Item2;
                }
                else
                {
                    receipt.Add(p.Item1.name, p.Item2);
                    products.Add(p.Item1.name, p.Item1.price);
                }
                
            }
            BL_manager.BL_transaction.Add(false, receipt, products, "CreditCard");
        }

        private void increase_Click(object sender, RoutedEventArgs e)
        {
            Product selected = ProductView.SelectedItem as Product;
            if (selected.stockCount > int.Parse(amount.Text))
            {
                int num = int.Parse(amount.Text);
                num++;
                amount.Text = Convert.ToString(num);
            }

        }
        private void decrease_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(amount.Text) > 0)
            {
                int num = int.Parse(amount.Text);
                num--;
                amount.Text = Convert.ToString(num);
            }
        }

       

        

    }
    
}
