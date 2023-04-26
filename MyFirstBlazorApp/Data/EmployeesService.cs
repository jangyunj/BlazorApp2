namespace MyFirstBlazorApp.Data
{
    public class EmployeesService : IEmployeesService
    {
        private List<Employees> employeesList = new List<Employees>
        {
            new Employees
            {
                Id = Guid.NewGuid(),
                Name = "Employee 1"

            },
            new Employees
            {
                Id = Guid.NewGuid(),
                Name = "Employee 2"

            }
        };

        public void AddEmployee(Employees employee)
        {
            var id = Guid.NewGuid();
            employee.Id = id;
            employeesList.Add(employee);

            
        }

        public List<Employees> GetEmployees()
        {
            return employeesList;
        }

        public Employees GetEmployees(Guid id)
        {
            return employeesList.SingleOrDefault(x => x.Id == id);
        }

        public void UpdateEmployees(Employees employee)
        {
            var getOldEmployee = GetEmployees(employee.Id);
            getOldEmployee.Name = employee.Name;
        }
    }
}
