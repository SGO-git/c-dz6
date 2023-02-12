// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
System.Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());
int res = 0;

if (Number >= 100)
{
    while (Number > 999)
    {
        Number = Number / 10;
    }
    res = Number % 10;
    System.Console.WriteLine(res);
}
else
{
    System.Console.WriteLine("wrong number");
}
