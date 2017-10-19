using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczenia12102017
{
    class Program
    {
        static void Main(string[] args)
        {
            string carName = "Moj Samochod";
            Console.WriteLine(carName);

            Car car1 = new Car();
            car1.marka = "Ford";
            car1.rok = 1993;
            car1.WypiszInfo();
            car1.srednieSpalanie = 8;
            /*Car car2 = new Car();
            car2.marka = "BMW";
            car2.rok = 2015;
            car2.WypiszInfo();
            car1 = car2;
            car2.WypiszInfo();
            car1.WypiszInfo();*/

            Console.WriteLine(car1.ObliczKosztPrzejazdu(100, 8));
            

            Console.ReadKey();
        }
    }
}
