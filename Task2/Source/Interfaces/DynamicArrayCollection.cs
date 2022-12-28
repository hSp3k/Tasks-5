using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Source.Interface
{
    /// <summary>
    ///         ICollection<Type>
    /// </summary>
    public class DynamicArrayCollection<Type> : ICollection<Type>
    {
        IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
        {
            return _dArray.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_dArray).GetEnumerator();
        }


        private DynamicArray<Type> _dArray;


        public DynamicArrayCollection(DynamicArray<Type> dArray)
        {
            _dArray = dArray;
        }


        bool ICollection<Type>.IsReadOnly => ((ICollection<Type>)_dArray).IsReadOnly;


        int ICollection<Type>.Count
        {
            get
            {
               return _dArray.Length;
            }
        }
        void ICollection<Type>.Add(Type item)
        {
           _dArray.Add(item);
        }
        void ICollection<Type>.Clear()
        {
           _dArray.Clear();
        }
        bool ICollection<Type>.Contains(Type item)
        {
           return _dArray.Contains(item);
        }
        void ICollection<Type>.CopyTo(Type[] array, int arrayIndex)
        {
           _dArray.CopyTo(array, arrayIndex);
        }
        bool ICollection<Type>.Remove(Type item)
        {
           return _dArray.Remove(item);
        }
    }
}
