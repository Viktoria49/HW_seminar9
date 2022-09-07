// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.WriteLine("Введите число M: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int endNumber = Convert.ToInt32(Console.ReadLine());


int SumNaturalNumber (int num1, int num2)
{
    if (num1 > num2)
        return num1 + SumNaturalNumber (num1 - 1, num2);
    else if (num1 < num2)
        return num1 + SumNaturalNumber (num1 + 1, num2);
    else return num1;
}
int sum = SumNaturalNumber (firstNumber, endNumber);
Console.WriteLine ($"Сумма элементов от {firstNumber} до {endNumber} = {sum}");