using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public class Client : PersonAbstract
    {
        private int id { get; set; }

        private new string Name { get; set; }

        public Client(int id, string Name) : base(id)
        {
            this.id = id;
            this.Name = Name;
        }

        public override string GetFullname()
        {
            return Name;
        }
    }
}
