using System.Linq;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace ChartDashboardUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChartTrackBallBehavior_PositionChanged(object sender, Syncfusion.UI.Xaml.Charts.PositionChangedEventArgs e)
        {
            var currentDetails = e.CurrentPointInfos;

            foreach (var item in currentDetails)
            {
                var name = item.ValueX;

                var billionaire = viewModel.BillionairesList.FirstOrDefault(x => x.BillionaireName == name);
                if (billionaire != null)
                {
                    rank.Text = billionaire.Rank.ToString();
                    billionaryName.Text = billionaire.BillionaireName;
                    netWorth.Text = string.Format("${0}B", billionaire.BillionaireNetWorth);
                    country.Text = billionaire.BillionaireCountry;
                }
            }
        }

    }
}

