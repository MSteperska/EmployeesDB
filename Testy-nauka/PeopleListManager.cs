using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testy_nauka
{


    public class PeopleListManager
    {
        private List<Person> PeopleList;

        public PeopleListManager()
        {
            PeopleList = new List<Person>();
        }

        public void AddPerson(Person person)
        {
            PeopleList.Add(person);
        }

        public List<Person> GetAllPersons()
        {
            return PeopleList;
        }
    }
}
