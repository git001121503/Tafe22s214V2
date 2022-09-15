using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Midi;
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
	public sealed partial class MortgageCalc : Page
	{
		public MortgageCalc()
		{
			this.InitializeComponent();
		}

		private void exitButton_Click(object sender, RoutedEventArgs e)
		{
			System.Environment.Exit(0);
		}




		private async void calcButton_Click(object sender, RoutedEventArgs e)
		{
			double monthlyRepay, monthlyIR, loanAmount, yearlyIR;
			double month;
			double year;
			double durationMY;

			try
			{
				loanAmount = double.Parse(pBorrowBox.Text);

				monthlyIR = double.Parse(yirBox.Text) /12;
				yearlyIR = double.Parse(yirBox.Text);

				month = double.Parse(monthBox.Text);
				year = double.Parse(yearsBox.Text) * 12;
				durationMY = year + month;

				if (monthlyIR > 1)
				{
					monthlyIR = monthlyIR / 100;
				}
				monthlyRepay = loanAmount * ((monthlyIR * Math.Pow((1 + monthlyIR),durationMY))
				/ (Math.Pow(1 + monthlyIR,durationMY) - 1));
				mirBox.Text = monthlyIR.ToString("#00.0000");
				monthlyRepayBox.Text = monthlyRepay.ToString("C");;
			}
			catch (Exception ex)
			{
				var dialogMessage = new MessageDialog(ex.Message);
				return;
			}
	

		}

		
	}
}
