using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesGençay
{
    class Program
    {
        static void Main(string[] args)
        {
            metod1();
            metod2();
            Console.WriteLine(sum()); 
            int sonuc=sum2(25,25);
            Console.WriteLine(sonuc);
            Console.Read();
        }
        //metodlar önce tanımlanır sonra kullanılır
        //geriye değer döndürmeyen, parametre almayan metod
        static void metod1()
        {
            Console.WriteLine("geriye değer döndürmeyen, parametre almayan metod");
        }
        //geriye değer döndürmeyen parametre alan metod
        static void metod2(int a=5,int b=2)
        {
            int sonuc = a + b;
            Console.WriteLine(sonuc);
        }
        //geriye değer döndüren parametre almayan metod
        static int sum()
        {
            return 3 + 3;
        }
        //geriye değer döndüren parametre alan metod
        static int sum2(int s1,int s2)
        {
            return s1 + s2;

        }
    }


}
