using System;
using System.Collections.Generic;
using System.Text;

namespace class_and_object
{
    public enum Department { IT, Production, Sales, Civil, Accounts }//labeled integer
    class employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public decimal gross_salary1 { get; set; }
        public Department dept { get; set; }
        public static int count { get; set; }
        public date doj { get; set; }


        // default constructor
        public employee()
        {
            Id = 10001;
            Name = "bill Gates";
            Salary = 3000;
            dept = Department.IT;
            date d1 = new date();
            doj = d1;
            count++;
        }
        // static constructor
        static employee()
        {
            count = 0;
            Console.WriteLine(" This is Static Constructor :");
        }
        // parametersied constructor
        public employee(int id, string name, decimal sal, Department dept,date dofj)
        {
            Id = id;
            Name = name;
            Salary = sal;
            this.dept = dept;
            doj = dofj;
            count++;
        }

        public static void ShowCount()
        {
            Console.WriteLine(count);
        }

        
        public override string ToString()
        {
            return "Id : " + Id + Name + " " + Salary + " Department :" + dept + " "  + doj;
        }

        public virtual void gross_salary()
        {
            
            //gross_salary1 = (salary + 500+ (70 / 100) * salary);// ((70/100)* salary)) +(( 15/100) * salary));
            decimal gross_salary2=(Salary + 500 + 0.7m * Salary + 0.15m * Salary);
            Console.WriteLine("gross salary is "+gross_salary2);       }
        
    }
}
