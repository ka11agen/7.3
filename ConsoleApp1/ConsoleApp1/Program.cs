using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class time
    {
        public int hours = 10;
        public int minutes = 15;
        public int seconds = 23;
        public void Sety(int hours_, int minutes_, int seconds_)
        {
            int i = 0;
            hours += hours_;
            minutes += minutes_;
            seconds += seconds_;
            if (seconds > 60)
            {
                i = seconds / 60;
                seconds = seconds % 60;
            }
            minutes += i;
            if (minutes > 60)
            {
                i = minutes / 60;
                minutes = minutes % 60;
            }
            hours += i;
            if (hours > 24)
            {
                i = hours / 24;
                hours = hours % 24;
            }
        }
        public void set1(int hours_)
        {
            hours = hours_;
        }
        public void set2(int minutes_)
        {
            minutes = minutes_;
        }
        public void set3(int seconds_)
        {
            seconds = seconds_;
        }

        public int hours1(int hours)
        {
            string buf;
            int z;
            int start;
            do
            {
                z = 0;

                try
                {
                    start = hours;
                    buf = Console.ReadLine();
                    hours = Convert.ToInt32(buf);


                    if (hours > 24 || hours < 0)
                    {
                        Console.WriteLine("Ошибка! Число должно быть больше 0 и меньше 24");
                        hours = start;
                        z = 1;
                    }
                    else
                    {
                        z = 0;
                    }




                }
                catch
                {
                    Console.WriteLine("Ошибка! Некоректный ввод.");
                    z = 1;
                }
            } while (z == 1);

            return (hours);


        }
        public int min1(int min)
        {
            string buf;
            int z;
            int start;
            do
            {
                z = 0;

                try
                {
                    start = min;
                    buf = Console.ReadLine();
                    min = Convert.ToInt32(buf);


                    if (min > 60 || min < 0)
                    {
                        Console.WriteLine("Ошибка! Число должно быть больше 0 и меньше 60");
                        min = start;
                        z = 1;
                    }
                    else
                    {
                        z = 0;
                    }




                }
                catch
                {
                    Console.WriteLine("Ошибка! Некоректный ввод.");
                    z = 1;
                }
            } while (z == 1);

            return (min);


        }
        public int sec1(int sec)
        {
            string buf;
            int z;
            int start;
            do
            {
                z = 0;

                try
                {
                    start = sec;
                    buf = Console.ReadLine();
                    sec = Convert.ToInt32(buf);


                    if (sec > 60 || sec < 0)
                    {
                        Console.WriteLine("Ошибка! Число должно быть больше 0 и меньше 60");
                        sec = start;
                        z = 1;
                    }
                    else
                    {
                        z = 0;
                    }




                }
                catch
                {
                    Console.WriteLine("Ошибка! Некоректный ввод.");
                    z = 1;
                }
            } while (z == 1);

            return (sec);


        }
    }
        class Program
        {
            static void Main(string[] args)
            {
                int h = 0, m = 0, s = 0, p;
                string buf;
                time x = new time();
                for (; ; )
                {
                    Console.WriteLine("Время: " + x.hours + ":" + x.minutes + ":" + x.seconds);
                    Console.WriteLine("Выберите пункт меню:\n1.Указать новое время\n2.Сместить время.");
                    buf = Console.ReadLine();
                    p = Convert.ToInt32(buf);
                    switch (p)
                    {
                        case 1:
                            Console.Write("Укажите час ");
                            x.set1(x.hours1(h));
                            Console.Write("Укажите минуты ");
                            x.set2(x.min1(m));
                            Console.Write("Укажите секунды ");
                            x.set3(x.sec1(s));
                            break;
                        case 2:
                            Console.Write("Укажите час ");
                            buf = Console.ReadLine();
                            h = Convert.ToInt32(buf);
                            Console.Write("Укажите минуты ");
                            buf = Console.ReadLine();
                            m = Convert.ToInt32(buf);
                            Console.Write("Укажите секунды ");
                            buf = Console.ReadLine();
                            s = Convert.ToInt32(buf);
                            x.Sety(h, m, s);
                            break;
                        default:
                            Console.WriteLine("Ошибка\nНесуществующий пункт меню");
                            break;
                    }
                    //Console.Clear();
                }
            }
        }
    }

