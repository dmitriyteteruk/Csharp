using System;


namespace Exercise04Chess
{
    enum move_letters
    {
        A = 1,
        B = 1,
        C = 1,
        D = 1,
        E = 1,
        F = 1,
        G = 1,
        H = 1
    }

    class Program
    {
        static void Main(string[] args)
        {
            string chees_move = GetMoveFromUser();
            if (chees_move.Length == 5)
            {
                char[] chess_move_array = chees_move.ToCharArray();
                string start_move_letter = Convert.ToString(chess_move_array[0]).ToUpper();
                string start_move_number = Convert.ToString(chess_move_array[1]);
                string finish_move_letter = Convert.ToString(chess_move_array[3]).ToUpper();
                string finish_move_number = Convert.ToString(chess_move_array[4]);

                char start_move_letter_char = Convert.ToChar(start_move_letter);
                char finish_move_letter_char = Convert.ToChar(finish_move_letter);
                int start_move_number_int = Convert.ToInt32(start_move_number);
                int finish_move_number_int = Convert.ToInt32(finish_move_number);

                if (start_move_letter_char == finish_move_letter_char && start_move_number_int <= 8 || start_move_number_int >= 1)
                {
                    Console.WriteLine($"Move {chees_move} is correct");
                }
                else if (start_move_number_int == finish_move_number_int && start_move_number_int <= 8 || start_move_number_int >= 1)
                {
                    Console.WriteLine($"Move {chees_move} is correct");
                }
                else if (start_move_letter_char == 0) ;

            }
            else
            {
                Console.WriteLine("error");
            }
            static string GetMoveFromUser()
            {
                Console.WriteLine("Enter move ");
                string chees_move = Console.ReadLine();
                return chees_move;
            }
        }
    }
}