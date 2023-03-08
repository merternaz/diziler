using System;
using System.Collections.Generic;

namespace forLoobBr
{
    class Program
    {
        
        static void Main(string[] args)
        {

            string[] hayvanlar={"aslan","kedi","zebra"};
            Console.WriteLine(hayvanlar[1]);

            int[] sayilar=new int[10];
            int toplamSayilar=0;

            for(int i=0;i<sayilar.Length;i++){
                sayilar[i]=i+1;
                toplamSayilar+=sayilar[i];

            }

            Console.WriteLine("ortalama:"+toplamSayilar/sayilar.Length);



        }
    }
}