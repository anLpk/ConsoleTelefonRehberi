using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    class Program
    {
        static TelefonRehberiMetodlari telefonRehberiMetodlari = new TelefonRehberiMetodlari();
        static void Main(string[] args)
        {
            SecenekleriEkranaYazdir();

            while(true)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
                string userAnswer = Console.ReadLine();

                switch(userAnswer)
                {
                    case "1":
                    telefonRehberiMetodlari.YeniNumaraKaydetme();
                    break;

                    case "2":
                    telefonRehberiMetodlari.VaralonNumarayiSilme();
                    break;

                    case "3":
                    telefonRehberiMetodlari.RehberiListelemek();
                    break;

                    case "4":
                    telefonRehberiMetodlari.VaralonNumarayiSilme();
                    break;

                    case "5":
                    telefonRehberiMetodlari.RehberdeAramaYapmak();
                    break;

                    default:
                      break;
                }
            }
        }

        static void DummyData()
        {
            Kisiler kisiler = new Kisiler("Jose", "Sosa", "0431888111");
            Kisiler kisiler2 = new Kisiler("Atiba", "Hutchinson", "0431888222");
            Kisiler kisiler3 = new Kisiler("Rachid", "Ghezzal", "0431888333");
            Kisiler kisiler4 = new Kisiler("Anil", "Pak", "0431888444");
            Kisiler kisiler5 = new Kisiler("Ridvan", "Yilmaz", "0431888555");

            telefonRehberiMetodlari.Rehber.Add(kisiler);
            telefonRehberiMetodlari.Rehber.Add(kisiler2);
            telefonRehberiMetodlari.Rehber.Add(kisiler3);
            telefonRehberiMetodlari.Rehber.Add(kisiler4);
            telefonRehberiMetodlari.Rehber.Add(kisiler5);
        }

        static void SecenekleriEkranaYazdir()
        {
            Console.WriteLine("*******************************************");
            Thread.Sleep(500);
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Thread.Sleep(500);
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Thread.Sleep(500);
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Thread.Sleep(500);
            Console.WriteLine("(4) Rehberi Listelemek");
            Thread.Sleep(500);
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            Thread.Sleep(500);
            Console.WriteLine("*******************************************");
        }
    }
}
