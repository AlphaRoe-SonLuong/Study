using System;
using System.Collections;
namespace ExHashTable
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Hashtable ht = new Hashtable();
            /*
             * void Add(object key, object value);
             * void Clear();
             * bool ContainsKey(object key);
             * bool ContainsValue(object value);
             * void Remove(object key);
             */
            ht.Add("a", "3");
            ht.Add("b", "4");

            if(ht.ContainsKey("c"))
            {
                Console.WriteLine("This key existed");
            }
            else
            {
                ht.Add("c", "5");
            }
            //get a collection of the keys
            ICollection key = ht.Keys;

            foreach(string k in key)
            {
                Console.WriteLine(k + ":" + ht[k]);
            }

            Stack st = new Stack();

            st.Push("A");
            st.Push("B");
            st.Push("C");
            st.Push("D");

            Console.WriteLine("Stack hien tai:");
            
            foreach(string c in st)
            {
                Console.WriteLine("-"+c);
            }
            Console.WriteLine("Them vao 1 phan E");

            st.Push("E");
            Console.WriteLine("Them vao 1 phan.");
            foreach (string c in st)
            {
                Console.WriteLine("-"+c);
            }
            Console.WriteLine("Phan tu lay ra ngoai truoc la: {0}",st.Peek());
            st.Pop();
            Console.WriteLine("Stack hien tai sau khi pop 1 phan tu");
            foreach(string c in st)
            {
                Console.WriteLine("-"+c);
            }
            Console.WriteLine("------------QUEUE-----------");
            Queue q = new Queue();
            q.Enqueue("A");
            q.Enqueue("B");
            q.Enqueue("C");
            q.Enqueue("D");

            Console.WriteLine("Queue hien tai la:");
            foreach(string c in q)
            {
                Console.Write(c + "-");
            }
            Console.WriteLine("Them 1 phan tu E vao Queue");
            q.Enqueue("E");
            Console.WriteLine("Queue hien tai la:");
            foreach (string c in q)
            {
                Console.Write(c + "-");
            }
            Console.WriteLine("Lay 1 phan tu ra {0}", q.Peek());
            q.Dequeue();

            Console.WriteLine("Queue hien tai la:");
            foreach (string c in q)
            {
                Console.Write(c + "-");
            }

            Console.ReadKey();
        }
    }
}
