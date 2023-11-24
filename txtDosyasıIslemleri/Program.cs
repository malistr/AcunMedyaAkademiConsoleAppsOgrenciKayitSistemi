namespace txtDosyasıIslemleri
{
    internal class Program
    {

        static void Yaz(string dosyaYolu,string metin)
        {
            StreamWriter writer = new StreamWriter(dosyaYolu,true);
            writer.WriteLine(metin);
            writer.Close();
        }
        static void Main(string[] args)
        {
            const string dosyaYolu = "C:\\deneme\\deneme.txt";

            while (true)
            {
                Console.WriteLine("Ogrencı Adı Giriniz:");
                string ogrenci = Console.ReadLine();
                Console.WriteLine("Ogrencının Numarasını girin");
                ogrenci += "" + Console.ReadLine();
                Yaz(dosyaYolu,ogrenci);

            }

            

            //StreamReader reader = new StreamReader("C:\\deneme\\deneme.txt");
            //string satir = reader.ReadLine();

            //while (satir != null)
            //{
            //    Console.WriteLine(satir);
            //    satir = reader.ReadLine();
            //}


            //StreamWriter writer = new StreamWriter("C:\\deneme\\deneme.txt",true);
            //{
            //    //string metin = Console.ReadLine();
            //    //writer.WriteLine(metin);
            //    //writer.Close();


            //}
        }
    }
}