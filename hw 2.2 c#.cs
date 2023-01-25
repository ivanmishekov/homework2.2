/*
Задача 2: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int InputInt(string mess)
{
    System.Console.Write($"{mess}");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

int Solution(int num)
{
    if (num > 1000)
    {
        while (num > 1000)
        {
            num = num / 10;
        }
    }
    num = num % 10;
    return num;
}

int numb = InputInt("Введите число > ");
if ( numb < 99)
{
    System.Console.WriteLine($"У числа {numb} нет третьей цифры");
}
else
{
    int resultt = Solution(numb);
    System.Console.WriteLine(resultt);
}