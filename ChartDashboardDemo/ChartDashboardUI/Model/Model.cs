namespace ChartDashboardUI
{
    public class Model
    {
        public string BillionaireName { get; set; }

        public double BillionaireNetWorth { get; set; } 

        public string BillionaireCountry { get; set; } 

        public double BillionaireAge { get; set; } 
        
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

        public Model(string name,double networth,double age,string country)
        {
            BillionaireName = name;
            BillionaireNetWorth = networth;
            BillionaireAge = age;
            BillionaireCountry = country;
          
        }
    }
}
