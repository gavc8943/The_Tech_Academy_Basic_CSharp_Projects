using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    public class Employee   // Create an Employee class with Id, FirstName and LastName properties.
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee(int Id, String FirstName, String LastName) //created a constructor and initialised properties
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public static bool operator ==  (Employee employee1, Employee employee2) // override the == operator
        {
            bool Status = false;

            if (employee1.Id == employee2.Id)
            {
                Status = true;
            }
            return Status;
        }
        public static bool operator !=(Employee employee1, Employee employee2) // had to do in pairs, override !=
        {
            bool Status = false;

            if (employee1.Id != employee2.Id)
            {
                Status = true;
            }
            return Status;
        }

        public override string ToString()  // suggested fix to an error i had
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    
}
