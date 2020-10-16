using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Добро пожаловать в програму в якій можна перевіряти \n"
                             + " текст на паліндромність і також багато цікавого\n");
            while (true)
            {
                Console.WriteLine("------------------------------------------------------\n "
                              + "Виберіть що вам потрібно виконати:\n"
                              + "А - Провірка Цифр на паліндромність;\n"
                              + "B - Перевести Цифри в Реверс;\n"
                              + "C - Провірка Текста на паліндромність;\n"
                              + "Q - Вихід;\n");

                var input = Console.ReadKey();

                switch (input.Key)
                {
                    
                   case ConsoleKey.A:
                            Console.Write("\n Перевірка Числ на паліндромність  \n"
                                 + "--------------------------------------\n "
                                 + "Вкажіть Числа : ");

                        try
                        {
                            var tf = Solution.IsPalindrome(Convert.ToInt32(Console.ReadLine()));
                            if (tf == true)
                                Console.WriteLine(" Ці Числа є паліндромними.\n");
                            else
                                Console.WriteLine(" Ці Числа не є паліндромними.\n");

                            Console.Read();
                        }
                        catch(FormatException)
                        {
                            Console.Write("\nВи ввели не верний формат!\n\n");
                        }

                            break;
                        

                    case ConsoleKey.B:
                        Console.Write("\n Перевести Цифри в Реверс \n"
                                      + "-------------------------------\n "
                                      + "Вкажіть Цифри : ");
                        try
                        {
                            var Export = Solution.Reverse(int.Parse(Console.ReadLine()));
                            checked
                            {
                                Console.WriteLine("Цифри в реверсе : " + Export + "\n");
                            }
                        }
                        catch (OverflowException)
                        {
                            Console.Write("\nПереповненя\n\n");
                        }
                        catch (FormatException)
                        {
                            Console.Write("\nВи ввели не верний формат!\n\n");
                        }
                        Console.ReadLine();
                        break;

                    case ConsoleKey.C:
                        Console.Write("\n Перевірка текста на паліндромність  \n"
                                + "--------------------------------------\n "
                                + "Вкажіть текст : ");
                        var Expo = Solution.IsFilter(Console.ReadLine());

                        if (Expo == true)
                            Console.WriteLine(" Цей текст є паліндромним.\n");
                        else
                            Console.WriteLine(" Цей текст не є паліндромним.\n");
                       
                        Console.Read();
                        break;
                    case ConsoleKey.Q:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Write("\nВибрана не верная кнопка\n"
                                        + "Чтоби продолжить нажмите клавишу: 'Enter' ");
                        Console.ReadLine();
                        break;
                   
                }

            }
        }
    }
}
