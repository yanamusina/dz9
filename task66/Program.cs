// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int SumNumbers(int M, int N)
{
    if (M == N) return M;
   return N +SumNumbers(M,N-1);
}

int M = ReadInt("введите первое число");
int N = ReadInt("введите второе число: ");
if (M > N)
{
    System.Console.WriteLine("ввели неправильный диапазон");
}
System.Console.WriteLine("Сумма: "+ SumNumbers(M,N));