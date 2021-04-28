using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Person : IPersonable
    {
        public string NameInit { get; init; }

        public ProductType? ProductType { get; set; }

        public void CreatePerson(int id)
        {
            throw new NotImplementedException();
        }

        public void DeletePerson(PersonStruct person)
        {
            throw new NotImplementedException();
        }
    }

    [Flags]
    public enum ProductType
    {
        None,
        Tv,
        Computer,
        Cellphone,
    }
}
