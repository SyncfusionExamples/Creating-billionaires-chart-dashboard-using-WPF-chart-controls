namespace ChartDashboardUI
{
    public class Model
    {
        public double Rank { get; set; }

        public string BillionaireName { get; set; }

        public double BillionaireNetWorth { get; set; } 

        public string BillionaireCountry { get; set; } 
        
        public string Category { get; set; }

        public string Country { get; set; }

        public double CategoryBillionaireCount { get; set; }

        public double CountryBillionaireCount { get; set; }

        public Model(string category, double categoryBillionaireCount, string country, double countryBillionaireCount)
        {
            Category = category;
            CategoryBillionaireCount = categoryBillionaireCount;
            Country = country;
            CountryBillionaireCount = countryBillionaireCount;
        }

        public Model(double rank,string name,double networth, string country)
        {
            Rank = rank;
            BillionaireName = name;
            BillionaireNetWorth = networth;
            BillionaireCountry = country;
        }
    }
}
