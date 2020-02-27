using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1;
            do
            {
                Console.Write("Меню\n1)Добавить счёт\n2)Слияние\n3)Снятие денег" +
                    "\n4)Пополнение счёта\n5)Сравнение\n6)Проценты\n7)Выход\nЦифра:");
                i1 = Convert.ToInt32(Console.ReadLine());
                switch (i1)
                {
                    case 1:
                        {
                            Console.WriteLine("Введите счёт");
                            string c = Console.ReadLine();
                            Console.WriteLine("Введите сумму");
                            double s = Convert.ToDouble(Console.ReadLine());
                            Account obj = new Account(c, s);

                        }
                        break;
                    case 2:
                        {

                        }
                        break;
                    case 3:
                        {

                        }
                        break;
                    case 4:
                        {

                        }
                        break;
                    case 5:
                        {

                        }
                        break;
                    case 6:
                        {

                        }
                        break;
                    case 7:
                        {

                        }
                        break;
                }

            } while (i1 != 6);
            
            Console.WriteLine("Введите счёт");
            string c1 = Console.ReadLine();
            Console.WriteLine("Введите сумму");
            double s1 = Convert.ToDouble(Console.ReadLine());
            Account obj1 = new Account(c1, s1);



        }
    }
}
