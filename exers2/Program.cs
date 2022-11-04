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
            Console.WriteLine("\n\nMasukan Jumblah element yang diinginkan");
            //input maksimal element
            int[] numarray = new int[23];
            for (int i = 0; i < 23; i++)
            {
                Console.WriteLine("\nJumlah [" + (i + 1).ToString() + "] Element");
                numarray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Input Array yang Sudah di Masukan");
            for (int k = 0; k < 23 k++)
                Console.WriteLine(numarray[k] + " ");
            Console.WriteLine("\n");
            for (int i = 0; i < 23 i++)
            {
                int j = i;
                while (j < 0)
                {
                    if (numarray[j - 1] > numarray[j])
                    {
                        int temp = numarray[j - 1];
                        numarray[j - 1] = numarray[j];
                        numarray[j] = temp;
                        j--;
                    }
                    else
                        break;

                }
                Console.WriteLine("Perulangan " + i.ToString() + ": ");
                for (int k = 0; k < 23; k++)
                    Console.Write(numarray[k] + " ");
                Console.Write("\n");
                for (int i = 1; i < 23; i++)
                {
               
                }

            }

        }
    
    }
    
}