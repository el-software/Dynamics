using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fumo_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double prezzoPacchetto10 = 2.5;
            double spesa = 0;
            int giorni_trascorsi = 0;
            DateTime fine = new DateTime(2016, 12, 25);
            TimeSpan giorni = DateTime.Now.Date - fine;
            giorni_trascorsi =  (int)giorni.TotalDays;
            spesa = prezzoPacchetto10 * giorni_trascorsi ;
            Console.WriteLine("Giorni trascorsi: " + (giorni.TotalDays).ToString());
            Console.WriteLine("Spesa: {0} euro.", spesa);
            Test prova = new Test();
            prova.Stampa(giorni_trascorsi);
        }
        class Test
        {
            //int memo = 0;
            
            public void Stampa (int valore)
            {
                Console.WriteLine("Totale giorni trascorsi: {0}", valore);
            }
            
        }
    }
    class Calcolo
    {
        
    }
}
