namespace _kalıtımm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ucak uck = new ucak();
            uck.AD = "emir";
            uck.SOYAD = "ülker";
            uck.YAS = -22;
            uck.CINSIYET = "erkek";
            uck.Marka = "türk hava yolları";
            uck.KALKIS = "ısparta";
            uck.VARIS = "adana";

            Console.WriteLine("Yolcu Adı: " + uck.AD);
            Console.WriteLine("Yolcu Soyadı: " + uck.SOYAD);
            Console.WriteLine("Yolcu Yaşı: " + uck.YAS);
            Console.WriteLine("Yolcu Cinsiyeti: " + uck.CINSIYET);
            Console.WriteLine("Uçak Markası: " + uck.Marka);
            Console.WriteLine("Uçak Kalkış Noktası: " + uck.KALKIS);
            Console.WriteLine("Uçak Varış Noktası: " + uck.VARIS);
            Console.ReadLine();
        }
    }
}