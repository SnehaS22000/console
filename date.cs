using System;
using System.Collections.Generic;
using System.Text;

namespace class_and_object
{
    class date
    {
        public  int day { get; set; }
        public int month { get; set;}
        public  int year { get; set; }
        public date()
        {
            day = 04;
            month = 07;
            year = 2022;
        }
        public date(int date,int month,int year)
        {
            this.day = date;
            this.month = month;
            this.year = year;
        }
        public override string ToString()
        {
            return day + " " + month + " " + year;
        }
    }
    
}
