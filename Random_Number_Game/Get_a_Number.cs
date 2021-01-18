using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rastgele_Sayı_Bulma_Oyunu
{
    class Get_a_Number
    {
        public int rastnumber = 0;
        public enum result {asagı,yukarı,tamam }
        public int hak {get; set; }
        public int can { get; set; }

        public Get_a_Number()
        {
            Random random = new Random();
            this.rastnumber = random.Next(1, 101);
            hak = 10;
            can = 1000;
        }
        public result bul(int tahmin)
        {
            if (tahmin>rastnumber)
            {
                return result.asagı;
            }
            else if (tahmin< rastnumber)
            {
                return result.yukarı;

            }
            else if (tahmin == rastnumber)
            {
                return result.tamam;
            }
            return 0; 
           
        }
    }
}
