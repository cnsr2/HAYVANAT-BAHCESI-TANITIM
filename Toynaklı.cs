using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahcesi
{
    public abstract class Toynaklı : Hayvanlar
    {
        protected void nal()
        {
            Console.WriteLine("Toynaklı Hayvanlara Nal Takım İşlemi Uygulanır");
        }
        public virtual void speak()
        {
            Console.WriteLine("Toynaklı Hayvanlar Kişneyerek Ses Çıkartırlar");
        }
        public virtual void binek()
        {
            Console.WriteLine("Binek Olarak Kullanılabilirler");
        }
    }
    public class At : Toynaklı
    {
        public At()
        {
            base.beslenme();
            base.solunum();
            base.nal();
            base.speak();
            base.binek();
        }
        
        public override void binek()
        {
            base.binek();
        }
    }
    public class Esek : Toynaklı
    {
        public Esek()
        {
            base.beslenme();
            base.solunum();
            base.nal();
            base.binek();
            speak();

        }
        public override void speak()
        {
            Console.WriteLine("Eşekler anırarak iletişim kurarlar");

        }
    }
    public class Zebra : Toynaklı
    {
        public Zebra()
        {
            base.beslenme();
            base.solunum();
            base.nal();
            speak();
        }
        public override void speak()
        {
            Console.WriteLine("Zebralar Eşeklerden daha tiz bir sesle anırarak iletişim kurarlar");
        }
    }

}
