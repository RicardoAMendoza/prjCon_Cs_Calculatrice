using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCon_Cs_Calculatrice
{
    public class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            int select;
            char end;

            Console.WriteLine("\n-------- CALCULATOR --------\n", Console.ForegroundColor = ConsoleColor.Green);
            try
            {
                do
                {
                    Console.WriteLine("\nWrite the First Number a = ?\n", Console.ForegroundColor = ConsoleColor.Green);
                    a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\nWrite the Second Number b = ?\n", Console.ForegroundColor = ConsoleColor.Green);
                    b = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\nSelect operation\n", Console.ForegroundColor = ConsoleColor.Green);
                    Console.WriteLine("\n1 = SUM -> a + b \n2 = SUBSTRACTION -> a - b \n3 = MULTIPLICATION -> a * b \n4 = DIVISIONgit  -> a / b \n", Console.ForegroundColor = ConsoleColor.Green);
         
                    select = Convert.ToInt32(Console.ReadLine());
                    switch (select)
                    {
                        case 1:
                            Console.WriteLine("\nresultat = " + Sum(a, b), Console.ForegroundColor = ConsoleColor.Green);
                            break;
                        case 2:
                            Console.WriteLine("\nresultat = " + Substraction(a, b), Console.ForegroundColor = ConsoleColor.Green);
                            break;
                        case 3:
                            Console.WriteLine("\nresultat = " + Multiplication(a, b), Console.ForegroundColor = ConsoleColor.Green);
                            break;
                        case 4:
                            try
                            {
                                Console.WriteLine("\nresultat = " + Division(a, b), Console.ForegroundColor = ConsoleColor.Green);
                            }
                            catch (DivideByZeroException e)
                            {
                                Console.WriteLine("Division error : " + e.Message);
                            }
                            finally
                            {
                                Console.WriteLine("\nEnd of the Division");
                            }
                            break;
                        default:
                            Console.WriteLine("\nThe input is between 1 and 4");
                            break;
                    }
                    Console.WriteLine("\nContinue [Y/N]");
                    end = char.Parse(Console.ReadLine().ToUpper());
                }
                while (end == 'Y');
            }
            catch (Exception e)
            {
                Console.WriteLine("error in program  : " + e.Message);
            }
            finally
            {
                Console.WriteLine("\nEnd Calculator");
            }
            Console.ReadLine();
        }

        // staic -> methods that are called on the class itself, not on specific object instance
        // private -> the method can be acceced only by code in the same class or struct   
        public static double Sum(double a, double b)
        {
            return a + b;
        }

        public static double Substraction(double a, double b)
        {
            return a - b;
        }

        public static double Multiplication(double a, double b)
        {
            return a * b;
        }

        public static double Division(double a, double b)
        {   
            double resultat = 0;
            if (b != 0)
            {
                resultat = a / b;
                return resultat;
            }
            else
            {
                Console.WriteLine("\nLa division par zéro n'existe pas");
                return 0;
            } 
        }
    }
}