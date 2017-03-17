using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Chim:IBay
    {
        public void Bay()
        {
            Console.WriteLine("Chim: Bay");
        }
        public void Chay()
        {
            Console.WriteLine("Chim: Chay");
        }
    }
}
