using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuPark
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto Lada = new Auto("piros", "Lada 2112", 11);
            Auto Trabant = new Auto("zöld", "Trabant 1.1", 8);

            Lada.Tankol(20);
            Trabant.Tankol(20);

            Lada.Allapot();
            Trabant.Allapot();

            Console.WriteLine("Mennyit megy a Lada?: ");
            int km = int.Parse(Console.ReadLine());
            Lada.Megy(km);
            Lada.Allapot();

            Console.ReadKey();
        }
    }
}
