using System;
using System.Collections.Generic;
using System.Text;

namespace class_and_object
{
    class Class1
    {
        public static void Main(String[] args)
        {
            //date d6 = new date(25, 1, 2022);
            //employee e2 = new employee(2, "sneha", 3000, Department.Production,d6);

            //Console.WriteLine(e1);
            // Console.WriteLine(e2);
            //Console.WriteLine(employee.count);

            //employee [] array = new employee[5];

            //array[0] = new employee(101, "Mark henry", 60000, Department.IT,d6);
            //date d2 = new date(25, 1, 2022);
            //array[1] = new employee(102, "James Smith", 55000, Department.Sales,d2);
            //date d3 = new date(25, 1, 2022);
            //array[2] = new employee(103, "Robert Smith", 50000, Department.Production,d3);
            //date d4 = new date(25, 1, 2022);
            //array[3] = new employee(104, "Maria Hernande", 50000, Department.Accounts,d4);
            //date d5= new date(25, 1, 2022);
            //array[4] = new employee(105, "Billy Joel", 65000, Department.IT,d5);
            //foreach (employee n in array)
            //{
            //    Console.WriteLine(n + "\n");
            //}
            //employee employee1 = new employee();
            //employee1.gross_salary();
            //employee1 = new manager();
            //employee1.gross_salary();
            //employee.ShowCount();

            //manager m1 = new manager(5000m, 14, 105, "Billy Joel", 3000, Department.IT, d5);
            //m1.gross_salary();
            //e2.gross_salary();
            //Console.WriteLine(m1);
            
            circle sq = new circle(10,"red");
            sq.showcolor();
            Console.WriteLine("Square area: "+sq.Area());
            cylinder c = new cylinder(10,"blue",5);
            Console.WriteLine("cylinder area: " + c.Area());
            c.showcolor();

        }
    }
}
