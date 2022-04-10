using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sual_7.book
{
    public class Author
    {

        static int counter = 0;

        public readonly int id;
        public string name;
        public string surName;
       

        public Author()

        {
            this.id = ++counter;

        }
        public Author(string name)
            :this()
        {
            this.name = name;

        }
        public Author(string name, string surName)
            :this(name)
        {
            this.surName = surName;

        }
       
        public override string ToString()
        {
            return $"{name} {surName}";
        }

    }
}
