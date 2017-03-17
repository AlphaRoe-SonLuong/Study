using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvent
{
    public delegate string myDela(String s);
    public delegate int DelBinhPhuong(int x);
    class Program
    {
        event myDela myEvent;

        public Program()
        {
            this.myEvent += new myDela(this.Welcome);
        }
        public String Welcome(string user)
        {
            return "welcome "+user;
        }
        public static int tinhtong(int a)
        {
            return a*a;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            DelBinhPhuong t = new DelBinhPhuong(tinhtong);
            t(3);
            Console.WriteLine(t);
            string result = obj.myEvent("tutorio point");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
