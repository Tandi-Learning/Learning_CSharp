using System;

namespace tuples
{
    public class Tuple_One
    {
        private Employee employee = new Employee {
            FirstName = "Tandi",
            LastName = "Sunarto"
        };

        public void Run()
        {
            (string fname, string lname) = employee.GetName();
            (string fname1, string lname1) = employee;
            Console.WriteLine($"Name : {fname} {lname}");
            Console.WriteLine($"Name : {fname1} {lname1}");
        }
    }

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public (string, string) GetName()
        {
            return (FirstName, LastName);
        }

        public void Deconstruct(out string fname, out string lname)
        {
            fname = FirstName;
            lname = LastName;
        }
    }
}