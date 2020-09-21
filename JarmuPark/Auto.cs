using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuPark
{
    class Auto
    {
        private string szin;
        private string tipus;
        private double uzemAnyag;
        private double fogyaszt;
        private double km;
        private double megtehetoKM;

        public Auto(string szin, string tipus, double fogyaszt)
        {
            this.szin = szin;
            this.tipus = tipus;
            this.uzemAnyag = 0;
            this.fogyaszt = fogyaszt;
            this.km = 0;
            this.megtehetoKM = 0;
        }

        private void Megteheto()
        {
            megtehetoKM = uzemAnyag / fogyaszt * 100;
        }

        public void Tankol(double mennyit)
        {
            uzemAnyag = uzemAnyag + mennyit;
            Megteheto();
        }

        public void Megy(double km)
        {
            this.km = this.km + km;

            uzemAnyag = uzemAnyag - (km * fogyaszt / 100);

            Megteheto();
        }

        public void Allapot()
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"{tipus} - {szin}");
            Console.WriteLine($"Km óra: {km}");
            Console.WriteLine($"Üzemanyag: {uzemAnyag} l");
            Console.WriteLine($"Megtehető km: {megtehetoKM}");
            Console.WriteLine("-----------------------------------------------");
        }
    }
}
