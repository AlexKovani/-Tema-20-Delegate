using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    //   В приложении объявить тип делегата, который ссылается на метод.Требования к сигнатуре метода следующие:

    //-       метод получает входным параметром переменную типа double;

    //-       метод возвращает значение типа double, которое является результатом вычисления.



    //   Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:

    //-       длину окружности по формуле D = 2 * π * R;

    //-       площадь круга по формуле S = π* R²;

    //-       объем шара.Формула V = 4 / 3 * π * R³.


    // Методы должны быть объявлены как статические.
    class Program
    {
        static void Main(string[] args)
        {
            Mydelegate my1 = Diameter;
            if (my1 != null)
            {
                
                my1 += Square;
                my1 += Volume;
                my1(3);
            }
           
            Console.ReadKey();
        }
        delegate double Mydelegate(double R);

        static double Diameter(double R)
        {
            double D = 2 * Math.PI * R;
            Console.WriteLine(D);
            return D;
        }
        static double Square(double R)
        {
            double S = Math.PI * Math.Pow(R, 2);
            Console.WriteLine(S);
            return S;
        }
        static double Volume(double R)
        {
            double V = (4 / 3) * Math.PI * Math.Pow(R, 3);
            Console.WriteLine(V);
            return V;
        }
    }
}
