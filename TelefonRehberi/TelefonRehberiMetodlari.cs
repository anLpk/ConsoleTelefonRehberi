using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    public class TelefonRehberiMetodlari
    {
        public List<Kisiler> Rehber = new List<Kisiler>();
        public void YeniNumaraKaydetme()
        {
            Console.WriteLine("Lütfen isim giriniz             :");
            string isim = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz          :");
            string soyIsim = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz :");
            string telefonNumarasi = Console.ReadLine();
            Kisiler yeniKisi = new Kisiler(isim, soyIsim, telefonNumarasi);
            Rehber.Add(new Kisiler(isim, soyIsim, telefonNumarasi));
        }

        public void VaralonNumarayiSilme()
        {
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string isimYadaSoyisim = Console.ReadLine();
        }

        public void VaralonNumarayiGuncelleme()
        {
            Console.WriteLine("*************VaralonNumarayiGuncelleme****************");
        }

        public void RehberiListelemek()
        {
            foreach(Kisiler kisi in Rehber)
            {
                Console.WriteLine("Isim: {0}", kisi.Ad);
                Console.WriteLine("Soyisim: {0}", kisi.Soyad);
                Console.WriteLine("Telefon Numarasi: {0}", kisi.TelefonNo);
            }
        }

        public void RehberdeAramaYapmak()
        {
            Console.WriteLine("***********RehberdeAramaYapmak*********");
        }
    }
}
