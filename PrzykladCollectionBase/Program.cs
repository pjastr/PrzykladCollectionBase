using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzykladCollectionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            WlasnaKolekcja wk = new WlasnaKolekcja();
            wk.Add("sss");
            wk.Add(455);

            Console.ReadLine();
        }
    }
}
