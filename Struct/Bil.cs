using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    public struct Bil
    {
        public string Farve;
        public int Km;
        public int Hk;

        public Bil(string farve, int km, int hk)
        {
            Farve = farve;
            Km = km;
            Hk = hk;
        }

        public void Udskriv()
        {
            Console.WriteLine($"Farve: {Farve}, Kilometer: {Km}, Hestekræfter: {Hk}");
        }
    }
}
