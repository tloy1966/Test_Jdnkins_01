using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jenkins_Test_01
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Initial...");
			
			string s= "123";
		}
	}

	public class foo1
	{
		public string fun1()
		{
			return nameof(fun1);
		}

		public void fun2()
		{
			Console.WriteLine(nameof(fun2));
		}
	}
}
