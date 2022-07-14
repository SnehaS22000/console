using System;
using System.Collections.Generic;
using System.Text;

namespace class_and_object
{
    abstract public class shape
    {    
        public abstract double Area();
        public string color { get; set;}
        public shape( string color)
        {
            this.color = color;
        }
        public void showcolor()
        {
            Console.WriteLine("the colour is "+color);
        }
    }

    public class circle: shape
    {
        public  double Radius { get;set; }
        public circle(double radius,string color):base(color)
        {
            Radius = radius;
           
        }
        public override double Area()
        {
            double area_circle= (2* Math.PI * Radius * Radius);
            return area_circle;
        }

    }
    public class cylinder:circle
    {
        public double Height { get; set; }
        public cylinder(double height,string color, double Radius) :base(Radius,color)
   
        {
            Height = height;
           
        }
        public override double Area()
        {
            double area_cylinder=(2*Math.PI*Height)+ (2 * Math.PI * Radius*Radius);
            return area_cylinder;
        }

    }
}
