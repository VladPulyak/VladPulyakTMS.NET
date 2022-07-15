﻿using System;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                checked
                {
                    Console.WriteLine("Enter first number");
                    double number1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second number");
                    double number2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter operation");
                    char operation = char.Parse(Console.ReadLine());
                    switch (operation)
                    {
                        case '+':
                            {
                                Console.WriteLine($"Result: { number1 + number2}");
                                break;
                            }
                        case '-':
                            {
                                Console.WriteLine($"Result: { number1 - number2}");
                                break;
                            }
                        case '*':
                            {
                                Console.WriteLine($"Result: { number1 * number2}");
                                break;
                            }
                        case '/':
                            {
                                if (number2 == 0)
                                {
                                    throw new DivideByZeroException();
                                }
                                Console.WriteLine($"Result: { number1 / number2}");
                                break;
                            }
                        case '%':
                            {
                                if (number2 == 0)
                                {
                                    throw new DivideByZeroException();
                                }
                                Console.WriteLine($"Result: { number1 % number2}");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("FormatException, you entered wrong number");
                                break;
                            }
                    }
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("OverflowException, you entered too large number");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("DivideByZeroException, you entered number1 by zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException, you entered wrong number");
            }
        }
    }
}
