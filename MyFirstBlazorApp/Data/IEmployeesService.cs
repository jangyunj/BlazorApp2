namespace MyFirstBlazorApp.Data
{
    public interface IEmployeesService    //where methods live
    {
        List<Employees> GetEmployees(); 
        Employees GetEmployees(Guid id);

        void UpdateEmployees(Employees employee);
    }
}
