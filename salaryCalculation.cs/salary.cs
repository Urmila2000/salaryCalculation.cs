using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salaryCalculation.cs
{
	public class salary
	{
		public int id=0;
		public string name="";
		public int basicsalary=0;
		public int HRA = 0;
		public int DA = 0;
		public int TotalSalary = 0;
		public int tax = 0;
		public int Inhand = 0;

		public void input()
		{
			Console.WriteLine("Enter the id : ");
			id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your name : ");
			name = Console.ReadLine();
            Console.WriteLine("Enter the Basic salary : ");
			basicsalary = Convert.ToInt32(Console.ReadLine());

			

			HRA = basicsalary * 50 / 100;
			DA= basicsalary * 10 /	100;
			TotalSalary=basicsalary+HRA+ DA;
			tax = TotalSalary * 10 / 100;
			Inhand=TotalSalary-tax;

        }
			public void output()
		{
			Console.WriteLine("Your ID is : "+id);
			Console.WriteLine("Your name  is : " + name);
			Console.WriteLine("Your basicsalary is : " + basicsalary);
			Console.WriteLine("Your Total salary is : " + TotalSalary);
			Console.WriteLine("your inhand salary is : "+Inhand);
		}

	}
}
