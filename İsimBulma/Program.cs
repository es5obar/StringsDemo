using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İsimBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[5]
            {
                "Robert DeNiro",
                "Jennifer Lopez",
                "Robert Downey Jr.",
                "Al Pacino",
                "Kate Beckinsale"
            };
            for (int i = 0; i <isimler.Length ; i++)
            {
                Console.WriteLine(isimler[i]);
            }
            //foreach (string isim in isimler)
            //{
            //    Console.WriteLine(isim);
            //}
            //int j = 0;
            //while (j < isimler.Length)
            //{
            //    Console.WriteLine(isimler[j]);
            //    j++;
            //}
            Console.Write("İsim : ");
            string giris = Console.ReadLine();
            string sonuc = " ";
            bool bulunma = false;
            for (int i = 0; i < isimler.Length; i++)
            {
                if (isimler[i].Contains(giris))
                {
                    bulunma = true;
                    break;
                }
               
            }
            if (bulunma == true)
            {
                sonuc = "bulundu";
            }
            else
            {
                sonuc = "bulunamadı";
            }
            Console.WriteLine(sonuc);
            Console.ReadLine();
        }
    }
}
