using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_practicum
{
    abstract class Person
    {
        public string Name { get; set; }
        public abstract void SayHello();
    }
}
