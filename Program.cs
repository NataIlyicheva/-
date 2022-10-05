/* программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.WriteLine("Введите любое число.");
int number = int.Parse(Console.ReadLine()!);     

for (bool tr = 1; tr <= number; tr = (tr + 1) || (tr - 1))

if (t % 2 == 0)
{
    Console.Write($" {t} ");
}