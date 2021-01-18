using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesFormGnecay
{
    class Calculator
    {
       
        public int sum(int s1,int s2)
        {
            
            return s1 + s2;
        }
        public double sumoverride(double s1, int s2,int s3)
        {

            return s1 + s2+s3;
        }
        public double dividing(double s1,double s2)
        {
           
            return s1 / s2;
        }
    }
}
