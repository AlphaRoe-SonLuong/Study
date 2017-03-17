using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Student:Person
    {
        public void goToClass()
        {
            Console.WriteLine("I'm going to class!!!");
        }
        public void tbTuoi()
        {
            Console.WriteLine("Tuoi cua hoc sinh la {0}", age);
        }
        public override void LoiChao()
        {
            Console.WriteLine("Hoc sinh chao lop");
        }
    }
}
