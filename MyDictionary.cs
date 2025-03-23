using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{

    internal class MyDictionary<keyT, valueT> : ICollection<KeyValuePair<keyT, valueT>>
    {
        private SortedSet<Node<keyT, valueT>>[] Entries = new SortedSet<Node<keyT, valueT>>[] { };
        private keyT[] Buckets = new keyT[] { };

        public int Capacity { get; private set; }
        public int Count { get; private set; }

        public bool IsReadOnly => throw new NotImplementedException();

        public MyDictionary()
        {

        }
        
        #region ICollection methods
        public void Add(KeyValuePair<keyT, valueT> item)
        {
            //0. Calculate HashCode of key
            //1. Check key in Buckets
            //2. If Contains throw
            //3. Buckets add [hash]:(key,value) pair
            //If (Capacity <= HashCode)
            //{
            //  Capacity = HashCode * 2;
            //  Length +=1;
            //  Buckets update length(capacity);
            //  Buckets[HashCode] = new SortedSet<Node<keyT, valueT>>(new Node(key,value))
            //  return;
            //}
            //If (Buckets[HashCode] = null)
            //{
            //  Buckets[HashCode] = new();
            //}
            //Buckets[HashCode].Add(new Node(key, value))
            //
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(KeyValuePair<keyT, valueT> item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(KeyValuePair<keyT, valueT>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(KeyValuePair<keyT, valueT> item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<KeyValuePair<keyT, valueT>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion
    }
}
