using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Source.Interface
{
    /// <summary>
    ///         Enumerator<Type>
    /// </summary>
    public class DynamicArrayEnumerator<Type> : IEnumerator<Type>
    {
        private DynamicArray<Type> _dArray;
        private Type _current;
        private int _indx;


        public DynamicArrayEnumerator(DynamicArray<Type> dArray)
        {
            _dArray = dArray;
            _current = default(Type);
            _indx = 0;
        }


        Type IEnumerator<Type>.Current => _current;
        object IEnumerator.Current => _current;


        void IDisposable.Dispose() { }
        bool IEnumerator.MoveNext()
        {
            if(_indx < _dArray.Length)
            {
                _current = _dArray[_indx];
                _indx++;
                return true;
            }
            _indx = _dArray.Length + 1;
            _current = default(Type);
            return false;
        }
        void IEnumerator.Reset()
        {
            _indx = 0;
            _current = default(Type);
        }
    }
}
