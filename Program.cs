// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""

/*
int M = 4;
int N = 15;

string Natural(int M, int N)
{
    if (M<=N) return $"{M}"+"; "+ Natural(M+1,N);
    else return string.Empty;
}
Console.WriteLine(Natural(M,N));
*/


// Задача 66: Задайте значения M и N.
//  Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*
int M = 4;
int N = 15;
 int Sum (int M, int N)
 {
    if (M == N) return M;
    return (M + Sum(M + 1, N));
 }
 Console.WriteLine(Sum(M,N));
 */


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29


// функция Аккермана
int n = 3;
int m = 2;
int Akkerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akkerman(n - 1, 1);
    else
      return Akkerman(n - 1, Akkerman(n, m - 1));
}
Console.WriteLine(Akkerman(n,m));

