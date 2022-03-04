// See https://aka.ms/new-console-template for more information
using System;
namespace CAU5
{
	public class Program
	{
		public static void Main()
		{
			ThucPham tp1 = new ThucPham("1","Mi goi",70000,new DateTime(2021,9,2),new DateTime(2022,9,5));
			ThucPham tp2 = new ThucPham("2","Gao",1500000,new DateTime(2021,7,1),new DateTime(2022,2,14));
			ThucPham tp3 = new ThucPham("3","Nuoc",200000,new DateTime(2021,2,24),new DateTime(2021,5,12));
			
			Console.WriteLine("MA HANG        TEN HANG           DON GIA                          NSX                      HSD                          GHI CHU ");
			Console.WriteLine(tp1.ToString());
			Console.WriteLine(tp2.ToString());
			Console.WriteLine(tp3.ToString());
		}
	}
}

