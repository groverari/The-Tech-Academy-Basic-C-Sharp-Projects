﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class Employee : Person, IQuittable
    {
        public int ID { get; set; }

        public override void sayName()
        {
            Console.WriteLine("Name: " + FirstName + " "+ LastName);
        }
        public void Quit()
        {

        }

    }
}
