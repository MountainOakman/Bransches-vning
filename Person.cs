using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranschesÖvning
{
    internal class Person
    {
        private string v1;
        private int v2;

        public Person(string v)
        {
            V = v;
        }

        public Person(string v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string V { get; }
    }
}
