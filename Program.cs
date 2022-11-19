//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write ("Введите число от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine ());
  if (num < 6)
{
       Console.WriteLine($"{num} - 'этот день не выходной,рабочий день");
   }
else if (num == 6 )
  {
    Console.WriteLine($"{num} - Выходной");
  } 
  else if (num == 7)
  {
    Console.WriteLine($"{num} - Выходной");
  }
  