using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahcesi
{
    public abstract class Hayvanlar
    {
        protected void solunum()
        {
            Console.WriteLine("Hayvanlar Solunum Yaparlar");
        }
        protected void beslenme()
        {
            Console.WriteLine("Hayvanlar Beslenme İhtiyacı Duyarlar");
        }
    }
}
