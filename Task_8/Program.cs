Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;
string  answer_1 = (" - Данное число четное ");

while (count <= n)
{
   if (count % 2 == 0) 
   {
   Console.Write(count);
   Console.WriteLine(answer_1);
   }

   count++;
}
