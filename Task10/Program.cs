/*Задача необязательная FIZZ BUZZ:
Напишите программу, которая выводит на экран числа от 1 до 100.
При этом вместо чисел, кратных трем, программа должна выводить
слово Fizz, а вместо чисел, кратных пяти — слово Buzz.
Если число кратно пятнадцати, то программа должна выводить
слово FizzBuzz. Задача может показаться очевидной,
но нужно получить наиболее простое и красивое решение.*/

void FillArray(int[] mass) // функция для заполнения массива
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = i + 1;
    }
}
void PrintArray(int[] len)
{
    for (int i = 0; i < len.Length; i++)
    {
        Console.WriteLine(len[i] + " ");
    }
}
int[] nullArray = new int[12]; // создание массива из 100 элементов, заполненного 0
FillArray(nullArray);
PrintArray(nullArray);

Console.WriteLine();

int[] shlepTop = new int[5];
FillArray(shlepTop);
PrintArray(shlepTop);
