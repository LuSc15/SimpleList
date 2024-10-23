using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleListAufgabe
{
    internal class Set<T> : SimpleList<T> where T : IComparable
    {
        public Set(Eintrag<T> e) : base(e)
        {
            
        }
        public override bool WertSuchen(T suchwert)
        {
            Console.WriteLine($"Suche Wert in Menge: {suchwert}");
            if(base.WertSuchen(suchwert) == true)
            {
                Console.WriteLine($"Wert {suchwert} ist in der Menge vorhanden");
                return true;
            }
            Console.WriteLine($"Wert {suchwert} ist in der Menge noch nicht vorhanden.");
            return false;
        }

        public override bool EintragLöschen(T suchwert)
        {
            Console.WriteLine($"Versuche {suchwert} aus Menge zu löschen.");
            if(base.EintragLöschen(suchwert))
            {
                Console.WriteLine($"Wert {suchwert} wurde gelöscht");
                return true;
            }
            else
            {
                Console.WriteLine($"Wert {suchwert} war nicht vorhanden und kann nicht gelöscht werden.");
            }
            return false;
        }

        public override void Enqueue(Eintrag<T> data)
        {
            Console.WriteLine($"Versuche Wert {data.getData()} in Menge einzufügen");
            if(base.WertSuchen(data.getData()) == false)
            {
                base.Enqueue(data);
                Console.WriteLine($"Wert {data.getData()} eingefügt");
            }
            else
            {
                Console.WriteLine($"Wert {data.getData()}ist bereits in Menge vorhanden, einfügen nicht möglich.");
            }
            
        }
    }
}
