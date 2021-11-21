using System;

namespace Exercise04Chess
{
  
    class Program
    {
             
        static void Main(string[] args)
        {

            // Ввод данных с клавиатуры
            static string GetMoveFromUser()
            {
                Console.WriteLine("Enter move ");
                string chees_move = Console.ReadLine();
                return chees_move;
            }

            // Запуск проверки хода
            string chees_move = GetMoveFromUser();
            if (chees_move.Length == 5) // проверяем, что введено 5 символов. если меньше или больше, то ошибка
            {
                char[] chess_move_array = chees_move.ToCharArray(); // создаем массив char
                string start_move_letter = Convert.ToString(chess_move_array[0]).ToUpper(); // присваиваем переменной значения из массива и конвертируем их 
                string start_move_number = Convert.ToString(chess_move_array[1]);           // присваиваем переменной значения из массива и конвертируем их
                string finish_move_letter = Convert.ToString(chess_move_array[3]).ToUpper();// присваиваем переменной значения из массива и конвертируем их
                string finish_move_number = Convert.ToString(chess_move_array[4]);          // присваиваем переменной значения из массива и конвертируем их

                char start_move_letter_char = Convert.ToChar(start_move_letter);            // cоздаем переменную char и int, чтобы использовать IF ELSE
                char finish_move_letter_char = Convert.ToChar(finish_move_letter);          // cоздаем переменную char и int, чтобы использовать IF ELSE
                int start_move_number_int = Convert.ToInt32(start_move_number);             // cоздаем переменную char и int, чтобы использовать IF ELSE
                int finish_move_number_int = Convert.ToInt32(finish_move_number);           // cоздаем переменную char и int, чтобы использовать IF ELSE
                int start_move_letter_int = start_move_letter_char - 64;
                int finish_move_letter_int = finish_move_letter_char - 64;

                // Далее сравниваем - ЕСЛИ буква одинаковая и цифры между 1 и 8, то ход ВЕРНЫЙ
                if (start_move_letter_int == finish_move_letter_int && start_move_number_int <= 8 && start_move_number_int >= 1)
                {
                    Console.WriteLine($"Move {chees_move} is correct and it's a row move");
                }

                // Далее сравниваем - ЕСЛИ цифра одинаковая и цифры между 1 и 8, то ход ВЕРНЫЙ (надо понять как проверить на БУКВЫ
                else if (start_move_number_int == finish_move_number_int && start_move_letter_int <= 8 && finish_move_letter_int >= 1)
                {
                    Console.WriteLine($"Move {chees_move} is correct and it's a column move");
                }

                // далее сравниваем диагональ
                // 
                else if (
                    start_move_number_int == start_move_letter_int &&                     // число начала букв = числам
                    start_move_number_int == finish_move_number_int &&                    // конец начала букв = числам , то диагональ
                    start_move_number_int <= 8 && start_move_number_int >= 1 &&           // проверяем диапазон 1-8
                    finish_move_number_int <= 8 && finish_move_number_int >= 1)           // проверяем диапазон 1-8
                {
                    Console.WriteLine($"Move {chees_move} is correct and it's dioganal move");
                }
                else
                {
                    Console.WriteLine("Move is not correct for Queen");
                }
                
            }
            else
            {
                Console.WriteLine("Move is not correct");
            }
        }
    }
}