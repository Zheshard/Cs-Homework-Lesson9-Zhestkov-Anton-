// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int numberN = InputNumber("Введите число N: ");
PrintNaturalNumbersFromNTo1(numberN);


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
			break;
		}
		Console.WriteLine("Введено неверное значение!");
	}
	return inputNum;
}
//-----------------------------------------------------------------------------------------

// Метод, который выводит все натуральные числа от N до 1
void PrintNaturalNumbersFromNTo1(int numN)
{
	if (numN < 1) return;
	Console.Write($"{numN}; ");
	PrintNaturalNumbersFromNTo1(numN - 1);
}
//-------------------------------------------------------------

