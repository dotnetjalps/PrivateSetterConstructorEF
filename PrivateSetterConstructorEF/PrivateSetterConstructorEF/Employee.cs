using System.ComponentModel.DataAnnotations;

namespace PrivateSetterConstructorEF
{
    public class Employee
    {
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        private Employee()
        {
            
        }
        [Key]
        public int EmployeeId { get; set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Designation { get; set; }
    }
}