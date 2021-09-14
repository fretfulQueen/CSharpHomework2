using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Наименьшее число
            Console.Title ("Наименьшее число");

            Console.WriteLine($"Наименьшее из трех введенных чисел равно {MinNum()}");
            Console.ReadLine();
            #endregion

            #region Подсчёт чисел
            Console.Title("Подсчёт чисел");

            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{Count(number)}");
            Console.ReadLine();
            #endregion

            #region Подсчёт суммы чисел
            double score = 0;
            double input = 0;
            bool flag = false;


            while (true)
            {
                while (!flag)
                {
                    Console.Clear();
                    Console.WriteLine($"Сумма всех числе {score}");
                    Console.Write("Повторите ввод числа: ");

                    flag = double.TryParse(Console.ReadLine(), out input);
                }

                flag = false;
                score = score + input;

                if (input == 0) break;
            }

            Console.Clear();
            Console.WriteLine($"Итоговая сумма всех чисел: {score}");
            Console.ReadLine();
            #endregion

            #region Логин и пароль
            int i = 1;
            Console.WriteLine($"Попытка №: {i}");

            Console.Write("Введите логин: ");
            string userName = Console.ReadLine();

            Console.Write("Введите пароль: ");
            string userPassword = Console.ReadLine();

            
            do
            {
                Console.Clear();

                if (userCheck(userName, userPassword) == false)
                {
                    if (i > 2)
                    {
                        Console.WriteLine("Доступ заблокирован: Превышен лимит попыток!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Попытка №: {i + 1}");
                        Console.WriteLine("Ошибка: Данные не верные!");

                        Console.Write("Введите логин: ");
                        userName = Console.ReadLine();

                        Console.Write("Введите пароль: ");
                        userPassword = Console.ReadLine();
                        i++;
                    }
                }

                else
                {
                    Console.WriteLine("Доступ открыт!");
                    break;
                }

            } while (true);



            Console.ReadLine();
            #endregion
        }

        static int MinNum()
        {
            Console.WriteLine("Введите три целых числа: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            return min;
        }

        static int Count(int a)
        {
            int countNumber = (int)Math.Log10(a) + 1;
            return countNumber;
        }

        static bool userCheck(string user, string password)
        {
            
            if (user == "root")
            {
                Console.WriteLine("Пользователь найден!");
                if (passCheck(password) == true)
                {
                    Console.WriteLine("Пароль правильный!");
                    return true;
                }
                else
                {
                    Console.WriteLine("Пароль не правильный!");
                    return false;
                }

            }
            else
            {
                Console.WriteLine("Ошибка: Пользователь не найден!");
                return false;
            }

        }

        public static bool passCheck(string password)
        {
            if (password == "GeekBrains")
            {
                return true;
            }
            else return false;
        }
    }

}
