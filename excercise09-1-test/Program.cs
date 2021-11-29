using System;

namespace Ex_9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = GetDigFromUser();
            int new_dig = new int();
            int l = num.Length;
            for (int i = 0; i < l; i++)
            {
                if (i == l - 1)
                {
                    if (num.Substring(i, 1) == "I") { new_dig += 1; }
                    if (num.Substring(i, 1) == "V") { new_dig += 5; }
                    if (num.Substring(i, 1) == "X") { new_dig += 10; }
                    if (num.Substring(i, 1) == "L") { new_dig += 50; }
                    if (num.Substring(i, 1) == "C") { new_dig += 100; }
                    if (num.Substring(i, 1) == "D") { new_dig += 500; }
                    if (num.Substring(i, 1) == "M") { new_dig += 1000; }
                }
                else
                {
                    if (num.Substring(i, 1) == "I")
                    {
                        if (num.Substring(i + 1, 1) != "I") { new_dig -= 1; }
                        else { new_dig += 1; }
                    }

                    if (num.Substring(i, 1) == "V")
                    {
                        if (num.Substring(i + 1, 1) != "V" && num.Substring(i + 1, 1) != "I") { new_dig -= 5; }
                        else { new_dig += 5; }
                    }
                    if (num.Substring(i, 1) == "X")
                    {
                        if (num.Substring(i + 1, 1) != "X" &&
                            num.Substring(i + 1, 1) != "V" &&
                            num.Substring(i + 1, 1) != "I") { new_dig -= 10; }
                        else { new_dig += 10; }
                    }
                    if (num.Substring(i, 1) == "L")
                    {
                        if (num.Substring(i + 1, 1) != "L" &&
                            num.Substring(i + 1, 1) != "X" &&
                            num.Substring(i + 1, 1) != "V" &&
                            num.Substring(i + 1, 1) != "I") { new_dig -= 50; }
                        else { new_dig += 50; }
                    }
                    if (num.Substring(i, 1) == "C")
                    {
                        if (num.Substring(i + 1, 1) == "D" || num.Substring(i + 1, 1) == "M") { new_dig -= 100; }
                        else { new_dig += 100; }
                    }
                    if (num.Substring(i, 1) == "D")
                    {
                        if (num.Substring(i + 1, 1) == "M") { new_dig -= 500; }
                        else { new_dig += 500; }
                    }
                    if (num.Substring(i, 1) == "M")
                    { new_dig += 1000; }
                }

                //    //if (i == 0) { Console.WriteLine(num.Substring(l - i - 1,1)); }
                //    //else { Console.WriteLine(num.Substring(l - i - 1, 1)); }


            }
            Console.WriteLine(new_dig);

            //Convert(num);
        }
        static string GetDigFromUser()
        {
            Console.WriteLine("Enter digit");
            string dig = Console.ReadLine();
            return dig;
        }
    }
}