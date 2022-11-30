﻿/*В институте биоинформатики по офису передвигается робот. Недавно студенты из группы программистов написали для него программу, 
по которой робот, когда заходит в комнату, считает количество программистов в ней и произносит его вслух: "n программистов".
Для того, чтобы это звучало правильно, для каждого n нужно использовать верное окончание слова.
Напишите программу, считывающую с пользовательского ввода целое число n (неотрицательное), 
выводящее это число в консоль вместе с правильным образом изменённым словом "программист", 
для того, чтобы робот мог нормально общаться с людьми, например: 1 программист, 2 программиста, 5 программистов.
В комнате может быть очень много программистов. Проверьте, что ваша программа правильно обработает все случаи, 
как минимум до 1000 человек.*/

Console.WriteLine("Введите количество программистов в комнате от 1 до 1000");
try 
{
    int count = Convert.ToInt32(Console.ReadLine());
    if (count > 0 && count < 1000)
{
    string ending="";
    switch (count%10)
    {
        case 0: ending="программистов";
        break;
        case 1: ending="программист";
        break;
        case 2: ending="программиста";
        break;
        case 3: ending="программиста";
        break;
        case 4: ending="программиста";
        break;
        case 5: ending="программистов";
        break;
        case 6: ending="программистов";
        break;
        case 7: ending="программистов";
        break;
        case 8: ending="программистов";
        break;
        case 9: ending="программистов";
        break;
    }
    Console.WriteLine($"В комнате {count} {ending}");
}
else
{
    Console.WriteLine("Вы ввели не верное число");
}
}
catch 
{
    Console.WriteLine("Вы  ввели не числовое значение");
}

