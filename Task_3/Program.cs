// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

System.Console.WriteLine("Программа вычисления функции Аккермана\nВведите два целых неотрицательных числа");
int numberM = InputNumber("Введите число m: ");
int numberN = InputNumber("Введите число n: ");
System.Console.WriteLine(CalculateAckermannFunction(numberM, numberN));


//---------------------------Методы--------------------------------------------------------
// Метод, позволяющий ввести в консоль целое число и исключающий ввод других типов значений:
int InputNumber(string invitationText)
{
	int inputNum;
	while (true)
	{
		Console.Write(invitationText);
		string inputStr = Console.ReadLine();
		if (int.TryParse(inputStr, out inputNum))
		{
			if (inputNum >= 0)
			{
				break;
			}
		}
		Console.WriteLine("Введено неверное значение! Введите неотрицательное целое число");
	}
	return inputNum;
}
//-----------------------------------------------------------------------------------------

//Метод, вычисляющий функцию Аккермана:
int CalculateAckermannFunction(int m, int n)
{
	if (m == 0)
	{
		return n = n + 1;
	}
	else if (m > 0 && n == 0)
	{
		return CalculateAckermannFunction(m - 1, 1);
	}
	else if (m > 0 && n > 0)
	{
		return CalculateAckermannFunction(m - 1, CalculateAckermannFunction(m, n - 1));
	}
	return 0;
}


