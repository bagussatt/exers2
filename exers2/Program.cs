using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exers2
{
    class program
    {
        static int InsertionSorting()
        {   //Input element
            Console.WriteLine("\nProgram Untuk Menjalankan Insertionn");
            Console.WriteLine("\n\nMasukan Jumlah element yang diinginkan");
            //input maksimal element
            int[] bagus = new int[23];
            for (int i = 0; i < 23; i++)
            {
                Console.WriteLine("\nJumlah [" + (i + 1).ToString() + "] Element");
                bagus[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Input Array yang Sudah di Masukan");
            for (int k = 0; k < 23; k++)
                Console.WriteLine(bagus[k] + " ");
            Console.WriteLine("\n");
            for (int i = 0; i < 23; i++)
            {
                int bs = i;
                while (bs < 0)
                {
                    //melakukan penukaran fungsi
                    if (bagus[bs - 1] > bagus[bs])
                    {
                        int temp = bagus[bs - 1];
                        bagus[bs - 1] = bagus[bs];
                        bagus[bs] = temp;
                        bs--;
                    }
                    else
                        break;

                }
                //menampilkan tampilan perulangan
                Console.WriteLine("Perulangan " + i.ToString() + ": ");
                for (int k = 0; k < 23; k++)
                    Console.Write(bagus[k] + " ");
                Console.Write("\n");
                Console.Write(" " + (i + 1).ToString() + " angka dari awal array dimasukkan dan diurutkan \n");

            }
            Console.Write("\n\n Angka di urutkan dari atas kebawah: \n\n");
            for (int i = 0; i < 23; i++)
            {
                //menampilkan pengurutan
                Console.Write("Pengurutan [" + (i + 1).ToString() + "] elemennt :");
                Console.Write(bagus[i]);
                Console.Write("\n");

            }
            return 0;
        }
        //memanggil kelas
        static void Main(string[] args)
        {
            InsertionSorting();
            Console.ReadLine();
        }
    }

    class MergeSort
    {
        static public void MainMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[23];
            int i, eol, num, pos;
            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);
        }
    }



}

        