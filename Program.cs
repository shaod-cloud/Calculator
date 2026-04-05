using System;
namespace ProjectOne 
{
class calc
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Введите первое число \n");
                string input_a = Console.ReadLine().Replace('.', ',');
                 double a;

                try
                {
                    a = Convert.ToDouble(input_a);
                }
                catch
                {
                    Console.WriteLine("Ты...серьёзно Надо поменять? ");
                    Console.WriteLine("Нажмите любую клавишу...");
                    Console.ReadKey();
                    continue;
                }
                Console.Write("Введите второе число \n");
                string input_b = Console.ReadLine().Replace('.', ',');
                double b;
                try
                {
                    b = Convert.ToDouble(input_b);
                }
                catch
                {
                    Console.WriteLine("Ты...серьёзно?");
                    Console.WriteLine("Нажмите любую клавишу...");
                    Console.ReadKey();
                    continue;
                }
                Console.Write("Выберите действие \n 1 - Сложение \n 2 - Вычитание \n 3 - Деление \n 4 - Умножение \n 5 - Степень \n 6 - Остаток от деления ");
                string input_x = Console.ReadLine();
                int x;
                try
                {
                    x = Convert.ToInt32(input_x);
                }
                catch
                {
                    Console.WriteLine("Ошибка! Действие должно быть числом.");
                    Console.WriteLine("Нажмите любую клавишу...");
                    Console.ReadKey();
                    continue;
                }

                if (x < 1 || x > 6)
                {
                    Console.WriteLine("Ошибка! Выберите число от 1 до 6.");
                    Console.WriteLine("Нажмите любую клавишу...");
                    Console.ReadKey();
                    continue;
                }
                else
                {
                    switch (x)
                    {
                        case 1:
                            Console.Write("Результат сложения \n");
                            Console.Write(a + b);
                            break;
                        case 2:
                            Console.Write("Результат вычитания \n");
                            Console.Write(a - b);
                            break;
                        case 3:
                            if (b == 0)
                            {
                                Console.WriteLine("Ошибка!");
                                break;
                            }
                            else
                            {
                                Console.Write("Результат деления \n");
                                Console.Write($"{a} / {b} = {a / b}");
                                break;
                            }
                        case 4:
                            Console.Write("Результат умножения \n");
                            Console.Write(a * b);
                            break;
                            case 5: 
                            Console.Write("Степень \n");
                            Console.WriteLine($"{a} ^ {b} = {Math.Pow(a, b)}");
                            break;
                        case 6: 
                            Console.Write("Остаток от деления \n");
                            Console.WriteLine($"{a} % {b} = {a % b}");
                            break;
                    }
                    Console.WriteLine("\n Хотите продолжить? (да/нет)");
                    string answer = Console.ReadLine().ToLower(); 
                    if (answer == "да" || answer == "yes")
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        break; 
                    
                }
                   
                }
            }
        }
    }
}
