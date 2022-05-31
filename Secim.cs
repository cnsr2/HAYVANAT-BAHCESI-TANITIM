using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahcesi
{
    public class Secim
    {
        public void anaMenuListesi()
        {
            ILK_SECİM_DON:
            Console.WriteLine("Hoşgeldiniz Bilgilerini Görmek İstediğiniz Canlıyı Aşağıda Belirtilen Şekilde Seçiniz.");
            Console.WriteLine("(1) Toynaklılar (At,Eşek,Zebra)");
            Console.WriteLine("(2) Kedigiller  (Aslan,Kaplan)");
            Console.WriteLine("(3) Kemirgenler (Sıçan,Kunduz)");
            int ilksecim = Convert.ToInt32(Console.ReadLine());
            switch (ilksecim)
            {
                case 1:
                    TOYNAKLI_SECİM_DON:
                    Console.WriteLine("***** Toynaklılar *****");
                    Console.WriteLine("Lütfen bir seçim yapınız");
                    Console.WriteLine("(1) Atlar");
                    Console.WriteLine("(2) Eşekler");
                    Console.WriteLine("(3) Zebralar");
                    int toynaklısecim = Convert.ToInt32(Console.ReadLine());

                    switch (toynaklısecim)
                    {
                        case 1:
                            Console.WriteLine("***** Atlar *****");
                            At at = new At();

                            break;
                        case 2:
                            Console.WriteLine("***** Eşekler *****");
                            Esek esek = new Esek();
                            break;
                        case 3:
                            Console.WriteLine("***** Zebralar *****");
                            Zebra zebra = new Zebra();
                            break;
                        default:
                            Console.WriteLine("Yanlış Tuşlama Yaptınız Tekrar Deneyiniz ");
                            goto TOYNAKLI_SECİM_DON;
                            break;
                    }
                    TOYNAKLI_TEKRAR_SORGU:
                    Console.WriteLine("Tekrar Listeleme Yapmak İstiyor Musunuz ? Evet(e) Hayır(h)");
                    char toynaklıtekrarislem = Convert.ToChar(Console.ReadLine());
                    if (toynaklıtekrarislem == 'e')
                    {
                        Console.WriteLine("Yönlendirililyorsunuz");
                        goto ILK_SECİM_DON;
                    }
                    else if (toynaklıtekrarislem == 'h')
                    {
                        Console.WriteLine("Çıkış İşlemi Yapılıyor...");
                        Console.WriteLine("İyi Günler ^^");
                    }
                    else
                    {
                        Console.WriteLine("Lütfen e yada h ile Cevap Veriniz");
                        goto TOYNAKLI_TEKRAR_SORGU;
                    }
                    break;
                case 2:
                    KEDİGİLLER_SECİM_DON:
                    Console.WriteLine("***** Kedigiller *****");
                    Console.WriteLine("Lütfen bir seçim yapınız");
                    Console.WriteLine("(1) Aslanlar");
                    Console.WriteLine("(2) Kaplanlar");
                    int kedigilsecim = Convert.ToInt32(Console.ReadLine());
                        switch (kedigilsecim)
                        {
                            case 1:
                                Console.WriteLine("***** Aslanlar *****");
                                Aslan aslan = new Aslan();
                                break;
                            case 2:
                                Console.WriteLine("***** Kaplanlar *****");
                                Kaplan kaplan = new Kaplan();
                                break;
                            default:
                                Console.WriteLine("Yanlış Tuşlama Yaptınız Tekrar Deneyiniz");
                                goto KEDİGİLLER_SECİM_DON;
                                break;
                        }
                    KEDİGİLLER_TEKRAR_SORGU:
                    Console.WriteLine("Tekrar Listeleme Yapmak İstiyor Musunuz ? Evet(e) Hayır(h)");
                    char kedigillertekrarislem = Convert.ToChar(Console.ReadLine().ToLower());
                    if (kedigillertekrarislem == 'e')
                    {
                        Console.WriteLine("Yönlendirililyorsunuz");
                        goto ILK_SECİM_DON;
                    }
                    else if (kedigillertekrarislem == 'h')
                    {
                        Console.WriteLine("Çıkış İşlemi Yapılıyor...");
                        Console.WriteLine("İyi Günler ^^");
                    }
                    else
                    {
                        Console.WriteLine("Lütfen e yada h ile Cevap Veriniz");
                        goto KEDİGİLLER_TEKRAR_SORGU;
                    }
                    break;
                case 3:
                    KEMİRGENLER_SECİM_DON:
                    Console.WriteLine("***** Kemirgenler *****");
                    Console.WriteLine("Lütfen bir seçim yapınız");
                    Console.WriteLine("(1) Sıçanlar");
                    Console.WriteLine("(2) Kunduzlar");
                    int kemirgensecim = Convert.ToInt32(Console.ReadLine());
                        switch (kemirgensecim)
                        {
                            case 1:
                                Console.WriteLine("***** Sıçanlar *****");
                                Sıcan sıcan = new Sıcan();
                                break;
                            case 2:
                                Console.WriteLine("***** Kunduzlar *****");
                                Kunduz kunduz = new Kunduz();
                                break;
                            default:
                                Console.WriteLine("Yanlış Tuşlama Yaptınız Tekrar Deneyiniz");
                                goto KEMİRGENLER_SECİM_DON;
                                break;
                        }
                    KEMIRGENLER_TEKRAR_SORGU:
                    Console.WriteLine("Tekrar Listeleme Yapmak İstiyor Musunuz ? Evet(e) Hayır(h)");
                    char kemirgenlertekrarislem = Convert.ToChar(Console.ReadLine().ToLower());
                    if (kemirgenlertekrarislem == 'e')
                    {
                        Console.WriteLine("Yönlendirililyorsunuz");
                        goto ILK_SECİM_DON;
                    }
                    else if (kemirgenlertekrarislem == 'h')
                    {
                        Console.WriteLine("Çıkış İşlemi Yapılıyor...");
                        Console.WriteLine("İyi Günler ^^");
                    }
                    else
                    {
                        Console.WriteLine("Lütfen e yada h ile Cevap Veriniz");
                        goto KEMIRGENLER_TEKRAR_SORGU;
                    }
                    break;
                            default:
                        Console.WriteLine("Yanlış Tuşlama Yaptınız Lütfen Tekrar Deneyiniz");
                        goto ILK_SECİM_DON;
                    break;
            }
        }
    }
}
