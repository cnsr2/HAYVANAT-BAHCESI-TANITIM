using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahcesi
{
    public abstract class Kedigil : Hayvanlar
    {
        protected void avlan()
        {
            Console.WriteLine("Kedigiller yaşamlarını avlanarak sürdürürler");
        }
    }
    public class Aslan : Kedigil
    {
        public Aslan()
        {
            base.beslenme();
            base.solunum();
            base.avlan();
            sürüYasami();
        }
        public void sürüYasami()
        {
            Console.WriteLine("Aslanlar sürü halinde yaşarlar");
        }
    }
    public class Kaplan : Kedigil
    {
        public Kaplan()
        {
            base.beslenme();
            base.solunum();
            base.avlan();
            yalnizYasam();
        }
        public void yalnizYasam()
        {
            Console.WriteLine("Kaplanlar yalnız yaşam sürerler");
        }
    }
}