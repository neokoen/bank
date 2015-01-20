using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_Bank
{
    class Rekening
    {
        private readonly DateTime EersteCreatie = new DateTime(1900, 1, 1);
        private ulong RekeningNummerValue;
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
                if (value>= EersteCreatie)
                    CreatieDatumValue = value;
            }
        }

        public ulong RekeningNummer
        {
            get
            {
                return RekeningNummerValue;
            }
            set
            {
                ulong eerste10 = value / 100ul;
                int laatste2 = (int)(value % 100ul);
                if ((int) (eerste10 % 97ul) == laatste2)
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

        public virtual void Afbeelden()
        {
            Console.WriteLine("Rekeningnummer: {0: 000-0000000-00}", RekeningNummer);
            Console.WriteLine("Saldo: {0}", Saldo);
            Console.WriteLine("Creatiedatum: {0:dd-MM-yyyy}", CreatieDatum);
        }

        public Rekening (ulong nummer, decimal saldo, DateTime creatieDatum)
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
