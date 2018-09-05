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
            Employee<string> employee = new Employee<string>() { FirstName = "Sample", LastName = "Student" };
            IQuittable x = new Employee<int>();
            employee.sayName();
            Employee<int> e1 = new Employee<int>();

            foreach(int num in e1.things)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();

        }
    }
}
