using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApp8
{
    class Program
    {
        static void Main()
        {
            int n = InputNParse(1, 6);
            int a = 0;
            int b = 0;
            string input = string.Empty;
            while (true)
            {
                Console.WriteLine("Введите строку");
                input = Console.ReadLine();
                a = Width(input, n);
                if (a > 40)
                {
                    Console.WriteLine("Размер больше 40. Повторите ввод");
                }
                else
                {
                    break;
                }
            }
            b = Length(input, n);
            int k = 1;
            while (k < 4)
            {
                DrawTable(input, a, b, n, k);
                k++;
            }


            void DrawTable(string input, int a, int b, int n, int tableRow)
            {
                var horizontalLine = BuildHorizontLine(a);
                switch (tableRow)
                {
                    case 1:
                        Console.WriteLine(horizontalLine);
                        FirstString(input, a, b, n);
                        Console.WriteLine(horizontalLine);
                        break;
                    case 2:
                        SecondString(a, b);
                        Console.WriteLine(horizontalLine);
                        break;
                    case 3:
                        ThirdString(a);
                        Console.WriteLine(horizontalLine);
                        break;
                    default:
                        break;
                }
            }


            int InputNParse(int a, int b)
            {
                int range = 0;
                bool notInRange = false;
                do
                {
                    Console.WriteLine("введите размерность таблицы");
                    if (int.TryParse(Console.ReadLine(), out var result))
                    {
                        if (result >= a && result <= b)
                        {
                            notInRange = true;
                            range = result;
                        }
                    }
                } while (!notInRange);
                return range;
            }


            void FirstString(string text, int width, int length, int n)
            {
                for (int k = 1; k <= length; k++)
                {
                    for (int l = 1; l <= width; l++)
                    {
                        if (l == 1 || l == width)
                        {
                            Console.Write("+");
                        }
                        else if (l == n + 1 && k == n)
                        {
                            Console.Write(text);
                            l += text.Length - 1;
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }


            void SecondString(int width, int length)
            {
                for (int k = 1; k <= length; k++)
                {
                    for (int l = 1; l <= width; l++)
                    {
                        if (l == 1 || l == width)
                        {
                            Console.Write("+");
                        }
                        else if ((k + l) % 2 == 0)
                        {
                            Console.Write("+");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }


            void ThirdString(int width)
            {
                for (int k = 1; k <= width - 2; k++)
                {
                    for (int l = 1; l <= width; l++)
                    {
                        if (l == 1 || l == width)
                        {
                            Console.Write("+");
                        }
                        else if ((k + l) == width)
                        {
                            Console.Write("+");
                        }
                        else if (k == l - 1)
                        {
                            Console.Write("+");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }


            int Width(string text, int n)
            {
                int width = text.Length + 2 * n;
                return width;
            }


            int Length(string text, int n)
            {
                int length = 2 * n - 1;
                return length;
            }


            StringBuilder BuildHorizontLine(int width)
            {
                var sb = new StringBuilder('+');
                for (int i = 1; i <= width; i++)
                    sb.Append('+');
                return sb;
            }
        }
    }
}

