using System.Collections;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        #region String Metotları
        string degisken = "Dersimiz Csharp,hoşgeldiniz";
        string degisken2 = "Dersimiz Csharo";

        // length -> uzunluğu verir
        Console.WriteLine(degisken.Length);

        // ToUpper - ToLower -> String'in tüm karakterlerini büyütür veya hepsini küçültür
        Console.WriteLine(degisken.ToUpper());
        Console.WriteLine(degisken.ToLower());

        // Concat -> İlgili string ifadeye ekleme yapar
        Console.WriteLine(string.Concat(degisken, "Merhaba!"));

        // Compare-CompareTo -> degişkenleri karşılaştırır
        Console.WriteLine(degisken.CompareTo(degisken2));
        // eşit ise 0 döner
        // 1.degisken, 2. degişkenden daha büyük değere sahipse 1
        // 1. değişken, 2, değişkenden daha küçük ise -1
        Console.WriteLine(string.Compare(degisken, degisken2, true));
        // true: büyük küçük harf duyarsız

        // Contains -> İlgili string ifadede içinde parametre verilen değer var ise true
        Console.WriteLine(degisken.Contains(degisken2));
        Console.WriteLine(degisken.EndsWith("Hoşgeldiniz"));
        Console.WriteLine(degisken.StartsWith("Merhaba"));

        // IndexOf -> verilen parametrede ki değerin başladığı index numarasını döner
        Console.WriteLine(degisken.IndexOf("Csharp"));
        Console.WriteLine(degisken.IndexOf("asda"));
        //var ise C'nin olduğu index'i döner. Yok ise -1 döner

        // LastIndexOf -> ilgili parametrenin olduğu son index numarasını döner.
        Console.WriteLine(degisken.LastIndexOf("i"));

        // Insert -> başlangıç index'i,"ifade" ile ekleme yapar
        Console.WriteLine(degisken.Insert(0, "Merhaba! "));

        // PadLeft,PadRight -> değişken sol ve sağına verdiğim toplam eleman sayısı kadar boşluk ya da karakter ekler.
        Console.WriteLine(degisken.PadLeft(30, '*'));
        Console.WriteLine(degisken.PadRight(30, '*'));

        // Remove -> n. index'den başlayıp sonrasını siler
        Console.WriteLine(degisken.Remove(10));
        Console.WriteLine(degisken.Remove(10, 2)); //10'dan başla 2 tane sil [10] ve [11]

        // Replace -> olan bir değişkeni yenisi ile değiştirir.
        Console.WriteLine(degisken.Replace("Csharp", "C#"));

        // Split -> Verilen parametreye göre ayırır ve diziye atar
        Console.WriteLine(degisken.Split(' ')[1]); //Boşluk ile ayır index 1'i getir

        // SubString ->  İlgili indexten başlayıp sonuna kadar veya istenilen sayıda karakteri getirir
        Console.WriteLine(degisken.Substring(4));
        Console.WriteLine(degisken.Substring(4, 2));
        #endregion

        #region DateTime ve Math Metotları
        // DateTime ->
        Console.WriteLine(DateTime.Now);
        Console.WriteLine(DateTime.Now.Date);
        Console.WriteLine(DateTime.Now.Day);
        Console.WriteLine(DateTime.Now.Month);
        Console.WriteLine(DateTime.Now.Year);
        Console.WriteLine(DateTime.Now.Hour);
        Console.WriteLine(DateTime.Now.Minute);
        Console.WriteLine(DateTime.Now.Second);

        Console.WriteLine(DateTime.Now.DayOfWeek); //haftanın günü string
        Console.WriteLine(DateTime.Now.DayOfYear); //yılın günü

        Console.WriteLine(DateTime.Now.ToLongDateString());
        Console.WriteLine(DateTime.Now.ToShortDateString());
        Console.WriteLine(DateTime.Now.ToLongTimeString());
        Console.WriteLine(DateTime.Now.ToShortTimeString());

        Console.WriteLine(DateTime.Now.AddDays(2));
        Console.WriteLine(DateTime.Now.AddHours(2));
        Console.WriteLine(DateTime.Now.AddSeconds(30));
        Console.WriteLine(DateTime.Now.AddMonths(5));
        Console.WriteLine(DateTime.Now.AddYears(10));
        Console.WriteLine(DateTime.Now.AddMilliseconds(50));

        //DateTime Format ->
        Console.WriteLine(DateTime.Now.ToString("dd")); //gün
        Console.WriteLine(DateTime.Now.ToString("ddd")); //sat
        Console.WriteLine(DateTime.Now.ToString("dddd")); //saturday

        Console.WriteLine(DateTime.Now.ToString("MM")); //04
        Console.WriteLine(DateTime.Now.ToString("MMM")); //Apr
        Console.WriteLine(DateTime.Now.ToString("MMMM")); //April

        Console.WriteLine(DateTime.Now.ToString("yy")); //21
        Console.WriteLine(DateTime.Now.ToString("yyy")); //2021

        Console.WriteLine("*** Math Kütüphanesi ***");

        // Math Kütüphanesi ->
        Console.WriteLine(Math.Abs(-1)); // Mutlak alır
        Console.WriteLine(Math.Sin(30)); // sin
        Console.WriteLine(Math.Cos(30)); // cos
        Console.WriteLine(Math.Tan(30)); // Tan

        Console.WriteLine(Math.Ceiling(22.3)); // 23 bir üst tam
        Console.WriteLine(Math.Round(22.3)); // 23 en yakına yuvarlar
        Console.WriteLine(Math.Floor(22.3)); // 22 bir alt tam

        Console.WriteLine(Math.Max(6, 2)); //Max değer
        Console.WriteLine(Math.Min(6, 2)); //Min değer

        Console.WriteLine(Math.Pow(3, 4)); //3^4 = 81
        Console.WriteLine(Math.Sqrt(9)); //karekök = 3
        Console.WriteLine(Math.Log(9)); // 9'un e tabanında karşılığı
        Console.WriteLine(Math.Exp(3)); // e^3 verir
        Console.WriteLine(Math.Log10(10)); // 10'un log10 da karşılığı


        #endregion

        #region Koleksiyonlar-Genereic List
        // List<T> class
        //System.Collections.Generic namespace altında bulunur
        // T-> obje türünü belli eder

        List<int> sayiListesi = new List<int>();
        sayiListesi.Add(23);
        sayiListesi.Add(10);
        sayiListesi.Add(4);
        sayiListesi.Add(5);
        sayiListesi.Add(92);
        sayiListesi.Add(34);

        List<string> renkListesi = new List<string>();
        renkListesi.Add("Kırmızı");
        renkListesi.Add("Mavi");
        renkListesi.Add("Turuncu");
        renkListesi.Add("Sarı");
        renkListesi.Add("Yeşil");

        // Count -> Eleman sayısını döner
        Console.WriteLine(renkListesi.Count());
        Console.WriteLine(sayiListesi.Count());

        // Foreach ve List.Foreach ile elemanlara erişim
        foreach (var sayi in sayiListesi)
            Console.WriteLine(sayiListesi);
        foreach (var renk in renkListesi)
            Console.WriteLine(sayiListesi);

        sayiListesi.ForEach(sayi => Console.WriteLine(sayiListesi));
        sayiListesi.ForEach(renk => Console.WriteLine(renkListesi));

        // Remove -> Eleman çıkartma
        sayiListesi.Remove(4);
        renkListesi.Remove("Yeşil");

        // RemoveAt -> İlgili index elemanını çıkarır
        sayiListesi.RemoveAt(0); //[0] elemanı çıkarır yani 1. eleman
        renkListesi.RemoveAt(1); // [1] elemanı yani 2. elemanı çıkarır

        // Contains -> Liste içerisinde ilgili elemanı arar.
        if (sayiListesi.Contains(10))
            Console.WriteLine("10 Liste içerisinde bulundu");

        // BinarySearch -> Eleman için ilgili index numarasını getirir.
        Console.WriteLine(renkListesi.BinarySearch("Sarı"));

        // Diziyi koleksiyona çevirme
        string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };
        List<string> hayvanListesi = new List<string>(hayvanlar);

        // Clear -> Koleksiyonu temizler
        hayvanListesi.Clear();

        // Liste içerisinde Nesne Tutma
        List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();

        Kullanicilar k1 = new Kullanicilar();
        k1.Isim = "Hüseyin";
        k1.Soyisim = "YILMAZ";
        k1.Yas = 32;

        Kullanicilar k2 = new Kullanicilar();
        k2.Isim = "Hasan";
        k2.Soyisim = "YILMAZ";
        k2.Yas = 32;

        kullaniciListesi.Add(k1);
        kullaniciListesi.Add(k2);

        List<Kullanicilar> yeniListe = new List<Kullanicilar>();
        yeniListe.Add(new Kullanicilar
        {
            Isim = "Cafer",
            Soyisim = "YILMAZ",
            Yas = 28
        });

        foreach (Kullanicilar kullanici in kullaniciListesi)
        {
            Console.WriteLine("Kullanıcı Adı: " + kullanici.Isim);
            Console.WriteLine("Kullanıcı Soyadı: " + kullanici.Soyisim);
            Console.WriteLine("Kullanıcı Yaşı: " + kullanici.Yas);
        }

        yeniListe.Clear();
        #endregion

        #region Koleysiyonlar-ArrayList

        ArrayList list = new ArrayList();
        // list.Add("Aye");
        // list.Add(2);
        // list.Add(true);
        // list.Add('a');

        // Verilere Erişmek
        // Console.WriteLine(list[1]);

        // foreach (var item in list)
        //     Console.WriteLine(item);

        // Addrange -> Toplu eleman ekleme
        Console.WriteLine("*** AddRange ***");
        // string[] renkler = { "Kırmızı", "Sarı", "Yeşil" };
        List<int> sayilar = new List<int>() { 1, 8, 3, 7, 9, 92, 5 };

        // list.AddRange(renkler);
        list.AddRange(sayilar);

        foreach (var item in list)
            Console.WriteLine(item);

        // Sort -> Sıralama yapmak için
        Console.WriteLine("*** Sort ***");
        list.Sort();
        // list.Sort(); metodu koleksiyon içinde farklı türler var ise RUNTIME'da hata verecektir.

        // BinarySearch -> Elemanın index'ini arar
        Console.WriteLine("*** BinarySearch ***");
        Console.WriteLine(list.BinarySearch(9));

        // Reverse -> Koleksiyonu tersten sıralar
        Console.WriteLine("*** Reverse ***");
        list.Reverse();

        foreach (var item in list)
            Console.WriteLine(item);

        //Clear -> Koleksiyonu temizler
        list.Clear();

        foreach (var item in list)
            Console.WriteLine(item);

        #endregion

        #region Koleksiyonlar - Dictionary
        // Dictionary -> (key,value) şeklinde olan koleksiyonlardır
        // key değerler unique olmalı. Runtime'da hata verir
        Dictionary<int, string> kullanicilar = new Dictionary<int, string>();
        kullanicilar.Add(10, "Ayşe YILMAZ");
        kullanicilar.Add(12, "Ahmet YILMAZ");
        kullanicilar.Add(18, "Deniz Arda");
        kullanicilar.Add(20, "Özcan COŞAR");

        // Dizi Elemanlarına Erişim : index yerine key döneriz
        Console.WriteLine("*** Dictionary Elemanlarına Erişim ***");
        Console.WriteLine(kullanicilar[12]);
        foreach (var item in kullanicilar)
            Console.WriteLine(item);

        //Count -> Eleman sayısı
        Console.WriteLine("*** Counts ****");
        Console.WriteLine(kullanicilar.Count);

        // Contains -> dizide ilgili anahtar veya değer araması yapar
        Console.WriteLine("*** Contains ***");
        Console.WriteLine(kullanicilar.ContainsKey(10)); //boolean
        Console.WriteLine(kullanicilar.ContainsValue("Ahmet YILMAZ")); //boolean



        #endregion
    }
}
public class Kullanicilar
{
    private string? isim;
    private string? soyisim;
    private int yas;

    public string? Isim { get => isim; set => isim = value; }
    public string? Soyisim { get => soyisim; set => soyisim = value; }
    public int Yas { get => yas; set => yas = value; }
}





