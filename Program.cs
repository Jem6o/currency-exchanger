using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace CSLight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float rubblesInWallet;
            float dollarsInWallet;

            int rubToUsd = 55, UsdToRub = 59;

            float exchangeCurrencyCount;

            string desiredOperation;

            Console.WriteLine("Добро пожаловать в обменник валют!");

            Console.Write("Введите баланс рублей:");
            rubblesInWallet = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите баланс долларов:");
            dollarsInWallet = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Выберите необходимую операцию:");
            Console.WriteLine("1 - обменять рубли на доллоры");
            Console.WriteLine("2 - обменять доллоры на рубли");
            Console.Write("Ваш выбор: ");
            desiredOperation = Console.ReadLine();

            switch (desiredOperation)
            {
                case "1":
                    Console.WriteLine("Обмен рублей на доллоры.");
                    Console.Write("Сколько вы хотите обменять?");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if(rubblesInWallet >= exchangeCurrencyCount)
                    {
                        rubblesInWallet -= exchangeCurrencyCount;
                        dollarsInWallet += exchangeCurrencyCount / rubToUsd;
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое значение.");
                    }
                    break;
                case "2":
                    Console.WriteLine("Обмен долларов на рубли.");
                    Console.Write("Сколько вы хотите обменять?");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (dollarsInWallet >= exchangeCurrencyCount)
                    {
                        dollarsInWallet -= exchangeCurrencyCount;
                        rubblesInWallet += exchangeCurrencyCount * UsdToRub;
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое значение.");
                    }
                    break;
                default:
                    Console.WriteLine("Выбрана неверная операция.");
                    break;
            }

            Console.WriteLine($"Ваш баланс {rubblesInWallet} рублей, " + $"{dollarsInWallet} долларов.");
        }
    }
}
