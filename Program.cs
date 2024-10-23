using SimpleList;

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
            s1.Ausgabe();
            s1.WertSuchen(17);
            s1.EintragLöschen(15);
            s1.Ausgabe();
            s1.Dequeue();
            s1.Ausgabe();
            s1.Dequeue();
            s1.Dequeue();
            s1.Ausgabe();
            s1.Dequeue();
            s1.Dequeue();
           
  
        }
    }
}
