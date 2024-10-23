using SimpleList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleListAufgabe
{
    internal class SimpleList<T> where T: IComparable
    {
        
        private Eintrag<T> _head;
        private Eintrag<T> _tail;

        public SimpleList(Eintrag<T> e)
        {
            if(this.IsEmpty() == true)
            {
                _head = e;
                _tail = e;
            }

            }

        
        public bool IsEmpty()
        {
            return _head == null ? true : false;
        }

        public void Enqueue(Eintrag<T> data)
        {
            Console.WriteLine(data.getData().ToString()+" wurde angefügt");
            _tail.setNext(data);
            
            _tail = data;
        }

        public void Ausgabe()
        {

            
            int i = 1;
            Eintrag<T> entry = _head;
            while (entry != null)
            {
                Console.WriteLine(i + ". " + entry.getData().ToString());
                if(entry.getNext() != null)
                {
                    Console.WriteLine("Nächster =" + entry.getNext().getData().ToString());
                }
                else
                { Console.WriteLine("ist letzter"); }
          
                i++;
                entry = entry.getNext();
            }
            Console.WriteLine();
        }

        public void Dequeue()
        {
            string ausgabe;
            if (IsEmpty() == true)
            {
                Console.WriteLine("Warteschlange ist leer");
            }
            else
            {
               
                Console.WriteLine($"{_head.getData().ToString()} hat die Warteschlange verlassen");
                _head = _head.getNext();
                if (_head != null && _head.getNext() == _tail)
                {
                    _tail = null;
                    Console.WriteLine("Letzter in der Warteschlange ist raus");
                }
            }
           
        }

        public void WertSuchen(T suchwert)
        {
            Console.WriteLine("Suche nach " + suchwert);
            int zähler = 1;
            bool gefunden = false;
            Eintrag<T> aktuellesElement = _head;
            while(aktuellesElement.getNext() != null)
            {
                if (aktuellesElement.getData().CompareTo(suchwert) == 0)
                {
                    Console.WriteLine($"Wert {suchwert} gefunden an Position {zähler}");
                    gefunden = true;
                    break;
                }
                if(aktuellesElement.getNext() != null)
                {
                    aktuellesElement = aktuellesElement.getNext();
                }
                zähler++;
            }
            if (gefunden == false)
            {
                Console.WriteLine($"Wert {suchwert} ist nicht vorhanden.");
            }
       
        }

        public void EintragLöschen(T suchwert)
        {

            bool gefunden = false;
            Eintrag<T> aktuellesElement = _head;
            while (aktuellesElement != null)
            {
                if (aktuellesElement.getNext() != null &&  aktuellesElement.getNext().getData().CompareTo(suchwert) == 0)
                {
                    aktuellesElement.setNext(aktuellesElement.getNext().getNext());
                    gefunden = true;
                    Console.WriteLine($"Eintrag mit Wert {suchwert} gelöscht");
                }
                if (aktuellesElement.getNext() != null)
                {
                    aktuellesElement = aktuellesElement.getNext();
                }

                
            }
            if (gefunden == false) Console.WriteLine($"Wert {suchwert} ist nicht vorhanden.");
        }


    }
}
