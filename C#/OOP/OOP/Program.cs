using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class HinhChuNhat
    {
        public double dai;
        public double rong;

        public void ganDayChuyen()
        {
            dai = 2.3;
            rong = 5.5;
        }

        public double dientich()
        {
            return dai * rong;
        }
        
        public void Display()
        {
            Console.WriteLine("Dai: {0}",dai);
            Console.WriteLine("Rong: {0}", rong);
            Console.WriteLine("Dien tich: {0}",dientich());
        }
    }
    class HinhTron
    {
        protected double bankinh;
        public void docTuPhim()
        {
            Console.WriteLine("Nhap vao ban kinh:");
            bankinh = Convert.ToDouble(Console.ReadLine());
        }
        public double chuvi()
        {
            return bankinh * 3.14;
        }
        public void Hien()
        {
            Console.WriteLine("Ban kinh: {0}", bankinh);
            Console.WriteLine("Chu vi: {0}", chuvi());
        }
    }
    class HinhVuong:HinhChuNhat
    {
        public new double dai;
        public new double rong;
        public new double dientich()
        {
            return dai * dai;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            /*HinhChuNhat cn = new HinhChuNhat();
            cn.dai = 3.4;
            cn.rong = 5.4;
            cn.Display();
            ///////////hinh tron///////////
            HinhTron t = new HinhTron();
            t.docTuPhim();
            t.Hien();*/
            /******ke thua trong C#********/
            Student s = new Student();
            Teacher t = new Teacher();
            s.setAge(19);
            s.LoiChao();
            s.tbTuoi();
            s.goToClass();
            t.LoiChao();
            t.GiangDay();
            /******Inteface C#********/
            Chim c = new Chim();
            c.Bay();
            c.Chay();
            MayBay mb = new MayBay();
            mb.Bay();
            mb.Chay();

            /*****************/

            Console.ReadKey();
        }
    }
}
