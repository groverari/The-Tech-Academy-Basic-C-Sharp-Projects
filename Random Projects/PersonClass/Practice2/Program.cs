using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> work = new List<Employee>();
            Employee e1 = new Employee() { FirstName = "Joe", LastName = "Jones", ID = 5 };
            Employee e2 = new Employee() { FirstName = "Joe", LastName = "Smith", ID = 7};
            Employee e3 = new Employee() { FirstName = "John", LastName = "Doe", ID = 4};
            Employee e4 = new Employee() { FirstName = "Anothony", LastName = "Gonzales", ID = 3 };
            Employee e5 = new Employee() { FirstName = "Tiger", LastName = "Cahill", ID = 9};
            Employee e6 = new Employee() { FirstName = "Joe", LastName = "Currier", ID = 1};
            Employee e7 = new Employee() { FirstName = "Ethan", LastName = "Mayer", ID = 5};
            Employee e8 = new Employee() { FirstName = "Tim", LastName = "Smith", ID = 2};
            Employee e9 = new Employee() { FirstName = "Joane", LastName = "Jones", ID = 6};
            Employee e = new Employee() { FirstName = "Kimmy", LastName = "Olson", ID = 8 };
            work.Add(e1);
            work.Add(e2);
            work.Add(e3);
            work.Add(e4);
            work.Add(e5);
            work.Add(e6);
            work.Add(e7);
            work.Add(e8);
            work.Add(e9);
            work.Add(e);
            List<Employee> whoJoe = new List<Employee>();
            foreach(Employee emp in work)
            {
                if (emp.FirstName == "Joe")
                {
                    whoJoe.Add(emp);
                    Console.WriteLine(emp.FirstName);
                }
            }
           

            List<Employee> whoJoeNew = work.Where(x => x.FirstName == "Joe").ToList() ;
            foreach(Employee emp in whoJoeNew)
                Console.WriteLine( emp.FirstName);
            List<Employee> BigIDs = work.Where(x => x.ID > 5).ToList();
            foreach(Employee emp in BigIDs)
                Console.WriteLine(emp.FirstName);
            Console.ReadLine();


        }
       
    }
}
