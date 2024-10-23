using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleList
{
    internal class Eintrag<T> where T: IComparable
    {
        T _data;
        Eintrag<T> _next;
        public Eintrag(T data)
        {
            _data = data;
            _next = default(Eintrag<T>);
        }

        public void setNext(Eintrag<T> next)
        {
            this._next = next;
        }
        public Eintrag<T> getNext()
        {
            return _next;
        }
        public T getData()
        { return _data; }  
    }
}
