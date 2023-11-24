namespace Siniflar
{
    internal class Program
    {

      
        static void Main(string[] args)
        {
            Arsba araba = new Arsba();

            araba.Id = 1;
            araba.Marka = "vesvos";
            araba.TekerlekSayisi = 2;
            araba.Renk = "kirmizi";
            araba.ModelYili = 3;
            
            List<Arsba> list = new List<Arsba>();
            list.Add(araba);

            Otobus otobus = new Otobus();   
            otobus.Id = 2;
            otobus.Renk = "kırmı<ı";
            otobus.Marka = "öppe";
            otobus.AyaktaYolcuAdeti = 22;
            otobus.EngelliRampasi = true;
            otobus.YolcuADeti = 1;


            Arsba araba1 = new Arsba { 
                Id = 1,
                Marka = "bobo",
                ModelYili = 111,
                Name = "nsms", 
                Renk = "www", 
                TekerlekSayisi = 11 };
            list.Add(araba1);
        }

    }
  
}