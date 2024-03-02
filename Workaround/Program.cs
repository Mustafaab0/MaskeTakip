
using Business.Concrete;
using Entities.Concrete;

internal class Program
{
    static void Main(string[] args)
    {
        //Degiskenler();

        Vatandas vatandas1 = new Vatandas();

        SelamVer("Mustafa");
        SelamVer("Ali");
        SelamVer();
        Topla(5,9);

        //!DİZİLER
        //string ogrenci1 = "Mustafa";
        //string ogrenci2 = "Ali";
        //string ogrenci3 = "Muhammed";

        string[] ogrenciler = new string[3];

        ogrenciler[0] = "Mustafa";
        ogrenciler[1] = "Ali";
        ogrenciler[2] = "Muhammed";

        for (int i = 0; i < ogrenciler.Length; i++)
        {
            Console.WriteLine(ogrenciler[i]);
        }

        string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
        string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

        Person person1 = new Person();
        person1.FirstName = "MUHAMMED MUSTAFA";
        person1.LastName = "BARDAKÇI";
        person1.DateOfBirthYear = 2001;
        person1.NationalIdentity = 132;



        foreach (string sehir in sehirler1)
        {
            Console.WriteLine(sehir);
        }

        List<string> yeniSehirler1 = new List<string>() { "Ankara", "İstanbul", "İzmir" };
        yeniSehirler1.Add("Adana");
        foreach (var sehir in yeniSehirler1)
        {
            Console.WriteLine(sehir);
        }

        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);
        
    }
    
    static void SelamVer(string isim = "isimsiz")
    {
        Console.WriteLine("Merhaba " + isim);
    }

    static int Topla(int sayi1=5, int sayi2=10)
    {
        int sonuc = sayi1 + sayi2;
        Console.WriteLine("Toplam = " + sonuc);
        return sonuc;
    }

    private static void Degiskenler()
    {
        Console.WriteLine("Merhaba");

        string mesaj = "Maraba";
        double tutar = 100000;
        int sayi = 100;
        bool girisYapmisMi = false;

        string ad = "Mustafa";
        string soyad = "Bardakçı";
        int dogumYili = 1985;
        long tcNo = 12345678901;

        Console.WriteLine(tutar * 1.18);
        Console.WriteLine(tutar * 1.18);
    }

    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}

