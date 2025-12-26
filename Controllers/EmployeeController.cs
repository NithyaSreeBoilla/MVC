using Microsoft.AspNetCore.Mvc;
using mvcdemo.Models;
using mvcdemo.Models.viewModels;

namespace mvcdemo.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Details()
        {
            Employee employee = new Employee()
            {
                EmployeeId = 101,
                Name = "Dillip",
                Gender = "Male",
                Department = "IT",
                Salary = 10000,
                AddressId = 1001
            };

            Address address = new Address()
            {
                AddressId = 1001,
                City = "Bhubaneswar",
                State = "Odisha",
                Country = "India",
                Pin = "755019"
            };

            EmployeeDetailsViewModel vm = new EmployeeDetailsViewModel()
            {
                Employee = employee,
                Address = address,
                PageTitle = "Employee Details Page",
                PageHeader = "Employee Details"
            };

            return View(vm);
        }
    }
}
