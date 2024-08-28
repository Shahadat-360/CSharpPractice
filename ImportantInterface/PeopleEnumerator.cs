using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantInterface
{
    public class PeopleEnumerator : IEnumerator<Person>
    {   private Person[] _persons; 
        private int _index=-1;
        public Person Current => _persons[_index];

        object IEnumerator.Current => Current;

        public PeopleEnumerator(Person[] persons)
        {
            _persons = persons;
        }
        public void Dispose()
        {
            _persons = null;
        }

        public bool MoveNext()
        {
            _index++;
            return _index < _persons.Length;
        }

        public void Reset()
        {
            _index = -1;
        }
    }
}
