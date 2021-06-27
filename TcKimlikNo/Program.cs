using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcKimlikNo
{
    class Program
    {
        
        static double[] tcNo = new double[11];
        static double sonuc;
        static void Main(string[] args)
        {
            Console.WriteLine("Lutfen kimlik numaranizi giriniz: ");
            string giris = Console.ReadLine();

            KontrolEt(giris);
            Console.ReadLine();

        }

        static bool IlkHane(string giris)
        {
            if (giris.Substring(0,1)=="0")
            {
                return false;
            }

            return true;
        }

        static bool HaneSayisi(string giris)
        {
            if (giris.Length!=11)
            {
                return false;
            }

            return true;
        }

        static bool Hane10DogruMu(string giris)
        {
            
            double sonucTek = 0;
            double sonucCift = 0;
            
            for (int i = 0; i < tcNo.Length-1; i+=2)
            {
                tcNo[i]=Convert.ToDouble(giris[i].ToString());
                sonucTek += tcNo[i];
                

            }
            

            for (int i = 1; i <tcNo.Length-1; i+=2)
            {
                tcNo[i] = Convert.ToDouble(giris[i].ToString());
                sonucCift += tcNo[i];
                
            }
            
            
            sonuc = (sonucTek * 7 - sonucCift) % 10;
            if (sonuc==tcNo[10])
            {
                
                return true;
            }
            
            return false;


        }

        static bool Hane11DogruMu(string giris)
        {
            double tutlanDeger = 0;
            if (Hane10DogruMu(giris)==true)
            {
                for (int i = 0; i < tcNo.Length; i++)
                {
                    tutlanDeger = tcNo[i] % 10;
                    
                }
                
                sonuc = tutlanDeger;
                if (sonuc==tcNo[10])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        static void KontrolEt(string giris)
        {
            if (IlkHane(giris)&&HaneSayisi(giris)&&Hane11DogruMu(giris)&&Hane10DogruMu(giris))
            {
                Console.WriteLine("TC kimlik no gecerlidir."+giris);
            }
            else
            {
                Console.WriteLine("Kimlik numaraniz gecersizdir..."+giris);
            }
        }
    }
}
