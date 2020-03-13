using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTestingMaster
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("This should be in the master string");

			while (0 == 0)
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.Write("No.");
				System.Threading.Thread.Sleep(5);
			}
		}
	}
}
