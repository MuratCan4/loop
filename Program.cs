using System;

namespace loop
{
    class Program
    {
        static void Main (string[] args)
        {
            int cift_toplam = 0;
            int tek_toplam = 0;
            for(int i=0; i <100; i++)
            {
                if(i %2== 0)
                    cift_toplam += i;
                else
                tek_toplam +=i;
            }
            Console.WriteLine("Çift Sayıların Toplamı = "+cift_toplam);
            Console.WriteLine("Tek Sayıların Toplamı = "+tek_toplam);

            for(int i=0; i <10; i++)
            {
                if (i == 7)
                    break;
                    Console.WriteLine(i);
            }
            
               for(int i=0; i <10; i++)
            {
                if (i == 7)
                    continue;
                    Console.WriteLine(i);
            }
        } 
    }
}