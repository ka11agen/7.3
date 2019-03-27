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
            int i=0;
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
        public int hour
        {
            set
            {
                try
                {
                    if (value > 24)
                        throw new ArgumentOutOfRangeException("value", value.ToString(), "Ошибка!\nЧасы должны быть меньше 24ч");
                    hours = value;                  
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            get
            {
                return (hours);
            }
        }
        public int mine
        {
            set
            {
                try
                {
                    if (value > 60)
                        throw new ArgumentOutOfRangeException("value", value.ToString(), "Ошибка!\nМинуты должны быть меньше 60");
                    minutes = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            get
            {
                return (minutes);
            }
        }
        public int sec
        {
            set
            {
                try
                {
                    if (value > 60)
                        throw new ArgumentOutOfRangeException("value", value.ToString(), "Ошибка!\nСекунды должны быть меньше 60");
                    seconds = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            get
            {
                return (seconds);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int h,m,s, p;
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
                        buf = Console.ReadLine();
                        h = Convert.ToInt32(buf);
                        x.hour = h;
                        Console.Write("Укажите минуты ");
                        buf = Console.ReadLine();
                        m = Convert.ToInt32(buf);
                        x.mine = m;
                        Console.Write("Укажите секунды ");
                        buf = Console.ReadLine();
                        s = Convert.ToInt32(buf);
                        x.sec = s;
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
