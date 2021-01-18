using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rastgele_Sayı_Bulma_Oyunu
{
    class Game
    {
        public int randnumber { get; set; }

        public string result; 
        public Game()
        {
            Random rand = new Random();
            this.randnumber = rand.Next(1,101);           
        }
        public string Result(int a)
        {
           
            
            if (a<randnumber)
            {
                return result="Yukarı";
            }
            if (a > randnumber)
            {
                return result="Aşağı";
            }
            if (a == randnumber)
            {
                return result="T";
            }
            return "";
        }
    }
}
