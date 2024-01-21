using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringsDemo.Services;
using StatCalc.Services;

namespace StatCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu("Статистичний калькулятор", new string[]
            {
                "Перегляд даних",
                "Редагування даних",
                "обчислення середнього",
                "Обчислення похибки",
                "Збереження похибки",
                "Вихід із програми"
            });

            bool exit = false;
            var operation = new OperationManager();
            do
            {
                menu.DisplayMenu();
                switch (menu.GetChoice())
                {
                    case 1:
                    {
                            operation.DisplayData();
                    }
                    break;
                case 2:
                    {

                    }
                    break;
                case 3:
                    {
                            var a = operation.CalcAverage();
                            operation.DisplayAverage(a);
                    }
                    break;
                case 4:
                    {
                            var b = operation.ErrorAverage();
                            operation.DisplayError(b);
                    }
                    break;
                case 5:
                    {
                            var s = operation.ErrorAverage();
                            operation.SaveError(s);

                    }
                    break;
                case 6:
                    {
                            exit = true;
                    }
                    break;
                    default:
                        {
                            Console.WriteLine("Не правильний вибір!");
                        }
                        break;
                }
                if (exit)
                {
                    break;
                }
            } while (menu.Exit());
        }
    }
}
