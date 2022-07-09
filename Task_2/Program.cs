// Программа с данными: a = 5, b = 7
/*int a = 5, b = 7, max = a;
if (a >= max) max = a;
if (b >= max) max = b;
Console.Write("max = ");
Console.WriteLine(max);
*/

// Программа с данными: a = 2, b = 10
/*int a = 2, b = 10, max = a;
if (a >= max) max = a;
if (b >= max) max = b;
Console.Write("max = ");
Console.WriteLine(max);
*/

// Программа с данными: a = -9, b = -3
/*int a = -9, b = -3, max = a;
if (a >= max) max = a;
if (b >= max) max = b;
Console.Write("max = ");
Console.WriteLine(max);
*/

//Программа с данными, которые вводит пользователь
/*
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if(a > b)
{
Console.Write("Максимальное из двух чисел = ");
Console.WriteLine(a);
}
if (a < b)
{
Console.Write("Максимальное из двух чисел = ");
Console.WriteLine(b); 
}
if (a == b)
{
Console.Write("Максимального числа нет, так как введены одинаковые по значению числа, а именно введено число: ");
Console.WriteLine(b); 
}
*/

//Программа с данными, которые генерируются компьютером
/*
int numberA = new Random().Next(-100, 100);
Console.Write("Первое сгенерированное компьютером число из диапазаона от -100 до 100: ");
Console.WriteLine(numberA);

int numberB = new Random().Next(-100, 100);
Console.Write("Второе сгенерированное компьютером число из диапазаона от -100 до 100: ");
Console.WriteLine(numberB);

if(numberA > numberB)
{
Console.Write("Максимальное из двух сгенерированных чисел = ");
Console.WriteLine(numberA);
}
if (numberA < numberB)
{
Console.Write("Максимальное из двух сгенерированных чисел = ");
Console.WriteLine(numberB); 
}
if (numberA == numberB)
{
Console.Write("Максимального числа нет, так как сгенерированы одинаковые по значению числа, а именно число: ");
Console.WriteLine(numberB); 
}
*/