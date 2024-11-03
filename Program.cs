using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            realmain();
        }
        static void realmain()
        {
            anamenu();

            ConsoleKeyInfo input = Console.ReadKey();
            if (input.KeyChar == '6')
            {
                Environment.Exit(0);
            }
            else if (input.KeyChar == '1')
            {
                Calc();
            }
            else if (input.KeyChar == '5')
            {
                weightconv();
            }
            else if (input.KeyChar == '2')
            {
                tempcnvt();
            }

            else if (input.KeyChar == '3') 
            { 
                taxcalc();
            }
            else if(input.KeyChar == '4')
            {
                randompassgen();
            }
            
            
        }




















        static void LogoOssurdum() 
        {
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine(@"
 ________  ________  ___       ________  ___  _________  ________  ________  ___          
|\   ____\|\   __  \|\  \     |\   ____\|\  \|\___   ___\\   __  \|\   __  \|\  \         
\ \  \___|\ \  \|\  \ \  \    \ \  \___|\ \  \|___ \  \_\ \  \|\  \ \  \|\  \ \  \        
 \ \  \    \ \   __  \ \  \    \ \  \    \ \  \   \ \  \ \ \  \\\  \ \  \\\  \ \  \       
  \ \  \____\ \  \ \  \ \  \____\ \  \____\ \  \   \ \  \ \ \  \\\  \ \  \\\  \ \  \____  
   \ \_______\ \__\ \__\ \_______\ \_______\ \__\   \ \__\ \ \_______\ \_______\ \_______\
    \|_______|\|__|\|__|\|_______|\|_______|\|__|    \|__|  \|_______|\|_______|\|_______|                                                                                                                                                                                                                                                                       
");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("                         CALCITOOL -v 1.0 by ~Acar Tuna ");
            Console.ResetColor();
        }




        static void Menuu()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"

~1 - Calculator!

~2 - Temperature Converter!

~3 - Tax Calculator!

~4 - Random Password generator!

~5 - Weight Converter!

~6 Exit :(



");

            



        }

        

        static void anamenu()
        {
            LogoOssurdum();
            Menuu();
        }




        static void Calc()
        {
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.DarkRed;
            Console.WriteLine("Please Write The First Number or write 0000 to go back: ");
            int calcinput1 = Convert.ToInt32(Console.ReadLine());
            if (calcinput1 == 0000)
            {
                Console.Clear();
                realmain();
            }
            Console.WriteLine("Now Please Write The Second Number or write 0000 to go back:");
            int calcinput2 = Convert.ToInt32(Console.ReadLine());
            
            if (calcinput2 == 0000)
            {
                Console.Clear();
                realmain();
            }
           
            Console.WriteLine("Now Please Write The Operation You want to do (+, -, x, /, Mod or back):");
            string calcopr = Console.ReadLine();
            if (calcopr == "+")
            {
                Console.WriteLine(calcinput1 + " + " + calcinput2 + " = " + (calcinput1 + calcinput2));
                Console.WriteLine("Would you like to try again? (y/n/b b = back)");
                string tempcyn = Console.ReadLine();
                if (tempcyn == "y")
                {
                    Console.Clear();
                    Calc();
                }
                else if (tempcyn == "b")
                {
                    Console.Clear();
                    realmain();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            else if (calcopr == "-")
            {
                Console.WriteLine(calcinput1 + " - " + calcinput2 + " = " + (calcinput1 - calcinput2));
                Console.WriteLine("Would you like to try again? (y/n/b b = back)");
                string tempcyn = Console.ReadLine();
                if (tempcyn == "y")
                {
                    Console.Clear();
                    Calc();
                }
                else if (tempcyn == "b")
                {
                    Console.Clear();
                    realmain();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            else if (calcopr == "x")
            {
                Console.WriteLine(calcinput1 + " x " + calcinput2 + " = " + (calcinput1 * calcinput2));
                Console.WriteLine("Would you like to try again? (y/n/b b = back)");
                string tempcyn = Console.ReadLine();
                if (tempcyn == "y")
                {
                    Console.Clear();
                    Calc();
                }
                else if (tempcyn == "b")
                {
                    Console.Clear();
                    realmain();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            else if (calcopr == "/")
            {
                if (calcinput2 != 0)
                {
                    Console.WriteLine(calcinput1 + " / " + calcinput2 + " = " + (calcinput1 / calcinput2));
                    Console.WriteLine("Would you like to try again? (y/n/b b = back)");
                    string tempcyn = Console.ReadLine();
                    if (tempcyn == "y")
                    {
                        Console.Clear();
                        Calc();
                    }
                    else if (tempcyn == "b")
                    {
                        Console.Clear();
                        realmain();
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
                else 
                { 
                    Console.WriteLine("Cant Divide With Zero!");
                    Console.WriteLine("Would you like to try again? (y/n/b b = back)");
                    string tempcyn = Console.ReadLine();
                    if (tempcyn == "y")
                    {
                        Console.Clear();
                        Calc();
                    }
                    else if (tempcyn == "b")
                    {
                        Console.Clear();
                        realmain();
                    }
                    else
                    {
                        Environment.Exit(0);
                    }

                }
            }
            else if (calcopr == "Mod")
            {
                Console.WriteLine(calcinput1 + " % " + calcinput2 + " = " + (calcinput1 % calcinput2));
                Console.WriteLine("Would you like to try again? (y/n/b b = back)");
                string tempcyn = Console.ReadLine();
                if (tempcyn == "y")
                {
                    Console.Clear();
                    Calc();
                }
                else if (tempcyn == "b")
                {
                    Console.Clear();
                    realmain();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            else if (calcopr == "back")
            {
                Console.Clear();
                realmain();
                
            }
        
            

            

        }
        static void tempcnvt()
        {
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.DarkRed;
            Console.WriteLine("Please Type CF to convert C to F, FC to convert F to C or type back to go back: ");
            string tempcinput = Console.ReadLine();
            if (tempcinput == "back")
            {
                Console.Clear();
                realmain();
            }
            Console.WriteLine("Now Please Write The temperature (C if you typed CF or F if you typed FC)");
            double tempcnum = Convert.ToInt32(Console.ReadLine());
            double tempcnumc18 = tempcnum * 1.8;
            if (tempcinput == "CF")
            {
                Console.WriteLine("The Temperature is: " + (tempcnumc18 + 32));
                Console.WriteLine("Would you like to try again? (y/n/b b = back)");
                string tempcyn = Console.ReadLine();
                if (tempcyn == "y")
                {
                    Console.Clear();
                    tempcnvt();
                }
                else if (tempcyn == "b")
                {
                    Console.Clear();
                    realmain();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            else if (tempcinput == "FC")
            {
                Console.WriteLine("The Temperature is: " + (tempcnum - 32) / 1.8);
                Console.WriteLine("Would you like to try again? (y/n/b b = back)");
                string tempcyn = Console.ReadLine();
                if (tempcyn == "y")
                {
                    Console.Clear();
                    tempcnvt();
                }
                else if (tempcyn == "b")
                {
                    Console.Clear();
                    realmain();
                }
                else
                {
                    Environment.Exit(0);
                }
                
            }
            



        }
        static void taxcalc()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            float kdv = 20 / 100;
            Console.WriteLine("Please write the price: ");
            double taxprice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Now please write the amount of tax (kdv = 0,20)");
            double taxamount = Convert.ToDouble(Console.ReadLine());

            double tax = (taxprice * taxamount) / 1;

            double fullamount = tax + taxprice;

            Console.WriteLine($"Tax is: {tax} TL");
            Console.WriteLine($"Full Price is: {fullamount}");
            Console.WriteLine("Would you like to try again? (y/n/b b = back)");
            string tempcyn = Console.ReadLine();
            if (tempcyn == "y")
            {
                Console.Clear();
                taxcalc();
            }
            else if (tempcyn == "b")
            {
                Console.Clear();
                realmain();
            }
            else
            {
                Environment.Exit(0);
            }

        }





        static void randompassgen()
        {
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.DarkRed;
            Console.WriteLine("Please enter the lenght of characters: ");
            int lenght = int.Parse(Console.ReadLine());

            string Password = GeneratePassword(lenght);
            Console.WriteLine($"The Generated Password: {Password}");
            Console.WriteLine("Would you like to try again? (y/n/b b = back)");
            string tempcyn = Console.ReadLine();
            if (tempcyn == "y")
            {
                Console.Clear();
                randompassgen();
            }
            else if (tempcyn == "b")
            {
                Console.Clear();
                realmain();
            }
            else
            {
                Environment.Exit(0);
            }

        }
        static string GeneratePassword(int lenght)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!'^+%&/()=?_>£#$½{[]}";

            StringBuilder result = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < lenght; i++)
            {
                result.Append(chars[random.Next(chars.Length)]);
            }

            return result.ToString();
        }

        static void weightconv()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Please type PK to convert pound to Kg, KP to opposite or back to go back: ");
            string weightinp = Console.ReadLine();
            Console.WriteLine("Please write the Number: ");
            double weightnum = Convert.ToDouble(Console.ReadLine());
            if (weightinp == "PK")
            {
                double kgnum = weightnum * 0.453592;
                Console.WriteLine($"{weightnum} pound is {kgnum} kg");
            }
            else if (weightinp == "KP")
            {
                double pnum = weightnum / 0.453592;
                Console.WriteLine($"{weightnum} kg is {pnum} pound");
                Console.WriteLine("Would you like to try again? (y/n/b b = back)");
                string tempcyn = Console.ReadLine();
                if (tempcyn == "y")
                {
                    Console.Clear();
                    weightconv();
                }
                else if (tempcyn == "b")
                {
                    Console.Clear();
                    realmain();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            else if (weightinp == "back")
            {
                Console.Clear();
                realmain();
            }
        }
    }
}
