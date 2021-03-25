using System;

namespace Methods
{
	class Program
	{
		static void Main(string[] args)
		{
			StartProcess();
			int count = 3;
			StartAnotherProcess(count);
			Console.WriteLine(count);
			StartAnotherProcess(2, "Обучение");
			StartAnotherProcess(name: "Практика", count: 1);

			StartProcessIn(count);
			Console.WriteLine($"Счёт до запуска процесса: {count}");
			StartProcessWithModificators(ref count, out string name);
			Console.WriteLine($"Счёт: {count}, Название: {name}");
			int a = 3;
			int b = 5;
			int result = MakeAddition(a, b);
			Console.WriteLine("{0} + {1} = {2} ", a, b, result);
			Console.WriteLine($"{a} + {b} = {result}");

			int num1 = 8;
			int num2 = 6;
			CheckCondition(num1, num2);
			string logicalResult = (num1 > num2 ? "больше" : "меньше или равно");
			Console.WriteLine($"Число {num2} {logicalResult} числа {num1}");
		}

		static void CheckCondition(int num1, int num2)
		{
			if ((num1 > num2) && (num1 - num2 > 1))
			{
				Console.WriteLine($"Число {num1} сильно больше числа {num2}");
			}
			else if (num1 > num2)
			{
				Console.WriteLine($"Число {num1} > числа {num2}");
			}
			
			else if (num1 == num2)
			{
				Console.WriteLine($"Число {num1} равно числу {num2}");
			}
			else if (num1 < num2 || num1 == 6) 
			{
				Console.WriteLine("Специальное условие");
			}
			else
			{
				Console.WriteLine($"Число {num2} > числа {num1}");
			}
		}

		static public void StartProcess()
		{
			Console.WriteLine("Вызван метод без параметров");
			return;
		}

		static void StartAnotherProcess(int count, string name = "Процесс")
		{
			count--;
			Console.WriteLine($"Процесс	запущен {name}, счёт {count}");
		}

		static void StartProcessIn(in int count)
		{
			int count2 = count;
			count2--;
			Console.WriteLine($"Параметр передан по ссылке {count}, count2: {count2}");
		}

		static bool StartProcessWithModificators(ref int count, out string name)
		{
			count--;

			name = "Другой процесс";

			return count > 0;
		}

		static string StartProc(out bool res)
		{
			res = false;
			return "";
		}

		static private int MakeAddition(int num1, int num2)
		{
			int sum = num1 + num2;
			return sum;
		}
	}
}
