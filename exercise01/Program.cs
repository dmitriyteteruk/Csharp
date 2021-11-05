﻿/* Задание №1
Напишите программу, позволяющию вывести все простые числа в диапазоне до заданного.
Возьмем диапазон от N до M */

using System;

class Program
{
    static void Main(string[] args)
    {
        // выводим приветствие пользователю
        Console.WriteLine("Добро пожаловать в программу поиска простых чисел из заданного диапазона!");

        // просим пользователя ввести начальное значение диапазона
        Console.WriteLine("Введите начальное число диапазона X");
        // объявляем переменую x, передаем ей значение из строки, которую ввел пользователь.
        int x = Int32.Parse(Console.ReadLine());

        // просим пользователя ввести начальное значение диапазона
        Console.WriteLine("Введите конечное число диапазона Y");
        // объявляем переменую y, передаем ей значение из строки, которую ввел пользователь.
        int y = Int32.Parse(Console.ReadLine());

        // объявлем переменную b - значение true or false
        bool b;

        // запускаем цикл поиска простых чисел
        if (x < y)  // если x меньше y
        {
            for (int i = x; i <= y; i++)  // цикл for (объявлем переменную i = x; проверяем условие что i <= y; прибавляем счетчик)
            {                                   // вложенный цикл
                b = true;                       // пока условие "x < y" верное
                for (int j = 2; j < i; j++)     // для цикла for (объявлем переменную j = 2; проверяем условие что j < i; прибавляем счетчик j++)                            
                {                                   // вложенный цикл
                    if (i % j == 0)                 // если  остаток от деления "i % j" равен 0, то есть делится без остатка
                    {
                        b = false;                  // то b принимает значение false
                        break;                      // и цикл прерывается, то есть число не простое
                    }
                }
                if (b)                          // в противом случае пишем b
                    Console.WriteLine(i + " простое число"); // и добавляем текст "простое число".
            }
        }
        Console.WriteLine("Для закрытия окна программы нажимите любую клавишу.");
        Console.ReadKey();        // ожидание нажатия клавишы, чтобы оконо не закрылось.
    }
}