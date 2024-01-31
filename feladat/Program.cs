using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat
{
	internal class Program
	{
		static void Main()
		{
			List<int> numbers = new List<int>();

			while (true)
			{

				Console.Write("Kérem adjon meg egy számot (0 a kilépéshez): ");
				string userInput = Console.ReadLine();


				if (!int.TryParse(userInput, out int number))
				{
					Console.WriteLine("Érvénytelen bemenet. Kérjük, csak számokat adjon meg.");
					continue;
				}

				if (number == 0)
					break;


				numbers.Add(number);

				Console.WriteLine("Beírt számok: " + string.Join(", ", numbers));

				//minimum, maximum
				int min = numbers[0];
				int max = numbers[0];
				for(int i  = 0; i < numbers.Count; i++)
				{
					if (numbers[i] < min)
					{
						min = numbers[i];
					}
					if (numbers[i] > max)
					{
						max = numbers[i];
					}
				}
                Console.WriteLine("A listában szereplő legkisebb szám: " + min);
                Console.WriteLine("A listában szereplő legnagyobb szám: " + max);
            }
		}
	}
}
