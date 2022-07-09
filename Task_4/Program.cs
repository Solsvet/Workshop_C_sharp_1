// Программа с данными: a = 2, b = 3, c = 7
/*int a = 2, b = 3, c = 7, max = a;
if (a >= max) max = a;
if (b >= max) max = b;
if (c >= max) max = c;
Console.Write("max = ");
Console.WriteLine(max);*/

// Программа с данными: a = 44, b = 5, c = 78
/*int a = 44, b = 5, c = 78, max = a;
if (a >= max) max = a;
if (b >= max) max = b;
if (c >= max) max = c;
Console.Write("max = ");
Console.WriteLine(max);*/

// Программа с данными: a = 22, b = 3, c = 9
/*
int a = 22, b = 3, c = 9, max = a;
if (a >= max) max = a;
if (b >= max) max = b;
if (c >= max) max = c;
Console.Write("max = ");
Console.WriteLine(max);
*/

//Программа с данными, которые вводит пользователь
/*
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if (a >= max) max = a;
if (b >= max) max = b;
if (c >= max) max = c;
Console.Write("Максимальное число из всех введенных чисел = ");
Console.WriteLine(max);
*/


//Программа с данными, которые генерируются компьютером
int numberA = new Random().Next(-100, 100);
Console.Write("Первое сгенерированное компьютером число из диапазаона от -100 до 100: ");
Console.WriteLine(numberA);

int numberB = new Random().Next(-100, 100);
Console.Write("Второе сгенерированное компьютером число из диапазаона от -100 до 100: ");
Console.WriteLine(numberB);

int numberC = new Random().Next(-100, 100);
Console.Write("Третье сгенерированное компьютером число из диапазаона от -100 до 100: ");
Console.WriteLine(numberC);

int max = numberA;

if (numberA >= max) max = numberA;
if (numberB >= max) max = numberB;
if (numberC >= max) max = numberC;
Console.Write("Максимальное число из всех сгененрированных чисел = ");
Console.WriteLine(max);
