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
                TekerlekSayisi = 11
            };
            list.Add(araba1);


            Arsba araba2 = new Arsba {
                Id = 2,
                TekerlekSayisi = 1,
                Renk = "sas",
                Name = "MAA ms",
                ModelYili = 111,
                Marka = "mn sasmm",
                YolcuADeti = 1
            };

            list.Add(araba2);

            Otobus otobus2 = new Otobus {
                Id = 3,
                YolcuADeti = 12,
                Marka = "sad",
                ModelYili = 111,
                Name = "dasdsd",
                Renk = "<zszdhbs",
                TekerlekSayisi = 1,
                AyaktaYolcuAdeti = 1,
                EngelliRampasi = false

                // ornek yapmak ıcın



            };

            Otobus otobus3 = new Otobus
            {
                Id = 2,
        };
        }

    }

}