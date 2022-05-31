using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahcesi
{
    public class Kemirgen : Hayvanlar
    {
        protected void kemir()
        {
            Console.WriteLine("Kemirgenler Kemirerek Hayatlarını Sürdürürler");
        }
    }
    public class Sıcan : Kemirgen
    {
        public Sıcan()
        {
            base.beslenme();
            base.solunum();
            base.kemir();
            tırman();
        }
        public void tırman()
        {
            Console.WriteLine("Sıçanlar tırmanma konusunda ustalaşmışlardır");
        }
    }
    public class Kunduz : Kemirgen
    {
        public Kunduz()
        {
            base.beslenme();
            base.solunum();
            base.kemir();
            yüzme();

        }
        public void yüzme()
        {
            Console.WriteLine("Kunduzlar hayatlarının bir çoğunu suda yüzerek geçirirler");
        }
    }
}
