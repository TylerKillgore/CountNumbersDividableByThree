using System;


namespace Counting2
{
	class MainClass
	{
		public static void Main(string[] args)
		{

			Console.WriteLine("The numbers dividable by 5 without remainder from {0} to {1} are: ", 1, 100);
			int count = 0;
			for (int i = 1; i <= 100; i++)
			{
				if (i % 3 == 0)
				{

					Console.WriteLine(i);
					count++;
				}
			}
			Console.WriteLine("The total numbers dividable by 3 is: " + count.ToString());
		}
	}
}
