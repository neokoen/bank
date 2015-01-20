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
            Rekening klant1 = new Rekening(747524091936ul, 0m, DateTime.Today);
            klant1.Afbeelden();
            klant1.Storten(700);
            klant1.Afbeelden();


        }
    }
}
