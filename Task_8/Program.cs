Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;
string  answer_1 = (" - Данное число четное ");
string  answer_2 = (" - Данное число нечетное ");

while (count <= n)
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
