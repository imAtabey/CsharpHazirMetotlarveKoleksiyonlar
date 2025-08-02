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