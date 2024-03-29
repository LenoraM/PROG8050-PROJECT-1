﻿using PROG8050_PROJECT.View;
using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PROG8050_PROJECT.Views
{
	/// <summary>
	/// Interaction logic for Order.xaml
	/// </summary>
	public partial class Order : Page
	{
		public Order()
		{
			InitializeComponent();
		}

		private void BtnSearch_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show($"Customer: {textBox_CustomerSearchbar.Text} details loaded!");
		}

		private void BtnAddNew_Click(object sender, RoutedEventArgs e)
		{
			this.NavigationService.Navigate(new Uri("./Views/NewCustomer.xaml", UriKind.RelativeOrAbsolute));
		}

		private void BtnShowOrders_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show($"All Order will be populated in the order table..");
		}

		private void BtnDelete_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show($"Selected Products are deleted!");
		}

		private void BtnSelectAll_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show($"Orders are selected from the order table!");
		}

		private void btnCreateOrder_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show($"Order order# is placed successfully!", "Success", MessageBoxButton.OK);
			this.NavigationService.Navigate(new Uri("./Views/PrintOrder.xaml", UriKind.RelativeOrAbsolute));
		}
		private void Row_CustomerDetail_Click(object sender, MouseButtonEventArgs e)
		{
			MessageBox.Show($" Inside Customer Detail table", "Success", MessageBoxButton.OK);
			this.NavigationService.Navigate(new Uri("./Views/UpdateCustomer.xaml", UriKind.RelativeOrAbsolute));
		}

		private void Row_ProductDetail_Click(object sender, MouseButtonEventArgs e)
		{
			this.NavigationService.Navigate(new Uri("./Views/QuantityProductOrder.xaml", UriKind.RelativeOrAbsolute));
		}
	}
}
