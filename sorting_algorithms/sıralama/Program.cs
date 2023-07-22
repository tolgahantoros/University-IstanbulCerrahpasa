using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void programsec()
        {
            int[] dizi = new int[20];
            Random r = new Random();


            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = r.Next(0, 100);
            }
            Console.WriteLine("dizi : ");

            foreach (var item in dizi)
            {
                Console.Write(" " + item);
            }
            int secim = 0;
            Console.WriteLine("\nBUBBLE SORT = 1 \nSELECTION SORT = 2 \nQUICK SORT = 3  \nMERGE SORT = 4 \nCIKIS = -1 ");
            secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {

                case 1:
                    Console.WriteLine("Bubble Sort");
                    bublesort(dizi);
                    break;
                case 2:
                    Console.WriteLine("SELECTION SORT");
                    selectionsort(dizi);

                    break;
                case 3:
                    Console.WriteLine("QUICK SORT");
                    quicksort(dizi, 0, dizi.Length - 1);
                    foreach (var item in dizi)
                    {
                        Console.Write(" " + item);
                    }
                    break;
                case 4:
                    Console.WriteLine("MERGE SORT");
                    mergesort(dizi);
                    break;
                case -1:
                    Console.WriteLine("Exitting Program");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Hatalı seçim");
                    break;
            }
            Console.WriteLine("\nBaşka Sıralama yapmak istiyor musun? - Evet = 1");
            int cevap = Convert.ToInt32(Console.ReadLine());
            if (cevap == 1)
            {
                Console.Clear();
                programsec();
            }
            else
            {
                Environment.Exit(0);
            }

        }
        static void selectionsort(int[] dizi)
        {

            for (int i = 0; i < dizi.Length - 1; i++)
            {
                for (int j = i + 1; j < dizi.Length; j++)
                {
                    if (dizi[j] < dizi[i])
                    {
                        int degistir = dizi[(j)];
                        dizi[j] = dizi[i];
                        dizi[i] = degistir;
                    }

                }
            }

            DiziYazdir(dizi);
        }
        private static void quicksort(int[] dizi, int bitis, int baslangic)
        {
            if (bitis < baslangic)
            {
                int sayi = Partition(dizi, bitis, baslangic);

                if (sayi > 1)
                {
                    quicksort(dizi, bitis, sayi - 1);
                }
                if (sayi + 1 < baslangic)
                {
                    quicksort(dizi, sayi + 1, baslangic);
                }
            }

        }

        private static int Partition(int[] dizi, int bitis, int baslangic)
        {
            int sayi = dizi[bitis];
            while (true)
            {

                while (dizi[bitis] < sayi)
                {
                    bitis++;
                }

                while (dizi[baslangic] > sayi)
                {
                    baslangic--;
                }

                if (bitis < baslangic)
                {
                    if (dizi[bitis] == dizi[baslangic]) return baslangic;

                    int temp = dizi[bitis];
                    dizi[bitis] = dizi[baslangic];
                    dizi[baslangic] = temp;


                }
                else
                {
                    return baslangic;
                }
            }
        }

        static void bublesort(int[] dizi)
        {
            int gecici = 0;
            for (int i = 0; i <= dizi.Length - 1; i++)
            {
                for (int j = 1; j <= dizi.Length - 1; j++)
                {
                    if (dizi[j - 1] > dizi[j])
                    {
                        gecici = dizi[j - 1];
                        dizi[j - 1] = dizi[j];
                        dizi[j] = gecici;
                    }
                }
                DiziYazdir(dizi);
            }
            Console.WriteLine("Dizinin Sıralı Hali");
            DiziYazdir(dizi);

        }

        public static void DiziYazdir(int[] dizi)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write("{0}   ", dizi[i]);
            }
            Console.WriteLine();
            Console.WriteLine("T-O-L-G-A-H-A-N-T-O-R-O-S");
        }

        static int[] mergesort(int[] d)
        {
            if (d.Length <= 1)
                return d;

            int i = 0;
            int bol = d.Length / 2;

            int[] sol = new int[bol];
            int[] sag = new int[d.Length - bol];


            for (i = 0; i < bol; i++)
            {
                sol[i] = d[i];
            }

            int k = 0;
            for (i = bol; i < d.Length; i++)
            {
                sag[k] = d[i];
                k++;
            }

            sol = mergesort(sol);
            sag = mergesort(sag);

            return birlestir(sol, sag);
        }

        static int[] birlestir(int[] sol, int[] sag)
        {

            int[] a = new int[sol.Length + sag.Length];

            int i = 0, j = 0, k = 0;

            while (j < sol.Length && i < sag.Length)
                a[k++] = (sag[i] < sol[j]) ? sag[i++] : sol[j++];

            while (i < sag.Length)
                a[k++] = sag[i++];
            while (j < sol.Length)
                a[k++] = sol[j++];

            DiziYazdir(a);
            return a;
        }

        static void Main(string[] args)
        {
            programsec();
            Console.ReadKey();
        }
    }
}