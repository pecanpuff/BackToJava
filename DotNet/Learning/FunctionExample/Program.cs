﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateExample
{
	class Program
	{
		delegate void Printer();
		static void Main()
		{
			List<Printer> printers = new List<Printer>();
			for (int i = 0; i < 10; i++)
			{
				printers.Add(delegate { Console.WriteLine(i); });
			}

			foreach (var printer in printers)
			{
				printer();
			}
			Console.ReadKey();
		}
	}
	
}

