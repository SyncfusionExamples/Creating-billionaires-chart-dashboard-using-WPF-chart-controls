using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls.Primitives;

using Syncfusion.UI.Xaml.Charts;

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
                var XValue = item.ValueX;
               
                var billionaire = viewModel.BillionairesList.FirstOrDefault(x => x.BillionaireAge.ToString() == XValue);
                if (billionaire != null)
                {
                    billionaryName.Text = billionaire.BillionaireName;
                    netWorth.Text = string.Format("${0}B", billionaire.BillionaireNetWorth);
                    age.Text = billionaire.BillionaireAge.ToString();
                    country.Text = billionaire.BillionaireCountry;
                }
            }
        }
    }
}

