using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MidtermProj
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResultPage : ContentPage
    {
        public ResultPage(string name, string date, string loanType, double principalAmount, int terms,
            double serviceFee, double fillingFee, double insuranceFee, double savingRetention,
            double monthlyAmortization, double balance, double netLoanProceeds)
        {
            InitializeComponent();

            lblName.Text = "" + name;
            lblDate.Text = "" + date;
            lblLoanType.Text = "" + loanType;
            lblPrincipalAmount.Text = "" + principalAmount.ToString("N2");
            lblTerms.Text = "" + terms;
            lblServiceFee.Text = "" + serviceFee.ToString("N2");
            lblFillingFee.Text = "" + fillingFee.ToString("N2");
            lblInsuranceFee.Text = "" + insuranceFee.ToString("N2");
            lblSavingRetention.Text = "" + savingRetention.ToString("N2");
            lblMonthlyAmortization.Text = "" + monthlyAmortization.ToString("N2");
            lblBalance.Text = "" + balance.ToString("N2");
            lblNetLoanProceeds.Text = "" + netLoanProceeds.ToString("N2");
        }
    }
}
