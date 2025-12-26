using mvcdemo.Models;

namespace mvcdemo.Models.viewModels
{
    public class EmployeeDetailsViewModel
    {
        public Employee Employee { get; set; }
        public Address Address { get; set; }
        public string PageTitle { get; set; }
        public string PageHeader { get; set; }
    }
}
