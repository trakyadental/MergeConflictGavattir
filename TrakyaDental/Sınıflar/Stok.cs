using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrakyaDental.Sınıflar
{
    class Stok
    {
        int UrunID, Marka, Urun_Grubu, Miktar, BirimFiyat;
        string Urun_Ad, Birim;

        public Stok(int urunID, int marka, int urun_Grubu, int miktar, int birimFiyat, string urun_Ad, string birim)
        {
            UrunID = urunID;
            Marka = marka;
            Urun_Grubu = urun_Grubu;
            Miktar = miktar;
            BirimFiyat = birimFiyat;
            Urun_Ad = urun_Ad;
            Birim = birim;
        }

        public int UrunID1 { get => UrunID; set => UrunID = value; }
        public int Marka1 { get => Marka; set => Marka = value; }
        public int Urun_Grubu1 { get => Urun_Grubu; set => Urun_Grubu = value; }
        public int Miktar1 { get => Miktar; set => Miktar = value; }
        public int BirimFiyat1 { get => BirimFiyat; set => BirimFiyat = value; }
        public string Urun_Ad1 { get => Urun_Ad; set => Urun_Ad = value; }
        public string Birim1 { get => Birim; set => Birim = value; }
    }
}
