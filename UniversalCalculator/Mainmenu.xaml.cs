using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class Mainmenu : Page
	{
		public Mainmenu()
		{
			this.InitializeComponent();
		}


		// Page Navigation
		private void mathButton_Click(object sender, RoutedEventArgs e)
		{
			// Math Calculator
			this.Frame.Navigate(typeof(MainPage));
		}

		private void exitButton_Click(object sender, RoutedEventArgs e)
		{
			System.Environment.Exit(0);
		}

		private void currencyButton_Click(object sender, RoutedEventArgs e)
		{
			// Currency Conversion Calculator
			this.Frame.Navigate(typeof(CurrencyConversionCalculator));
		}

		private void mortgageButton_Click(object sender, RoutedEventArgs e)
		{
			// Mortgage Calculator
			this.Frame.Navigate(typeof(MortgageCalc));
		}

		private async void tripButton_Click(object sender, RoutedEventArgs e)
		{
			// Trip Calculator
			var dialogMessage = new MessageDialog("Trip calculator C# code will be developed later");
			await dialogMessage.ShowAsync();
			return;
		}
	}
}
