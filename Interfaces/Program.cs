using System;

namespace Interfaces
{
    class Program
    {
        //interfaces are not using with new.
        static void Main(string[] args)
        {
            /*
            IPersonManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();
            IPersonManager employeeManager = new EmployeeManager();
            employeeManager.Add();
            employeeManager.Update();
            */

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new CustomerManager()); // new CustomerManager() => IPersonManager
            projectManager.Add(new EmployeeManager());// new EmployeeManager() => IPersonManager
            projectManager.Add(new InternManager()); // new InternManager() => IPersonManager

        }
    }
    // class => inheritance || interface => implements
    class PersonManager
    {
        // Implemented operation
        public void Add()
        {
            Console.WriteLine("Added.");
        }
    }
    interface IPersonManager
    {
        void Add(); //public(default)
        void Update();
    }
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Customer added.");
        }

        public void Update()
        {
            Console.WriteLine("Customer updated.");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            // codes about the empleyee adding process.
            Console.WriteLine("Employee added.");
        }

        public void Update()
        {
            Console.WriteLine("Employee updated.");
        }
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Intern updated.");
        }

        public void Update()
        {
            Console.WriteLine("Intern updated.");
        }
    }
    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add(); //GENERAL MANAGEMENT
        }
        public void Update(IPersonManager personManager)
        {
            personManager.Update(); //GENERAL MANAGEMENT
        }
    }
}
