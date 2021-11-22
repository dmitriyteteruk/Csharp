using System;
using System.Collections;

namespace excercise07_random_car_plate_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }; // создаем массив чисел, состоящий из 10 чисел
            char[] letters = "АВСЕНКМОРТХY".ToCharArray();    // создаем массив с входящими в него символами и переводим его в массив символов
            ArrayList plateNumber = new ArrayList();          // создаем массив с произвольной длиной 
            plateNumber.Add(letters[RandLetter(letters)]);    // добавляем в массив букву, которую получаем из случайного набора - параметры - 'letters'
            plateNumber.Add(numbers[RandNumber(numbers)]);    // добавляем в массив число, которое получаем из случайного набора  - параметры - 'numbers'
            plateNumber.Add(numbers[RandNumber(numbers)]);    // добавляем в массив число, которое получаем из случайного набора  - параметры - 'numbers'
            plateNumber.Add(numbers[RandNumber(numbers)]);    // добавляем в массив число, которое получаем из случайного набора  - параметры - 'numbers'
            plateNumber.Add(letters[RandLetter(letters)]);    // добавляем в массив букву, которую получаем из случайного набора  - параметры - 'letters'
            plateNumber.Add(letters[RandLetter(letters)]);    // добавляем в массив букву, которую получаем из случайного набора  - параметры - 'letters'
            foreach (object symbol in plateNumber)
            {
                Console.Write(symbol); //  выводим номер в консоль  
            }

            // сообщение пользователю
            Console.WriteLine("\n\n\nPress enter to close the program.");   // сообщение пользователю
            Console.ReadKey();

        }
        
        // метод генерации случайного числа
        static int RandNumber(int[] number)
        {
            Random random = new Random();
            int RandomNumberFromArray = random.Next(0, number.Length);
            return number[RandomNumberFromArray];
        }
        // метод генерации случайного символа из доступных
        static int RandLetter(char[] letter)    // метод с параметром в видео массива letter
        {
            Random random = new Random();
            int RandomLetterFromArray = random.Next(0, letter.Length);
            return RandomLetterFromArray;
        }
    }
}