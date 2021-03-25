using System;

namespace CSharpBasics
{
	class Program
	{
		static void Main(string[] args)
		{
			// Целочисленные значения
			int a = 5;
			Console.WriteLine(a);
			a = 3 + 5;
			Console.WriteLine(a);
			int b = a;
			Console.WriteLine(b);

			int sum = a + b;
			int dif = a - b;
			int mul = a * b;
			var div = a / (double) b;

			int f = a % b;

			Console.WriteLine("Сумма " + sum);
			Console.WriteLine("Разность " + dif);
			Console.WriteLine("Произведение " + mul);
			Console.WriteLine("Частное " + div);
			Console.WriteLine("Остаток " + f);

			a++; // a = a + 1;
			Console.WriteLine(a);
			b--; // b = b - 1;
			Console.WriteLine(b);
			a += 3; // a + 3;
			Console.WriteLine("a: " + a);
			b -= 2; // b - 2;
			Console.WriteLine("b: " + b);
			// Строковые значения
			string hello = "Hello";
			Console.WriteLine(hello);
			string userName = "Usser";
			Console.WriteLine(userName);

			// Так делать нельзя.
			//string имяПользователя = "Пользователь";
			//Console.WriteLine(имяПользователя);

			// Вещественные числа
			double d = 3, dd = 1;
			Console.WriteLine(d);

			char charasterValue = 'a';
			Console.WriteLine(charasterValue);

			// Булевское значение
			bool ba = true;
			Console.WriteLine(ba);
			bool bb = false;
			Console.WriteLine(bb);

			// Объектный тип
			object someObject = 5;
			Console.WriteLine(someObject);
			string intStringValue = a.ToString();

			var intVar = 5;
			var doubleVal = 5.0;
			float floatVal = 5.0f;
			var stringVar = "Name";

			double anotherDouble = 5;

			int x = 5;
			string s = "Hello";
			object o = x;
			int y = (int)o;
			object o2 = o;
			double z = 6.0;
			Console.WriteLine(o);
			Console.WriteLine(o2);
		}
	}
}
