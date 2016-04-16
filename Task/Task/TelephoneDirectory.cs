using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Task
{
    class TelephoneDirectory : IEnumerable
    {

        public List<Person> accounts = new List<Person>(50);

        public TelephoneDirectory()
        {
        }
        public IEnumerator GetEnumerator()
        {
            return accounts.GetEnumerator();
        }


    }
}
