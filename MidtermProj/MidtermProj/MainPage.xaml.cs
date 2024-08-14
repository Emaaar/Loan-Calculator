using System;
using Xamarin.Forms;

namespace MidtermProj
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Calculate_Clicked(object sender, EventArgs e)
        {
            double principalAmount = Convert.ToDouble(txtPrincipalAmount.Text);
            int terms = Convert.ToInt32(pickerTerms.SelectedItem);
            double serviceFee = principalAmount * 0.015 >= 1500 ? 1500 : principalAmount * 0.015;
            double fillingFee = principalAmount * 0.015 >= 1500 ? 1500 : principalAmount * 0.015;
            double insuranceFee = principalAmount * 0.015 * terms / 12;
            double savingRetention = principalAmount * 0.01;
            double monthlyAmortization = (principalAmount * 0.015) * Math.Pow((1 + 0.015), terms) / Math.Pow((1 + 0.015) -1, terms);
            double balance = Convert.ToDouble(txtBalance.Text);
            double netLoanProceeds = principalAmount - (balance + serviceFee + fillingFee + insuranceFee + savingRetention);

            Navigation.PushAsync(new ResultPage(
                txtName.Text, txtDate.Text, pickerLoanType.SelectedItem.ToString(), principalAmount, terms,
                serviceFee, fillingFee, insuranceFee, savingRetention, monthlyAmortization, balance, netLoanProceeds));
        }
    }
    }