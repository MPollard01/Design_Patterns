namespace CSharpDesignPatterns.Builder.FacetedBuilder
{
    public class EmployeeBuilder
    {
        protected Employee employee = new Employee();
        public EmployeeJobBuilder Works => new EmployeeJobBuilder(employee);
        public EmployeeAddressBuilder Lives => new EmployeeAddressBuilder(employee);

        public static implicit operator Employee(EmployeeBuilder eb)
        {
            return eb.employee;
        }
    }
}
