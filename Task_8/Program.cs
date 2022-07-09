int n = Console.ReadLine();
int count = 1;
string  answer_1 = (" - Данное число четное ");
string  answer_2 = (" - Данное число нечетное ");

Console.Write("Введите число N: ");

while (count < n)
{
   if (count % 2 == 0) 
   {
   Console.Write(count);
   Console.WriteLine(answer_1);
   }
   else
   {
   Console.Write(count);
   Console.WriteLine(answer_2);
   }

   count++;
}
