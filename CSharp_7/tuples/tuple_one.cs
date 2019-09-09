using System;

namespace tuples
{
    public class Tuple_One
    {
        private Employee employee = new Employee {
            FirstName = "Tandi",
            LastName = "Sunarto"
        };
        private Manager manager = new Manager {
            FirstName = "Suyenti",
            LastName = "Sunarto"
        };

        public void Run()
        {
            (string emp_fname, string emp_lname) = employee.GetName();
            (string emp_x, string emp_y) = employee;
            Console.WriteLine($"Name : {emp_fname} {emp_lname}");
            Console.WriteLine($"Name : {emp_x} {emp_y}");
            
            (string mgr_fname, string mgr_lname) = manager.GetName();
            (string mgr_x, string mgr_y) = manager;
            Console.WriteLine($"Name : {mgr_fname} {mgr_lname}");
            Console.WriteLine($"Name : {mgr_x} {mgr_y}");
        }
    }

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public (string, string) GetName()
        {
            var emp = (FirstName, LastName);
            return emp;
        }

        public void Deconstruct(out string fname, out string lname)
        {
            fname = FirstName;
            lname = LastName;
        }
    }

    public class Manager
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public (string, string) GetName()
        {
            var mgr = (FirstName, LastName);
            return mgr;
        }
    }

    public static class Extension
    {
        public static void Deconstruct(this Manager mgr, out string fname, out string lname)
        {
            fname = mgr.FirstName;
            lname = mgr.LastName;
        }
    }
}