using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class MayBay:IBay,IChay
    {
        public void Bay()
        {
            Console.WriteLine("May bay: Bay");
        }
        public void Chay()
        {
            Console.WriteLine("May bay: Chay");
        }
    }
}
