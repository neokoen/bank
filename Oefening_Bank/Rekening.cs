using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_Bank
{
    class Rekening
    {
        private long RekeningNummerValue;
        private decimal SaldoValue;
        private DateTime CreatieDatumValue;

        public DateTime CreatieDatum
        {
            get
            {
                return CreatieDatumValue;
            }
            set
            {
                if (value> new DateTime(1900,01,01))
                    CreatieDatumValue = value;
            }
        }

        public long RekeningNummer
        {
            get
            {
                return RekeningNummerValue;
            }
            set
            {
                if (value>9999999999L)
                    RekeningNummerValue = value;


            }
        }

        public decimal Saldo
        {
            get
            {
                return SaldoValue;
            }
            set
            {
                SaldoValue = value;
            }
        }

        public void Afbeelden()
        {
            Console.WriteLine(RekeningNummer + " , " + Saldo + " ," + CreatieDatum);
        }

        public Rekening (long nummer, decimal saldo, DateTime creatieDatum)
        {
            RekeningNummer = nummer;
            Saldo = saldo;
            CreatieDatum = creatieDatum;

        }
        public void Storten(decimal bedrag)
        {
            Saldo += bedrag;

        }
        



    }
}
