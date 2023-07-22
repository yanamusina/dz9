// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}


int FunAckermana(int m, int n)
{
    if (m==0) return n+1;
    else if (m>0 && n==0) return FunAckermana(m-1,1);
    else {return FunAckermana (m-1,FunAckermana(m,n-1));}
}
int m =ReadInt("введите число m: ");
int n =ReadInt("введите число n: ");
if (m <0 && n<0)
{
    System.Console.WriteLine("ввели неверный числа");
}
System.Console.WriteLine("вывод: "+ FunAckermana(m,n));

