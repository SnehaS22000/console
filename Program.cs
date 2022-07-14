// C# Program to illustrate calling of
// parameterized constructor.
using System;
namespace class_and_object
{

	class names
	{
		String firstname;
		String secondname;
		int marks;
		public names(String firstname,String secondname, int marks)
		{
			this.firstname = firstname;
			this.secondname = secondname;
			this.marks = marks;
		}

		public override String ToString()
        {
			return " my name is " +firstname +
							"  " +secondname + " my mark is " + marks;
		}
		//public static void Main(String [] args)
		//{
		//	names name1 = new names("sneha","soundar", 80);
  //          Console.WriteLine(name1);
		//}
	}
}
