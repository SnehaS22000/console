using System;
using System.Collections.Generic;
using System.Text;

namespace class_and_object
{
    class manager:employee
    {
        public int salesqty { get; set; }
        public decimal commision { get; set; }
        public decimal gross_sal{ get; set; }
        public manager():base()
        {
            commision = 5000;
            salesqty = 14;
        }
        public manager(decimal commision,int salesqty,int id,string name,decimal sal,Department dept,date dt) : base()
        {
            this.commision = commision;
            this.salesqty = salesqty;
        }
        public override  void gross_salary()
        {
            
            decimal gross_sal1 = commision+salesqty+(Salary + 500 + 0.7m * Salary+0.15m*Salary);// ((70/100)* salary)) +(( 15/100) * salary));
            Console.WriteLine("gross salary is "+gross_sal1);
        }
        public override string ToString()
        {
            return "Id : " + Id + Name + " " + Salary + " Department :" + dept + " " + " " + doj+" "+commision+" "+" "+salesqty;
        }
    }
    }
