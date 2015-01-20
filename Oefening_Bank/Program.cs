using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Spaarrekening klant1 = new Spaarrekening(747524091936ul, 0m, DateTime.Today, 0.03m);
            Zichtrekening klant2 = new Zichtrekening (747524091936ul, 0m, DateTime.Today, 1500);
            klant1.Storten(1000);
            klant1.Afbeelden();
            Console.WriteLine();
            klant2.Storten(125);
            klant2.Afbeelden();

        }
    }
}
