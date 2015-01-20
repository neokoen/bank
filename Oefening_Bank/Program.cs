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
            Rekening klant1 = new Rekening(20135698745689, 2300, new DateTime(1981, 03, 01));
            klant1.Afbeelden();
            klant1.Storten(700);
            klant1.Afbeelden();


        }
    }
}
