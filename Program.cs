// Задача 27. - HARD необязательная Напишите программу, которая принимает 
// на вход целое или дробное число и выдаёт количество цифр в числе.
// 452 -> 3
// 82 -> 2
// 9,012 ->4
//https://github.com/profimars/C-Seminar5Task27_HARD
int CountIndex(decimal num)
{
    int count = 0;
    bool drobnoe = false;
    if (num == 0 || num == 1)
        return 1;
    while (num % 1 > 0)
    {
        drobnoe = true;
        num = num * 10;
    }
    if (drobnoe == true)
    {
        Console.WriteLine("Цисло num без запятой = " + num);
    }
    while (num > 1)
    {
        num = num / 10;
        count = count + 1;
    }
    return count;
}
Console.WriteLine("Введите целое или дробное число а");
decimal a = Convert.ToDecimal(Console.ReadLine());
decimal rez = CountIndex(a);
Console.WriteLine("Количество цифр в числе = " + rez);
