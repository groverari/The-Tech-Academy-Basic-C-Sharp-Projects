using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class Employee<T> : Person, IQuittable
    {
        public int ID { get; set; }
        public List<T> things { get; set;}

        public override void sayName()
        {
            Console.WriteLine("Name: " + FirstName + " "+ LastName);
        }
        public void Quit()
        {
            Console.WriteLine("I Quit");
        }
        public static bool operator+ (Employee e1, Employee e2)
        {
            if(e1.ID == e2.ID)
            {
                return true;
            }
            return false;
        }
    }
}
