using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Sort
{
    class SelectionSort
    {

        static void Selection_Sort(int[] a, int n)
        {
            //Khai báo biến tạm để đổi chỗ các phần tử
            for (int i = 0; i < n - 1; i++) //Mảng chỉ có 1 phần tử luôn sắp thứ tự
            {
                int minIndex = i; //Tìm ra chỉ số đầu tiên sao cho giá trị thích hợp nhất
                //Ứng với chỉ số lớn hơn a[i] để chèn vào để dãy có thứ tự
                for (int j = i + 1; j < n; j++)
                {
                    if (a[minIndex] > a[j]) //Đổi giá trị của minIndex
                    {
                        minIndex = j;
                    }
                }
                //Sau khi tìm được chỉ số minIndex thích hợp đổi chỗ
                int tempo = a[minIndex];
                a[minIndex] = a[i];
                a[i] = tempo;
            }
        }
        static void Main(string[] args)
        {
            Stopwatch s = new Stopwatch();
            s.Start();
            bool a = true;
            while(a)
            {
                int[] myArray = new int[1000]; 

                Random rd = new Random();
                for (int i = 0; i < 1000; i++)
                {
                    myArray[i] = rd.Next(0, 1000);
                }

                Selection_Sort(myArray, 1000);
                for (int i = 0; i < 1000; i++)
                {
                    Console.Write(myArray[i] + "\t");
                }
                    if (Console.ReadLine() != "")
                        a = false;
                s.Stop();
               
                Console.WriteLine(s.Elapsed);
                Console.ReadKey();
                Console.Clear();
            }    
          

            
        }


    }
}