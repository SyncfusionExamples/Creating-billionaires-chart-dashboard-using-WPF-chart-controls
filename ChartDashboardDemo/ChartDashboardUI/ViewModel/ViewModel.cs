using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;

using Syncfusion.UI.Xaml.Charts;

namespace ChartDashboardUI
{
    public class ViewModel
    {
        // Stores 2023 billionaires data
        ObservableCollection<Model> billionairesList;
        public ObservableCollection<Model> BillionairesList
        {
            get { return billionairesList; }
            set { billionairesList = value; }
        }

        // Stores the top 5 category and country billionare data
        public ObservableCollection<Model> BillionaryCategoryandCountry { get; set; }

        public ViewModel()
        {
            BillionairesList = new ObservableCollection<Model>();
            //Reads the CSV file and stores the data in the BillionairesList
            ReadCSVFile();

            BillionaryCategoryandCountry = new ObservableCollection<Model>()
            {
                new Model("Finance & Investments",372,"US",735),
                new Model("Manufacturing",324,"China",495),
                new Model("Technology",313,"India",169),
                new Model("Fashion & Retail",266,"Germany",126),
                new Model("Food & Beverage",212,"Russia",105),
            };
        }

        private void ReadCSVFile()
        {
            Assembly executingAssembly = typeof(App).GetTypeInfo().Assembly;
            Stream inputStream = executingAssembly.GetManifestResourceStream("ChartDashboardUI.Resource.dataset.csv");
            string line;
            ObservableCollection<string> lines = new ObservableCollection<string>();
            if(inputStream != null)
            {
                using StreamReader reader = new StreamReader(inputStream);
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
                lines.RemoveAt(0);
                foreach (var items in lines)
                {
                    string[] data = items.Split(',');
                    double networth = Convert.ToDouble(data[2]);
                    double age = Convert.ToDouble(data[3]);
                    BillionairesList.Add(new Model(data[1], networth,age, data[4]));
                }

            }

        }
    }
}
