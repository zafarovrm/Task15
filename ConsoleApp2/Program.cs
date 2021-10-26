using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.ReadKey();
		}
	}

	interface ISeries
	{
		void SetStart(int x);
		int GetNext();
		void Reset();
	}

	class ArithProgression : ISeries
	{
		int difference = 3;
		int x = 0;
		int secondNumber;

		public void SetStart(int x) // устанавливает начальное значение
		{
            Console.WriteLine("Введите начальное значение");
			x = Convert.ToInt32(Console.ReadLine());
		}

		public int GetNext() //возвращает следующее число ряда
		{
			int secondNumber = x + difference;
			return secondNumber;
		}

		public void Reset() //выполняет сброс к начальному значению
		{
			int firstNumber = secondNumber - difference;
		}
	}

	class GeomProgression : ISeries
	{
		int difference = 3;
		int x = 0;

		public void SetStart(int x) // устанавливает начальное значение
		{
			Console.WriteLine("Введите начальное значение");
			x = Convert.ToInt32(Console.ReadLine());
		}

		public int GetNext() //возвращает следующее число ряда
		{
			int secondNumber = x * difference;
			return secondNumber;
		}

		public void Reset() //выполняет сброс к начальному значению
		{
			int firstNumber = x / difference;
		}
	}
}

