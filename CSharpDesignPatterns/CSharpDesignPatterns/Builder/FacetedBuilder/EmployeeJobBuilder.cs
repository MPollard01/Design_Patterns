namespace CSharpDesignPatterns.Builder.FacetedBuilder
{
    public class EmployeeJobBuilder : EmployeeBuilder
    {
        public EmployeeJobBuilder(Employee employee)
        {
            this.employee = employee;
        }

        public EmployeeJobBuilder At(string companyName)
        {
            employee.CompanyName = companyName;
            return this;
        }

        public EmployeeJobBuilder AsA(string position)
        {
            employee.Position = position;
            return this;
        }

        public EmployeeJobBuilder Earning(int amount)
        {
            employee.AnnualIncome = amount;
            return this;
        }
    }
}
