using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Person : IPersonable
    {   
        public int id { get; set; }

        public string NameInit { get; init; }

        public Person(int id, string NameInit)
        {
            this.id = id;
            this.NameInit = NameInit;
        }

        public void CreatePerson(int id)
        {
            Person person = new Person(id, NameInit);
        }

        public void DeletePerson(PersonStruct person)
        {
            throw new NotImplementedException();
        }
    }
}
