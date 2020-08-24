using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace STK
{
    class Funct
    {
        
        public int rand()
        {
            Random random = new Random();
            int outp = random.Next(1, 999);
            return outp;
        }
        
    }
}
