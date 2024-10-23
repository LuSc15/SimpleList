using SimpleListAufgabe;

namespace SimpleListAufgabe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Eintrag<int> e1 = new Eintrag<int>(10);
            Eintrag<int> e2 = new Eintrag<int>(15);
            Eintrag<int> e3 = new Eintrag<int>(22);
            Eintrag<int> e4 = new Eintrag<int>(30);
            SimpleList<int> s1 = new SimpleList<int>(e1);
            s1.Enqueue(e2);
            s1.Enqueue(e3);
            s1.Enqueue(e4);
            Console.WriteLine(s1.AnzahlAusgeben()+" Elemente in der Liste\n");
            Console.WriteLine(s1.ToArray().Length+" Elemente im Array");
            for (int i = 0; i < s1.ToArray().Length; i++) { Console.WriteLine($"{i}. Array-Wert:" + s1.ToArray()[i].getData());  }
            Console.WriteLine();
            s1.Ausgabe();
            s1.WertSuchen(15);
            s1.EintragLöschen(15);

            Console.WriteLine(s1.AnzahlAusgeben() + " Elemente in der Liste\n");
            Console.WriteLine(s1.ToArray().Length + " Elemente im Array");
            for (int i = 0; i < s1.ToArray().Length; i++) { Console.WriteLine($"{i}. Array-Wert:" + s1.ToArray()[i].getData()); }
            Console.WriteLine();
            s1.WertSuchen(17);
            
            s1.Ausgabe();
            s1.Dequeue();
            s1.Ausgabe();
            s1.Dequeue();
            s1.Dequeue();
            s1.Ausgabe();
            s1.Dequeue();
            s1.Dequeue();
            //Console.ReadLine();
            Console.Clear();
            Eintrag<int> setWert1 = new Eintrag<int>(50);
            Eintrag<int> setWert2 = new Eintrag<int>(55);
            Eintrag<int> setWert3 = new Eintrag<int>(60);
            Eintrag<int> setWert4 = new Eintrag<int>(65);
            Console.Clear();
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("Set anlegen:");
            Console.WriteLine("*********************************************************************");
            Set<int> set1 = new Set<int>(setWert1);
            set1.Enqueue(setWert2);
            Console.WriteLine();
            set1.Enqueue(setWert2);
            set1.Ausgabe();
            set1.Dequeue();
            set1.Dequeue();
            set1.Ausgabe();
            
           
  
        }
    }
}
