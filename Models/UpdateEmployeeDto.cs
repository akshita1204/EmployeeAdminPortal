namespace EmployeeAdminPortal.Models
{
    public class UpdateEmployeeDto
    {
        public required String Name { get; set; }
        public required String Email { get; set; }
        public String? Phone { get; set; }
        public String Salary { get; set; }
    }
}
