namespace CSharpDesignPatterns.Builder.FacetedBuilder
{
    public class Employee
    {
        public string StreetAddress { get; set; }
        public string Postcode { get; set; }
        public string City { get; set; }
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public int AnnualIncome { get; set; }
        public override string ToString()
        {
            return $"{nameof(StreetAddress)}: {StreetAddress}";
        }
    }
}
