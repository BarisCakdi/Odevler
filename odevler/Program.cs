using System.ComponentModel.Design;
using System.Data;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Reflection.Emit;
using System.Runtime.Intrinsics;

namespace odevler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GİRİŞ
            Console.WriteLine("Merhaba Ödevler bölümüne hoş geldiniz!");
            Console.WriteLine("--------------------------------------");
            Console.Write("Lütfen kullanıcı adı giriniz: ");
            string kullaniciadi = Console.ReadLine();
        //ANA MENÜ

        anamenu:
            Console.Clear();
            Console.WriteLine("Hoş geldin " + kullaniciadi);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("1. Hesap Makinesi uygulaması");
            Console.WriteLine("2. Alışveriş hesaplama");
            Console.WriteLine("3. Taş Kağıt Makas Oyunu");
            Console.WriteLine("4. Quiz uygulaması");
            Console.WriteLine("5. Çıkış yap");
            Console.WriteLine("-------------------------------------------");
            Console.Write("Lütfen denemek istediğin uygulamayı seç: ");
            string appchoose = Console.ReadLine(); //UYGULAMA SEÇİMİ

            if (appchoose == "1")
            {
            //HESAP MAKİNESİ  
            versiyonSecimi:
                Console.Clear();
                Console.WriteLine("Merhaba " + kullaniciadi + " hesaplama uygulamasına hoş geldin!");
                Console.WriteLine("=========================================");
                Console.WriteLine("1.Versiyon: Girilen rakamların toplamı ve ortalaması için");
                Console.WriteLine("2.Versiyon: İşlem seçimi ve sonucu");
                Console.WriteLine("3.Versiyon: Gelişmiş hesap makinesi");
                Console.WriteLine("4: Ana menüye dönüş");
                Console.WriteLine("=========================================");
                Console.Write("Lütfen yapmak istediğiniz Versiyon sistemini seçiniz:");
                string calcu = Console.ReadLine();
                if (calcu == "1")
                {
                //V1 kısmı
                v1:
                    Console.Clear();
                    Console.WriteLine("Versiyon 1");
                    Console.Write("Kaç adet sayı girmek istiyorsunuz: ");
                    int adet = int.Parse(Console.ReadLine());
                    int toplam = 0;
                    double ortalama = 0;
                    for (int i = 1; i <= adet; i++)
                    {
                        Console.Write(i + ". rakamı giriniz:");
                        toplam += int.Parse(Console.ReadLine());
                    }
                    ortalama = (double)toplam / (double)adet;
                    Console.Clear();
                    Console.WriteLine("Toplamı: " + toplam);
                    Console.WriteLine("Ortalaması: " + ortalama);
                    Console.WriteLine("Devam etmek için 'D' basınız");
                    Console.WriteLine("Versiyon seçmek için 'V' basınız");
                    string versiyon = Console.ReadLine();
                    if (versiyon == "d" || versiyon == "D")
                    {
                        goto v1;
                    }
                    else
                    {
                        goto versiyonSecimi;
                    }
                }
                else if (calcu == "2")
                {
                //V2 kısmı
                v2:
                    Console.Clear();
                    Console.WriteLine("Versiyon 2");
                    Console.WriteLine("1.Toplama");
                    Console.WriteLine("2.Çıkarma");
                    Console.WriteLine("3.Çarpma");
                    Console.WriteLine("4.Bölme");
                    Console.WriteLine("5.Versiyon seçimine dön");
                    Console.WriteLine("Hangi matematik işlemini yapmak istersiniz:");
                    string islem = Console.ReadLine();
                    if (islem == "1")
                    {
                        Console.WriteLine("Toplama İşlemi");
                        Console.Write("Kaç adet sayı girmek istiyorsunuz: ");
                        int adet = int.Parse(Console.ReadLine());
                        int toplam = 0;
                        for (int i = 1; i <= adet; i++)
                        {
                            Console.Write(i + ". rakamı giriniz:");
                            toplam += int.Parse(Console.ReadLine());
                        }
                        Console.Clear();
                        Console.WriteLine("Toplamı: " + toplam);
                        Console.WriteLine("Devam etmek için 'D' basınız");
                        Console.WriteLine("Versiyon seçmek için 'V' basınız");
                        string versiyon = Console.ReadLine();
                        if (versiyon == "d" || versiyon == "D")
                        {
                            goto v2;
                        }
                        else
                        {
                            goto versiyonSecimi;
                        }
                    }
                    else if (islem == "2")
                    {
                        Console.WriteLine("Çıkarma İşlemi");
                        Console.Write("Kaç adet sayı girmek istiyorsunuz: ");
                        int adet = int.Parse(Console.ReadLine());
                        int sonuc = 0;
                        for (int i = 1; i <= adet; i++)
                        {
                            Console.Write(i + ". rakamı giriniz:");
                            if (i == 1)
                            {
                                sonuc = int.Parse(Console.ReadLine());
                            }
                            else
                            {
                                int cikar = int.Parse(Console.ReadLine());
                                sonuc -= cikar;
                            }
                        }
                        Console.Clear();
                        Console.WriteLine("Sonuç: " + sonuc);
                        Console.WriteLine("Devam etmek için 'D' basınız");
                        Console.WriteLine("Versiyon seçmek için 'V' basınız");
                        string versiyon = Console.ReadLine();
                        if (versiyon == "d" || versiyon == "D")
                        {
                            goto v2;
                        }
                        else
                        {
                            goto versiyonSecimi;
                        }
                    }
                    else if (islem == "3")
                    {
                        Console.WriteLine("Çarpma İşlemi");
                        Console.Write("Kaç adet sayı girmek istiyorsunuz: ");
                        int adet = int.Parse(Console.ReadLine());
                        int carpim = 1;
                        for (int i = 1; i <= adet; i++)
                        {
                            Console.Write(i + ". rakamı giriniz:");
                            int sayi = int.Parse(Console.ReadLine());

                            carpim *= sayi;
                        }
                        Console.Clear();
                        Console.WriteLine("Toplamı: " + carpim);
                        Console.WriteLine("Devam etmek için 'D' basınız");
                        Console.WriteLine("Versiyon seçmek için 'V' basınız");
                        string versiyon = Console.ReadLine();
                        if (versiyon == "d" || versiyon == "D")
                        {
                            goto v2;
                        }
                        else
                        {
                            goto versiyonSecimi;
                        }
                    }
                    else if (islem == "4")
                    {
                        Console.WriteLine("Bölme İşlemi");
                        Console.Write("Kaç adet sayı girmek istiyorsunuz: ");
                        int adet = int.Parse(Console.ReadLine());
                        double bolum = 0;
                        for (int i = 1; i <= adet; i++)
                        {
                            Console.Write(i + ". rakamı giriniz:");
                            int sayi = int.Parse(Console.ReadLine());

                            if (i == 1)
                            {
                                bolum = sayi;
                            }
                            else
                            {
                                if (sayi != 0)
                                {
                                    bolum /= sayi;
                                }
                                else
                                {
                                    Console.WriteLine("Hata: Sıfıra bölme hatası!");
                                    return;
                                }
                            }
                        }

                        Console.Clear();
                        Console.WriteLine("Toplamı: " + bolum);
                        Console.WriteLine("Devam etmek için 'D' basınız");
                        Console.WriteLine("Versiyon seçmek için 'V' basınız");
                        string versiyon = Console.ReadLine();
                        if (versiyon == "d" || versiyon == "D")
                        {
                            goto v2;
                        }
                        else
                        {
                            goto versiyonSecimi;
                        }
                    }
                    else if (islem == "5")
                    {
                        Console.WriteLine("ana menü");
                        goto versiyonSecimi;
                    }
                    else
                    {
                        goto v2;
                    }

                }
                else if (calcu == "3")
                {
                //V3 kısmı
                v3:
                    Console.Clear();
                    Console.WriteLine("Gelişmiş hesap makinesi");
                    Console.WriteLine("========================");
                    Console.Write("Sayı giriniz: ");
                    double inputsayi = Convert.ToDouble(Console.ReadLine());
                    bool sayi = true;
                    while (sayi)
                    {
                        Console.WriteLine("Yapmak istediğiniz işlem");
                        Console.WriteLine("1.Toplama");
                        Console.WriteLine("2.Çıkartma");
                        Console.WriteLine("3.Çarpma");
                        Console.WriteLine("4.Bölme");
                        Console.WriteLine("5.Sonuç");
                        Console.Write("Seçim: ");
                        string inputSecim = Console.ReadLine();
                        if (inputSecim == "1")
                        {
                            Console.Write("Sayı giriniz: ");
                            double toplama = Convert.ToDouble(Console.ReadLine());
                            inputsayi += toplama;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Toplama sonucu: " + inputsayi);
                            Console.ResetColor();
                        }
                        else if (inputSecim == "2")
                        {
                            Console.Write("Sayı giriniz: ");
                            double cıkartma = Convert.ToDouble(Console.ReadLine());
                            inputsayi -= cıkartma;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Çıkartma sonucu: " + inputsayi);
                            Console.ResetColor();
                        }
                        else if (inputSecim == "3")
                        {
                            Console.Write("Sayı giriniz: ");
                            double carpma = Convert.ToDouble(Console.ReadLine());
                            inputsayi *= carpma;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Çarpma sonucu: " + inputsayi);
                            Console.ResetColor();
                        }
                        else if (inputSecim == "4")
                        {
                            Console.Write("Sayı giriniz: ");
                            double bolme = Convert.ToDouble(Console.ReadLine());
                            inputsayi /= bolme;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Bölme sonucu: " + inputsayi);
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine("Hesaplama sonucu: " + inputsayi);
                            sayi = false;
                            Console.WriteLine("Devam etmek için 'D' basınız");
                            Console.WriteLine("Versiyon seçmek için 'V' basınız");
                            string versiyon = Console.ReadLine();
                            if (versiyon == "d" || versiyon == "D")
                            {
                                goto v3;
                            }
                            else
                            {
                                goto versiyonSecimi;
                            }
                        }

                    }
                }
                else
                {
                    goto anamenu;
                    //Ana menüye dönüş

                }
            } 
            else if (appchoose == "2")
            {
                //MARKET UYGULAMASI
                mhome:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("MARKET UYGULAMASI");
                Console.ResetColor();
                Console.WriteLine("=================================================================");
                Console.WriteLine("Merhaba " + kullaniciadi + " market uygulamasına hoş geldin!");
                Console.WriteLine("=================================================================");
                Console.WriteLine("1.Versiyon: Ürün seçme ve toplama");
                Console.WriteLine("2.Versiyon: Hangi ürünleri aldığını görüp fiyat görme");
                Console.WriteLine("3.Versiyon: Ödeme işlemi gerçekleştirip para üstü verme");
                Console.WriteLine("4.Versiyon: Ürünlerinleri stok durumunu görme");
                Console.WriteLine("5.Ana menüye dönüş");
                Console.WriteLine("=========================================");
                Console.Write("Lütfen yapmak istediğiniz Versiyon sistemini seçiniz(örn= 1):");
                string market = Console.ReadLine();
                if (market == "1")
                {
                    m1:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("MARKET UYGULAMASI");
                    Console.ResetColor();
                    Console.WriteLine("======================================================");
                    Console.WriteLine("Merhaba " + kullaniciadi + " 1.Versiyon'a hoş geldin");
                    string[] numara = [ "1:", "2:", "3:", "4:", "5:" ];
                    string[] urunler = [ " 1 Koli yumurta", " 1 Kalıp Peynir", " 1 Kutu Süt", " 1 Paket Yulaf", " 1kg Tavuk" ];
                    int[] fiyatlar = [ 100, 50, 20, 30, 200 ];
                    bool isShopping = true;
                    int toplam = 0;

                    while (isShopping)
                    {
                        Console.ForegroundColor = (ConsoleColor.Cyan);
                        Console.WriteLine("Ürünler Listesi");
                        Console.ResetColor();
                        for (int i = 0; i < urunler.Length; i++)
                        {
                            Console.WriteLine($"{numara[i]}{urunler[i]} - {fiyatlar[i]} TL");
                        }

                        Console.WriteLine("Ödeme için 'T' tuşuna basınız");
                        Console.Write("Lütfen almak istediğiniz ürünün numarasını seçiniz: ");
                        string inputSecim = Console.ReadLine();

                        if (inputSecim.ToLower() == "t")
                        {
                            isShopping = false;
                            continue;
                        }
                        try
                        {
                            int secilenUrunNo = int.Parse(inputSecim) - 1;

                            if (secilenUrunNo >= 0 && secilenUrunNo < urunler.Length)
                            {
                                int secilenUrunFiyati = fiyatlar[secilenUrunNo];
                                toplam += secilenUrunFiyati;
                                Console.Clear();
                                Console.WriteLine(urunler[secilenUrunNo] + " için " + secilenUrunFiyati + " TL eklendi.");
                                Console.WriteLine("Toplam Tutar: " + toplam + " TL");
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz seçim! Lütfen bir ürün numarası giriniz veya 't' basarak işlemi sonlandırın.");
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Geçersiz seçim! Lütfen bir ürün numarası giriniz veya 't' basarak işlemi sonlandırın.");
                        }
                    }
                odeme:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("MARKET UYGULAMASI");
                    Console.ResetColor();
                    Console.WriteLine("======================================================");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Toplam Tutar: " + toplam + " TL tutmuştur");
                    Console.WriteLine("Ödeme yöntemi seçiniz:");
                    Console.WriteLine("1- Kredi Kartı");
                    Console.WriteLine("2- Nakit");
                    Console.Write("Ödeme yöntemi seçiniz (1 veya 2): ");
                    string odemeSecim = Console.ReadLine();
                    if (odemeSecim == "1")
                    {
                        Console.WriteLine("Kredi Kartı ile ödeme yapılıyor...");
                        Console.WriteLine("Ödeme başarılı!");
                        // Burada kredi kartı ile ödeme işlemleri yapılır
                    }
                    else if (odemeSecim == "2")
                    {
                        Console.WriteLine("Nakit ile ödeme yapıldı.");
                        // Burada nakit ile ödeme işlemleri yapılır
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz ödeme yöntemi seçimi!");
                        Console.WriteLine("Tekrar deneyiniz");
                        goto odeme;

                    }
                    Console.WriteLine("İyi günler!");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Tekrar alışveriş için(D)/ Ana menü için(A) tuşuna basınız: ");
                    Console.ResetColor();
                    string alisveris = Console.ReadLine();
                    if (alisveris.ToLower() == "d")
                    {
                         goto m1;
                    }
                    else
                    {
                         goto mhome;
                    }

                    }
                else if (market == "2")
            {
            m2:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("MARKET UYGULAMASI");
                Console.ResetColor();
                Console.WriteLine("======================================================");
                Console.WriteLine("Merhaba " + kullaniciadi + " 2.Versiyon'a hoş geldin");
                string[] numara = [ "1:", "2:", "3:", "4:", "5:", "6:", "7:", "8:", "9:", "10:" ];
                string[] urunler = [ " 1 Koli yumurta", " 1 Kalıp Peynir", " 1 Kutu Süt", " 1 Paket Yulaf", " 1 kg Tavuk", " 5 lt Su", " 1 kg Kırmızı et", " 1 Paket Cips", " 1 Paket çikolata", " 6'lı Soda" ];
                int[] fiyatlar = [ 100, 50, 20, 30, 200, 20, 350, 35, 30, 30 ];

                bool isShopping = true;
                int toplam = 0;

                while (isShopping)
                {
                    Console.ForegroundColor = (ConsoleColor.Cyan);
                    Console.WriteLine("Ürünler Listesi");
                    Console.ResetColor();
                    for (int i = 0; i < urunler.Length; i++)
                    {
                        Console.WriteLine($"{numara[i]}{urunler[i]} - {fiyatlar[i]} TL");
                    }
                    Console.ForegroundColor = (ConsoleColor.Red);
                    Console.WriteLine("Ödeme için 'T' tuşuna basınız");
                    Console.ResetColor();
                    Console.Write("Lütfen almak istediğiniz ürünün numarasını seçiniz: ");
                    string inputSecim = Console.ReadLine();
                    if (inputSecim.ToLower() == "t")
                    {
                        isShopping = false;
                        continue;
                    }
                    if (int.TryParse(inputSecim, out int secilenIndex) && secilenIndex > 0 && secilenIndex <= urunler.Length)
                    {
                        Console.Write("Kaç adet almak istiyorsunuz: ");
                        if (int.TryParse(Console.ReadLine(), out int adet))
                        {
                            string secilenUrun = urunler[secilenIndex - 1];
                            int urunFiyati = fiyatlar[secilenIndex - 1];
                            Console.Clear();
                            Console.WriteLine($"{adet} adet {secilenUrun} eklediniz");
                            Console.WriteLine($"Toplam fiyat: {toplam += adet * urunFiyati}");
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz adet girişi!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz ürün numarası!");
                    }
                }
            odeme:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("MARKET UYGULAMASI");
                Console.ResetColor();
                Console.WriteLine("======================================================");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Alışverişiniz toplam: " + toplam + " TL tutmuştur.");

                Console.WriteLine("Ödeme yöntemi seçiniz:");
                Console.WriteLine("1- Kredi Kartı");
                Console.WriteLine("2- Nakit");

                Console.Write("Ödeme yöntemi seçiniz (1 veya 2): ");
                string odemeSecim = Console.ReadLine();

                if (odemeSecim == "1")
                {
                    Console.WriteLine("Kredi Kartı ile ödeme yapılıyor...");
                    Console.WriteLine("Ödeme başarılı!");
                    // Burada kredi kartı ile ödeme işlemleri yapılır
                }
                else if (odemeSecim == "2")
                {
                    Console.WriteLine("Nakit ile ödeme yapıldı.");
                    // Burada nakit ile ödeme işlemleri yapılır
                }
                else
                {
                    Console.WriteLine("Geçersiz ödeme yöntemi seçimi!");
                    Console.WriteLine("Tekrar deneyiniz");
                    goto odeme;

                }

                Console.WriteLine("İyi günler!");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Tekrar alışveriş için(D)/ Ana menü için(A) tuşuna basınız: ");
                Console.ResetColor();
                string alisveris = Console.ReadLine();
                if (alisveris.ToLower() == "d")
                {
                    goto m2;
                }
                else
                {
                    goto mhome;
                }
            }
                else if (market == "3")
                {
                m3:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("MARKET UYGULAMASI");
                    Console.ResetColor();
                    Console.WriteLine("======================================================");
                    Console.WriteLine("Merhaba " + kullaniciadi + " 3.Versiyon'a hoş geldin");
                    string[] numara = [ "1:", "2:", "3:", "4:", "5:", "6:", "7:", "8:", "9:", "10:" ];
                    string[] urunler = [ " 1 Koli yumurta", " 1 Kalıp Peynir", " 1 Kutu Süt", " 1 Paket Yulaf", " 1 kg Tavuk", " 5 lt Su", " 1 kg Kırmızı et", " 1 Paket Cips", " 1 Paket çikolata", " 6'lı Soda" ];
                    int[] fiyatlar = [ 100, 50, 20, 30, 200, 20, 350, 35, 30, 30 ];

                    bool isShopping = true;
                    int toplam = 0;

                    while (isShopping)
                    {
                        Console.ForegroundColor = (ConsoleColor.Cyan);
                        Console.WriteLine("Ürünler Listesi");
                        Console.ResetColor();
                        for (int i = 0; i < urunler.Length; i++)
                        {
                            Console.WriteLine($"{numara[i]}{urunler[i]} - {fiyatlar[i]} TL");
                        }
                        Console.ForegroundColor = (ConsoleColor.Red);
                        Console.WriteLine("Ödeme için 'T' tuşuna basınız");
                        Console.ResetColor();
                        Console.Write("Lütfen almak istediğiniz ürünün numarasını seçiniz: ");
                        string inputSecim = Console.ReadLine();
                        if (inputSecim.ToLower() == "t")
                        {
                            isShopping = false;
                            continue;
                        }
                        if (int.TryParse(inputSecim, out int secilenIndex) && secilenIndex > 0 && secilenIndex <= urunler.Length)
                        {
                            Console.Write("Kaç adet almak istiyorsunuz: ");
                            if (int.TryParse(Console.ReadLine(), out int adet))
                            {
                                string secilenUrun = urunler[secilenIndex - 1];
                                int urunFiyati = fiyatlar[secilenIndex - 1];
                                Console.Clear();
                                Console.WriteLine($"{adet} adet {secilenUrun} eklediniz");
                                Console.WriteLine($"Toplam fiyat: {toplam += adet * urunFiyati}");
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz adet girişi!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz ürün numarası!");
                        }
                    }
                odeme:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("MARKET UYGULAMASI");
                    Console.ResetColor();
                    Console.WriteLine("======================================================");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Alışverişiniz toplam: " + toplam + " TL tutmuştur.");

                    Console.WriteLine("Ödeme yöntemi seçiniz:");
                    Console.WriteLine("1- Kredi Kartı");
                    Console.WriteLine("2- Nakit");

                    Console.Write("Ödeme yöntemi seçiniz (1 veya 2): ");
                    string odemeSecim = Console.ReadLine();

                    if (odemeSecim == "1")
                    {
                        // Burada kredi kartı ile ödeme işlemleri yapılır
                        Console.Write("Kredi Kartı liminitinizi giriniz: ");
                        int kart = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if(kart >= toplam)
                        {
                            Console.WriteLine("K.kartınızdan " + kart + " tl çekilmiştir.");
                            Console.WriteLine("Ödeme başarılı!");
                            Console.WriteLine("K.kartınızda " + (kart - toplam) + " tl kalmıştır");
                            Console.WriteLine("İyi günler dileriz!");
                        }
                        else
                        {
                            Console.WriteLine("Kart limitiniz " + kart + " tl yetersiz. " + (kart - toplam) + " tl eksik. Kart bakiyenizi kontrol ediniz!");
                            Console.WriteLine("Tekrar denemek için bir tuşa basınız!");
                            Console.ReadLine();
                            goto odeme;

                        }
                    }
                    else if (odemeSecim == "2")
                    {
                        // Burada nakit ile ödeme işlemleri yapılır
                        Console.Write("Nakit vericeğiniz tutarı giriniz: ");
                        int nakit = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (nakit >= toplam)
                        {
                            Console.WriteLine("Nakit olarak " + nakit + " tl alınmıştır.");
                            Console.WriteLine("Para üstü " + (nakit - toplam) + " tl geri verilmiştir.");
                            Console.WriteLine("İyi günler dileriz!");
                        }
                        else
                        {
                            Console.WriteLine("Verdiğiniz " + nakit + " tl yetersiz. " + (nakit - toplam) + " tl eksik.");
                            Console.WriteLine("Lütfen tekrar denemek için bir tuşa basınız!");
                            Console.ReadLine();
                            goto odeme;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz ödeme yöntemi seçimi!");
                        Console.WriteLine("Tekrar deneyiniz");
                        goto odeme;

                    }

                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Tekrar alışveriş için(D)/ Ana menü için(A) tuşuna basınız: ");
                    Console.ResetColor();
                    string alisveris = Console.ReadLine();
                    if (alisveris.ToLower() == "d")
                    {
                        goto m3;
                    }
                    else
                    {
                        goto mhome;
                    }
                }
                else if (market == "4")
                {
                m4:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("MARKET UYGULAMASI");
                    Console.ResetColor();
                    Console.WriteLine("======================================================");
                    Console.WriteLine("Merhaba " + kullaniciadi + " 4.Versiyon'a hoş geldin");
                    string[] numara = [ "1:", "2:", "3:", "4:", "5:", "6:", "7:", "8:", "9:", "10:" ];
                    string[] urunler = [ " 1 Koli yumurta", " 1 Kalıp Peynir", " 1 Kutu Süt", " 1 Paket Yulaf", " 1 kg Tavuk", " 5 lt Su", " 1 kg Kırmızı et", " 1 Paket Cips", " 1 Paket çikolata", " 6'lı Soda" ];
                    int[] fiyatlar = [ 100, 50, 20, 30, 200, 20, 350, 35, 30, 30 ];
                    int[] stok = [20, 20, 20, 20, 20, 20, 20, 20, 20, 20];

                    bool isShopping = true;
                    int toplam = 0;

                    while (isShopping)
                    {
                        Console.ForegroundColor = (ConsoleColor.Cyan);
                        Console.WriteLine("Ürünler Listesi");
                        Console.ResetColor();
                        for (int i = 0; i < urunler.Length; i++)
                        {
                            Console.WriteLine($"{numara[i]}{urunler[i]} - {fiyatlar[i]} TL -  {stok[i]} adet bulunmaktadır.");
                        }
                        Console.ForegroundColor = (ConsoleColor.Red);
                        Console.WriteLine("Ödeme için 'T' tuşuna basınız");
                        Console.ResetColor();
                        Console.Write("Lütfen almak istediğiniz ürünün numarasını seçiniz: ");
                        string inputSecim = Console.ReadLine();
                        if (inputSecim.ToLower() == "t")
                        {
                            isShopping = false;
                            continue;
                        }
                        if (int.TryParse(inputSecim, out int secilenIndex) && secilenIndex > 0 && secilenIndex <= urunler.Length)
                        {
                            Console.Write("Kaç adet almak istiyorsunuz: ");
                            if (int.TryParse(Console.ReadLine(), out int adet))
                            {
                                string secilenUrun = urunler[secilenIndex - 1];
                                int urunFiyati = fiyatlar[secilenIndex - 1];
                                Console.Clear();
                                Console.WriteLine($"{adet} adet {secilenUrun} eklediniz");
                                Console.WriteLine($"Toplam fiyat: {toplam += adet * urunFiyati}");
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz adet girişi!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz ürün numarası!");
                        }
                    }
                odeme:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("MARKET UYGULAMASI");
                    Console.ResetColor();
                    Console.WriteLine("======================================================");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Alışverişiniz toplam: " + toplam + " TL tutmuştur.");

                    Console.WriteLine("Ödeme yöntemi seçiniz:");
                    Console.WriteLine("1- Kredi Kartı");
                    Console.WriteLine("2- Nakit");

                    Console.Write("Ödeme yöntemi seçiniz (1 veya 2): ");
                    string odemeSecim = Console.ReadLine();

                    if (odemeSecim == "1")
                    {
                        // Burada kredi kartı ile ödeme işlemleri yapılır
                        Console.Write("Kredi Kartı liminitinizi giriniz: ");
                        int kart = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (kart >= toplam)
                        {
                            Console.WriteLine("K.kartınızdan " + kart + " tl çekilmiştir.");
                            Console.WriteLine("Ödeme başarılı!");
                            Console.WriteLine("K.kartınızda " + (kart - toplam) + " tl kalmıştır");
                            Console.WriteLine("İyi günler dileriz!");
                        }
                        else
                        {
                            Console.WriteLine("Kart limitiniz " + kart + " tl yetersiz. " + (kart - toplam) + " tl eksik. Kart bakiyenizi kontrol ediniz!");
                            Console.WriteLine("Tekrar denemek için bir tuşa basınız!");
                            Console.ReadLine();
                            goto odeme;

                        }
                    }
                    else if (odemeSecim == "2")
                    {
                        // Burada nakit ile ödeme işlemleri yapılır
                        Console.Write("Nakit vericeğiniz tutarı giriniz: ");
                        int nakit = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (nakit >= toplam)
                        {
                            Console.WriteLine("Nakit olarak " + nakit + " tl alınmıştır.");
                            Console.WriteLine("Para üstü " + (nakit - toplam) + " tl geri verilmiştir.");
                            Console.WriteLine("İyi günler dileriz!");
                        }
                        else
                        {
                            Console.WriteLine("Verdiğiniz " + nakit + " tl yetersiz. " + (nakit - toplam) + " tl eksik.");
                            Console.WriteLine("Lütfen tekrar denemek için bir tuşa basınız!");
                            Console.ReadLine();
                            goto odeme;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz ödeme yöntemi seçimi!");
                        Console.WriteLine("Tekrar deneyiniz");
                        goto odeme;

                    }

                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Tekrar alışveriş için(D)/ Ana menü için(A) tuşuna basınız: ");
                    Console.ResetColor();
                    string alisveris = Console.ReadLine();
                    if (alisveris.ToLower() == "d")
                    {
                        goto m4;
                    }
                    else
                    {
                        goto mhome;
                    }
                }
                else if (market == "5")
            {
                goto anamenu;
            }
            }
            else if (appchoose == "3")
            {
                //TAŞ KAĞIT MAKAS ALANI
                secim:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("TAŞ KAĞIT MAKAS OYUN ALANI");
                Console.ResetColor();
                Console.WriteLine("=================================================================");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Merhaba " + kullaniciadi + " 'Taş-Kağıt-Makas' oyununa hoş geldin!");
                Console.ResetColor();
                Console.WriteLine("=================================================================");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1.Versiyon: Tek oyun alanı");
                Console.WriteLine("2.Versiyon: Skor kayıt edenbilen kısım");
                Console.WriteLine("3.Ana menüye dönüş");
                Console.ResetColor();
                Console.WriteLine("=================================================================");
                Console.Write("Lütfen yapmak istediğiniz Versiyon sistemini seçiniz(örn= 1): ");
                string game = Console.ReadLine();
                if (game == "1")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("TAŞ KAĞIT MAKAS OYUN ALANI");
                    Console.ResetColor();
                    Console.WriteLine("=================================================================");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Merhaba " + kullaniciadi + " 'Taş-Kağıt-Makas' oyunu 'Versiyon 1'e hoş geldin!");
                    Console.ResetColor();
                    Console.WriteLine("=================================================================");
                again:
                    string[] secimler = ["Taş", "Kağıt", "Makas"];
                    Random random = new Random();
                    int bilgisayarsecim = random.Next(0, secimler.Length);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Seçimini yap!");
                    Console.ResetColor();
                    for (int i = 0; i < secimler.Length; i++)
                    {
                        Console.WriteLine((i + 1) + ". " + secimler[i]);
                    }
                    int oyuncusecim = int.Parse(Console.ReadLine()) - 1;

                    string sonuc;
                    if (oyuncusecim == bilgisayarsecim)
                    {
                        sonuc = "Berabere";

                    }
                    else if ((oyuncusecim == 0 && bilgisayarsecim == 2) || (oyuncusecim == 1 && bilgisayarsecim == 0) ||
                            (oyuncusecim == 2 && bilgisayarsecim == 1))
                    {
                        sonuc = "Kazandın!";
                    }
                    else
                    {
                        sonuc = "Kaybettin!";
                    }
                    Console.WriteLine("Seçtiğin: " + secimler[oyuncusecim]);
                    Console.WriteLine("Bilgisayar seçim: " + secimler[bilgisayarsecim]);
                    Console.WriteLine("Sonuç: " + sonuc);
                    tekrar:
                    Console.WriteLine("Devam etmek için 'D'//Ana menü için 'A' tuşuna basın");
                    string gamesec = Console.ReadLine();
                    if (gamesec.ToLower() == "d")
                    {
                        goto again;
                    }
                    else if(gamesec.ToLower() == "a")
                    {
                            goto secim; 
                    }
                    else
                    {
                            
                            goto tekrar;
                    }


                }
                else if (game == "2")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("TAŞ KAĞIT MAKAS OYUN ALANI");
                    Console.ResetColor();
                    Console.WriteLine("=================================================================");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Merhaba " + kullaniciadi + " 'Taş-Kağıt-Makas' oyunu 'Versiyon 2'e hoş geldin!");
                    Console.ResetColor();
                    Console.WriteLine("=================================================================");
                    int oyuncuSkor = 0;
                    int bilgisayarSkor = 0;
                again:
                    string[] secimler = ["Taş", "Kağıt", "Makas"];
                    Random random = new Random();
                    int bilgisayarsecim = random.Next(0, secimler.Length);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Seçimini yap!");
                    Console.ResetColor();
                    for (int i = 0; i < secimler.Length; i++)
                    {
                        Console.WriteLine((i + 1) + ". " + secimler[i]);
                    }
                    int oyuncusecim = int.Parse(Console.ReadLine()) - 1;

                    string sonuc;
                    if (oyuncusecim == bilgisayarsecim)
                    {
                        sonuc = "Berabere";

                    }
                    else if ((oyuncusecim == 0 && bilgisayarsecim == 2) || (oyuncusecim == 1 && bilgisayarsecim == 0) ||
                            (oyuncusecim == 2 && bilgisayarsecim == 1))
                    {
                        sonuc = "Kazandın!";
                        oyuncuSkor++;
                    }
                    else if ((oyuncuSkor == 3))
                    {
                        Console.Clear();
                        sonuc = "Tebrikler Bilgisayarı yendin!";
                    }
                    else if ((bilgisayarSkor == 3))
                    {
                        Console.Clear();
                        sonuc = "Skynet tarafından mağlup edildin!!!";
                    }
                    else
                    {
                        sonuc = "Kaybettin!";
                        bilgisayarSkor++;
                    }
                    Console.WriteLine("Seçtiğin: " + secimler[oyuncusecim]);
                    Console.WriteLine("Bilgisayar seçim: " + secimler[bilgisayarsecim]);
                    Console.WriteLine("Sonuç: " + sonuc);
                    Console.WriteLine($"Skor= Oyuncu: {oyuncuSkor} - Bilgisayar: {bilgisayarSkor}  ");
                tekrar:
                    Console.WriteLine("Devam etmek için 'D'//Ana menü için 'A' tuşuna basın");
                    string gamesec = Console.ReadLine();
                    if (gamesec.ToLower() == "d")
                    {
                        goto again;
                    }
                    else if (gamesec.ToLower() == "a")
                    {
                        goto secim;
                    }
                    else
                    {
                        goto tekrar;
                    }
                }
                else if(game == "3")
                {
                    goto anamenu;
                }
            }
            else if (appchoose == "4")
            {
                //QUİZ ALANI
                quiz:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("BİLGİ YARIŞMASINA HOŞ GELDİNİZ!");
                Console.ResetColor();
                Console.WriteLine("=================================================================");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Merhaba " + kullaniciadi + " genel-kültür seviyeni ölçmeye hazırmısın?");
                Console.ResetColor();
                Console.WriteLine("=================================================================");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1. SORU-CEVAP OYUNU");
                Console.WriteLine("2. Ana menüye dönüş");
                Console.ResetColor();
                Console.WriteLine("=================================================================");
                Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz(örn= 1): ");
                string quiz = Console.ReadLine();
                if (quiz == "1")
                {
                sorucevap:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Merhaba " + kullaniciadi + " genel-kültür seviyeni ölçmeye hazırmısın?");
                    Console.ResetColor();
                    Console.WriteLine("=================================================================");
                    string[] sorular = [ "Gökyüzü ne renktir?", "Türkiye'nin başkenti neresidir?", "Dünyanın en büyük okyanusu hangisidir?", "Üçgenin iç açıları toplamı kaç derecedir?", "Dünyanın en yüksek dağı hangisidir?", "Güneş sistemindeki en büyük gezegen hangisidir?"];
                    string[] cevaplar = [ "Mavi", "Ankara", "Pasifik", "180", "Everest", "Jüpiter"];
                    string[] secenekler = ["kırmızı|Mavi|Pembe|Mor", "Ankara|İstanbul|İzmir|Bursa", "Pasifik|Atlantik|Hint|Güney", "180|90|190|240", "Fuji|Ağrı|Everest|Alpler", "Uranüs|Venüs|Satürn|Jüpiter"];
                    Console.WriteLine("Bilgi Yarışması Başlıyor!");
                    for (int i = 0; i < sorular.Length; i++)
                    {
                        Console.WriteLine($"Soru {i + 1}: {sorular[i]}");
                        // Seçenekleri alma ve ayrıştırma
                        string[] secenekListesi = secenekler[i].Split('|');
                        // Kullanıcıya seçenekleri gösterme
                        Console.WriteLine("Seçenekler:");
                        for (int j = 0; j < secenekListesi.Length; j++)
                        {
                            Console.WriteLine($"{j + 1}. {secenekListesi[j]}");
                        }
                        Console.Write("Cevabınızı giriniz (1, 2, 3, 4,): ");
                        string kullaniciCevap = Console.ReadLine();
                        int cevapIndex;
                        if (int.TryParse(kullaniciCevap, out cevapIndex) && cevapIndex > 0 && cevapIndex <= secenekListesi.Length)
                        {
                            string secilenCevap = secenekListesi[cevapIndex - 1];
                            if (secilenCevap == cevaplar[i])
                            {
                                Console.WriteLine("Doğru cevap!");
                            }
                            else
                            {
                                Console.WriteLine($"Yanlış cevap! Doğru cevap: {cevaplar[i]}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz giriş. Lütfen geçerli bir seçenek numarası girin.");
                            i--;
                        }
                    }
                    Console.WriteLine("Bilgi yarışması sona erdi. Teşekkürler!");
                    Console.WriteLine("Tekrar denemek için '1'/ Ana menüye dönmek için '2' basınız: ");
                    string sorucevap = Console.ReadLine();
                    if(sorucevap == "1")
                    {
                        goto sorucevap;
                    }
                    else
                    {
                        goto quiz;
                    }
                }
                else if (quiz == "2")
                {
                    goto anamenu;
                }
            }
        }
    }
}
