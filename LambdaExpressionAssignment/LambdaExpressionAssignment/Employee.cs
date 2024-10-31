using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionAssignment
{
    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Override ToString() for easier printing
        public override string ToString()
        {
            return $"{Id}: {FirstName} {LastName}"; // Format the output string
        }
    }
}
