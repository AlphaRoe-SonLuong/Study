using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Teacher:Person
    {
        public void GiangDay()
        {
            Console.WriteLine("Bat dau giang day!!!");
        }
        public override void LoiChao()
        {
            Console.WriteLine("Giao vien chao lop");
        }
    }
}
