using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Farben meineFarbe;
            meineFarbe = Farben.Blau;

            Console.WriteLine(meineFarbe);
            Console.ReadKey();
        }
    }

    public enum Farben
    {
        Rot,
        Blau,
        Gelb,
        Gruen
    }
}









