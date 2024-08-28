using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantInterface
{
    public class People:IEnumerable<Person>,ICollection<Person>
    {
        private Person[] _persons;
        private int _index;
        public People(int _size)
        {
            _index= 0;
            _persons = new Person[_size];
        }

        public int Count => _persons.Length;

        public bool IsReadOnly => true;

        public void Add(Person item)
        {
            if(_index<_persons.Length) _persons[_index++] = item;
        }

        public void Clear()
        {
            _index = 0;
        }

        public bool Contains(Person item)
        {
            foreach(var p in _persons)
            {
                if(p.Equals(item)) return true;
            }
            return false;
        }

        public void CopyTo(Person[] array, int arrayIndex)
        {
            for(int i=arrayIndex; i<_persons.Length; i++) array[_index++]= _persons[i];
        }


        public bool Remove(Person item)
        {
            for(int i=0;i<_persons.Length;i++)
            {
                if (_persons[i].Equals(item)) {
                    _persons[i] = null;
                    return true;
                }
            }
            return false;
        }

        public IEnumerator<Person> GetEnumerator()
        {
            return new PeopleEnumerator(_persons);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
