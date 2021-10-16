using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение угла в градусах для перевода в радианы");
            Angle angle = new Angle(0, 0, 0);
            Console.Write("Градусы: ");
            try
            {
                angle.Gradus = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ошибка! {0}", ex.Message);
                Console.ReadKey();
                return;
            }            
            Console.Write("Минуты: ");
            try
            {
                angle.Min = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ошибка! {0}", ex.Message);
                Console.ReadKey();
                return;
            }
            Console.Write("Секунды: ");
            try
            {
                angle.Sec = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ошибка! {0}", ex.Message);
                Console.ReadKey();
                return;
            }
            angle.ToRadians();            
            Console.ReadKey();
        }
    }
    class Angle
    {
        double gradus;
        double min;
        double sec;
        public double Gradus
        {
            set
            {
                if (value >= 0)
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Градус не может быть отрицательным");                    
                }
            }
            get
            {
                return gradus;
            }
        }
        public double Min
        {
            set
            {
                if (value >= 0)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Минуты не могут быть отрицательными");
                }
            }
            get
            {
                return min;
            }
        }
        public double Sec
        {
            set
            {
                if (value >= 0)
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Секунды не могут быть отрицательными");                    
                }
            }
            get
            {
                return sec;
            }
        }
        public Angle(double gradus, double min, double sec)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }
        public void ToRadians()
        {
            double rad = (gradus + min / 60 + sec / 3600) * Math.PI / 180;
            Console.WriteLine("Результат: {0}", rad);
        }
    }
}
