using System;
using System.Collections;
namespace CollectionArrayList
{
    class Program
    {
        public struct NhanVien
        {
            public int maNV;
            public string tenNV;
            public int tuoi;
        };
        
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            NhanVien nv = new NhanVien();
            nv.maNV = 123;
            nv.tenNV = "Nguyen Van A";
            nv.tuoi = 23;
            arr.Add(nv);

            NhanVien nv2 = new NhanVien();
            nv2.maNV = 234;
            nv2.tenNV = "Nguyen Van B";
            nv2.tuoi = 25;
            arr.Add(nv2);
            Console.WriteLine("Danh sách Nhan vien:");
            Console.WriteLine("---------");
            foreach (NhanVien i in arr)
            {
                
                Console.WriteLine(i.maNV);
                Console.WriteLine(i.tenNV);
                Console.WriteLine(i.tuoi);
                Console.WriteLine("------------");
            }
            Console.ReadKey();
        }
    }
}
