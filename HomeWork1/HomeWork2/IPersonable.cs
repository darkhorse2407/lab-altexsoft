using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    interface IPersonable
    {
        void CreatePerson(int id);
        void DeletePerson(PersonStruct person);
    }
}