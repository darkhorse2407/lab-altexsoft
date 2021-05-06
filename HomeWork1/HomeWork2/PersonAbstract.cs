using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public abstract class PersonAbstract
    {
        public string Name { get; set; }

        public abstract string GetFullname();

        public PersonAbstract(int id)
        {

        }
    }
}
