using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summator {
	class Program {
		static void Main(string[] args) {
			while (true) {
				int sum = 0;

				Console.WriteLine("Введите число");
				int number = int.Parse(Console.ReadLine());
				sum = sum + number;

				Console.WriteLine("Сумма всех введенных чисел " + sum);
				Console.WriteLine();
			}
		}
	}
}
