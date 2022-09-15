using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class CurrencyConversionCalculator : Page
	{
		public CurrencyConversionCalculator()
		{
			this.InitializeComponent();
		}

		private void exitButton_Click(object sender, RoutedEventArgs e)
		{
			System.Environment.Exit(0);
		}

		private void currencyConversionButton_Click(object sender, RoutedEventArgs e)
		{

			float Amount;
			int From;
			String From_Name;
			int To;
			String To_Name; ;
			String From_Begin = "";
			String To_Result = "";
			String To_Begin = "";
			String From_Result = "";

			Amount = float.Parse(amountTextBox.Text);

			if (usdFromComboBoxItem.IsSelected)
			{
				From = 1;
				From_Name = "US Dollars";
			}
			else if (euroFromComboBoxItem.IsSelected)
			{
				From = 2;
				From_Name = "Euro's";
			}
			else if (britishFromComboBoxItem.IsSelected)
			{
				From = 3;
				From_Name = "British Pounds";
			}
			else
			{
				From = 4;
				From_Name = "Indian Ruppes";
			}

			if (usdToComboBoxItem.IsSelected)
			{
				To = 1;
				To_Name = "US Dollars";
			}
			else if (euroToComboBoxItem.IsSelected)
			{
				To = 2;
				To_Name = "Euro's";
			}
			else if (britishToComboBoxItem.IsSelected)
			{
				To = 3;
				To_Name = "British Pounds";
			}
			else
			{
				To = 4;
				To_Name = "Indian Ruppes";
			}

			double conversion_output = Conversion_Calculation(Amount, From, To);

			if (From == 1 && To == 1)
			{
				From_Begin = "1 US Dollar";
				To_Result = "1 US Dollar";
				To_Begin = "1 US Dollar";
				From_Result = "1 US Dollar";
			}
			if (From == 1 && To == 2)
			{
				From_Begin = "1 US Dollar";
				To_Result = "0.85189982 Euro";
				To_Begin = "1 Euro";
				From_Result = "1.1739732 US Dollar";
			}
			if (From == 1 && To == 3)
			{
				From_Begin = "1 US Dollar";
				To_Result = "0.72872436 British Pounds";
				To_Begin = "1 British Pounds";
				From_Result = "1.371907 US Dollar";
			}
			if (From == 1 && To == 4)
			{
				From_Begin = "1 US Dollar";
				To_Result = "74.257327 Indian Rupee";
				To_Begin = "1 Indian Rupee";
				From_Result = "0.011492628 US Dollar";
			}
			if (From == 2 && To == 1)
			{
				From_Begin = "1 Euro";
				To_Result = "1.1739732 US Dollar";
				To_Begin = "1 US Dollar";
				From_Result = "0.85189982 Euro";
			}
			if (From == 2 && To == 2)
			{
				From_Begin = "1 Euro";
				To_Result = "1 Euro";
				To_Begin = "1 Euro";
				From_Result = "1 Euro";
			}
			if (From == 2 && To == 3)
			{
				From_Begin = "1 Euro";
				To_Result = "0.8556672 British Pound";
				To_Begin = "1 British Pound";
				From_Result = "1.1686692 Euro";
			}
			if (From == 2 && To == 4)
			{
				From_Begin = "1 Euro";
				To_Result = "87.00755 Indian Rupee";
				To_Begin = "1 Indian Rupee";
				From_Result = "0.013492774 Euro";
			}
			if (From == 3 && To == 1)
			{
				From_Begin = "1 British Pound";
				To_Result = "1.371907 US Dollar";
				To_Begin = "1 US Dollar";
				From_Result = "0.72872436 British Pound";
			}
			if (From == 3 && To == 2)
			{
				From_Begin = "1 British Pound";
				To_Result = "1.1686692 Euro";
				To_Begin = "1 Euro";
				From_Result = "0.8556672 British Pound";
			}
			if (From == 3 && To == 3)
			{
				From_Begin = "1 British Pound";
				To_Result = "1 British Pound";
				To_Begin = "1 British Pound";
				From_Result = "1 British Pound";
			}
			if (From == 3 && To == 4)
			{
				From_Begin = "1 British Pound";
				To_Result = "101.68635 Indian Rupee";
				To_Begin = "1 Indian Rupee";
				From_Result = "0.0098339397 British Pound";
			}
			if (From == 4 && To == 1)
			{
				From_Begin = "1 Indian Rupee";
				To_Result = "0.011492628 US Dollar";
				To_Begin = "1 US Dollar";
				From_Result = "74.257327 Indian Rupee";
			}
			if (From == 4 && To == 2)
			{
				From_Begin = "1 Indian Rupee";
				To_Result = "0.013492774 Euro";
				To_Begin = "1 Euro";
				From_Result = "87.00755 Indian Rupee";
			}
			if (From == 4 && To == 3)
			{
				From_Begin = "1 Indian Rupee";
				To_Result = "0.0098339397 British Pound";
				To_Begin = "1 British Pound";
				From_Result = "101.68635 Indian Rupee";
			}
			if (From == 4 && To == 4)
			{
				From_Begin = "1 Indian Rupee";
				To_Result = "1 Indian Rupee";
				To_Begin = "1 Indian Rupee";
				From_Result = "1 Indian Rupee";
			}

			inputAmountTextBlock.Text = Amount + " " + From_Name;
			outputTextBlock.Text = "$" + conversion_output + " " + To_Name;
			fromToConversionTextBlock.Text = From_Begin + " = " + To_Result;
			toFromConversionTextBlock.Text = To_Begin + " = " + From_Result;
		}
		private static double Conversion_Calculation(double Amount, int From, int To)
		{
			double conversion_output = 0;
			if (From == 1 && To == 1)
			{
				conversion_output = Amount;
			}
			if (From == 1 && To == 2)
			{
				conversion_output = Amount * 0.85189982;
			}
			if (From == 1 && To == 3)
			{
				conversion_output = Amount * 0.72872436;
			}
			if (From == 1 && To == 4)
			{
				conversion_output = Amount * 74.257327;
			}
			if (From == 2 && To == 1)
			{
				conversion_output = Amount * 1.1739732;
			}
			if (From == 2 && To == 2)
			{
				conversion_output = Amount;
			}
			if (From == 2 && To == 3)
			{
				conversion_output = Amount * 0.8556672;
			}
			if (From == 2 && To == 4)
			{
				conversion_output = Amount * 87.00755;
			}
			if (From == 3 && To == 1)
			{
				conversion_output = Amount * 1.371907;
			}
			if (From == 3 && To == 2)
			{
				conversion_output = Amount * 1.1686692;
			}
			if (From == 3 && To == 3)
			{
				conversion_output = Amount;
			}
			if (From == 3 && To == 4)
			{
				conversion_output = Amount * 101.68635;
			}
			if (From == 4 && To == 1)
			{
				conversion_output = Amount * 0.011492628;
			}
			if (From == 4 && To == 2)
			{
				conversion_output = Amount * 0.013492774;
			}
			if (From == 4 && To == 3)
			{
				conversion_output = Amount * 0.0098339397;
			}
			if (From == 4 && To == 4)
			{
				conversion_output = Amount;
			}
			return conversion_output;
		}
	}
}
