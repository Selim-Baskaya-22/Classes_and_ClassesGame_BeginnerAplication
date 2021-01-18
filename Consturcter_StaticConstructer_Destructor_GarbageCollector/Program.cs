using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consturcter_StaticConstructer_Destructor_GarbageCollector
{

    class Example2
    {
        public string[] names = new string[10];
        public string this[int index]
        {
            get { return names[index]; }
            set { names[index] = value.ToUpper(); }
        }
        public void color()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //constructers();
            Example2 example2 = new Example2();
            example2.color();
            example2[2] = "selim";
            example2[3] = "başkaya";
            Console.WriteLine("Ad={0} Soyad={1}", example2[2], example2[3]);
            Console.Read();
        }
    





        private static void constructers()
        {
            for (int i = 0; i < 10; i++)
            {
                new Ornek(i);

            }
            Console.WriteLine("************");
            GC.Collect();
        }
    }
    public class Ornek
    {

        public int numara{ get; set; }
       
        public Ornek(int id)
        {
            numara = id;
            Console.WriteLine("{0} Nesne Oluşturuldu!!!",numara);
        }
        static Ornek()
        {
           
            Console.WriteLine("Static ana nesne oluşturuldu");
        }
  
        ~Ornek()
        {

            Console.WriteLine("{0} Nesnesi Silindi!!",numara);
           
        }
        
    }
}
