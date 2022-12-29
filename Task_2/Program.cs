// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int numberM = InputNumber("Введите число M: ");
int numberN = InputNumber("Введите число N: ");
FindMInAndMAxNum(numberM, numberN, out int min, out int max);
FindNaturalNumbersFromMToN(min, max);
System.Console.WriteLine();
System.Console.WriteLine(CalculateSumNaturalNumbersFromMToN(min, max));


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

// Метод, который выводит все натуральные числа от M до N
void FindNaturalNumbersFromMToN(int numMin, int numMax)
{
	if (numMax < numMin) return;
	FindNaturalNumbersFromMToN(numMin, numMax - 1);
	Console.Write($"{numMax}; ");
}
//-------------------------------------------------------------

//Метод нахождения большего и меньшего из двух чисел:
void FindMInAndMAxNum(int numOne, int numTwo, out int min, out int max)
{
	if (numOne < numTwo)
	{
		min = numOne;
		max = numTwo;
	}
	else
	{
		min = numTwo;
		max = numOne;
	}
}
//-------------------------------------------------------------

// Метод, выводящий сумму натуральных элементов в промежутке от M до N
int CalculateSumNaturalNumbersFromMToN(int numMin, int numMax)
{
	if (numMax >= numMin)
	{
		return numMax + CalculateSumNaturalNumbersFromMToN(numMin, numMax - 1);
	}
	return 0;
}