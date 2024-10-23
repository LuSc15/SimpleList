using SimpleListAufgabe;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleListAufgabe
{
    internal class SimpleList<T> where T: IComparable
    {
        
        protected Eintrag<T> _head;
        protected Eintrag<T> _tail;

        public SimpleList(Eintrag<T> e)
        {
            if(this.IsEmpty() == true)
            {
                Console.WriteLine($"1. Wert ist {e.getData()}\n");
                _head = e;
                _tail = e;
            }

            }

        
        public virtual bool IsEmpty()
        {
            return _head == null ? true : false;
        }

        public virtual void Enqueue(Eintrag<T> data)
        {
            Console.WriteLine(data.getData().ToString()+" wurde angefügt.");
            _tail.setNext(data);
            
            _tail = data;
        }

        public void Ausgabe()
        {
            

            Console.WriteLine("Gebe vollständige Liste aus:");
            if (IsEmpty() == true)
            {
                Console.WriteLine("Liste ist leer");
            }
            else
            {
                int i = 1;
                Eintrag<T> entry = _head;
                while (entry != null)
                {
                    Console.WriteLine(i + ". " + entry.getData().ToString());
                    if (entry.getNext() != null)
                    {
                        Console.WriteLine("Nächster =" + entry.getNext().getData().ToString());
                    }
                    else
                    { Console.WriteLine("ist letzter"); }

                    i++;
                    entry = entry.getNext();
                }

            }

            Console.WriteLine();
        }

        public void Dequeue()
        {
            Console.WriteLine("Führe Dequeue aus:");
            string ausgabe;
            if (IsEmpty() == true)
            {
                Console.WriteLine("Warteschlange ist leer");
            }
            else if (_head != null && _head.getNext() == null)
            {
                _tail = null;
                _head = null;
                Console.WriteLine("Letzter in der Warteschlange ist raus");
            }
            else if(_head != null && _head != _tail)
            {
               
                Console.WriteLine($"{_head.getData().ToString()} hat die Warteschlange verlassen");
                _head = _head.getNext();

            }


        }

        public virtual bool WertSuchen(T suchwert)
        {
            Console.WriteLine("Suche nach " + suchwert);
            int zähler = 1;
            bool gefunden = false;
            bool loopDone = false;
            Eintrag<T> aktuellesElement = _head;
            
            while(aktuellesElement.getNext() != null)
            {
                if (aktuellesElement.getData().CompareTo(suchwert) == 0)
                {
                    Console.WriteLine($"Wert {suchwert} gefunden an Position {zähler}\n");
                    return true;
                }
                if(aktuellesElement.getNext() != null)
                {
                    aktuellesElement = aktuellesElement.getNext();
                }

                zähler++;
            }
            loopDone = true;
            if (loopDone == true && suchwert.CompareTo(_tail.getData()) == 0)
               
            {
                zähler++;
                Console.WriteLine($"Treffer an Tail Position{this.AnzahlAusgeben()-1}");
                return true;
            }
            
            if (gefunden == false)
            {
                Console.WriteLine($"Wert {suchwert} ist nicht vorhanden.\n");
                return false;
            }
            Console.WriteLine($"Wert {suchwert} ist nicht vorhanden.\n");
            return false;
       
        }

        public virtual bool EintragLöschen(T suchwert)
        {
            Console.WriteLine($"Versuche Wert{suchwert} zu löschen:");
            bool gefunden = false;
            Eintrag<T> aktuellesElement = _head;
            while (aktuellesElement != null)
            {
                if (aktuellesElement.getNext() != null &&  aktuellesElement.getNext().getData().CompareTo(suchwert) == 0)
                {
                    Console.WriteLine($"Eintrag mit Wert {suchwert} gelöscht");
                    aktuellesElement.setNext(aktuellesElement.getNext().getNext());
                    Console.WriteLine();
                    gefunden = true;
                    
                    return true;
                }
                if (aktuellesElement.getNext() != null)
                {
                    aktuellesElement = aktuellesElement.getNext();
                }

                
            }
            if (gefunden == false)
            {
                Console.WriteLine($"Wert {suchwert} ist nicht vorhanden.");
                
            }
            return false;
        }


        public int AnzahlAusgeben()
        {
            //Console.WriteLine("Gebe Anzahl der Elemente aus:");

            int i = 0;
            Eintrag<T> entry = _head;
            while (entry != null)
            {
                i++;
                entry = entry.getNext();
            }
            return i;
        }
        public Eintrag<T>[] ToArray()
        {
            int i = 0;
            Eintrag<T> entry = _head;
            Eintrag<T>[] arr = new Eintrag<T>[AnzahlAusgeben()];
            while (entry != null)
            {
                arr[i] = entry;
                i++;
                entry = entry.getNext();
            }
            return arr;
        }


    }
}
