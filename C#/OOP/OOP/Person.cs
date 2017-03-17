using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    abstract class Person
    {
        protected int age;

        public void setAge(int t)
        {
            age = t;
        }
        public abstract void LoiChao();
    }
}
