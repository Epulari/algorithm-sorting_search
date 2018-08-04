﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr_bs = { 7, 26, 53, 22, 32, 28, 38, 23, 24, 54, 27, 78, 33 };
            //冒泡排序
            BubbleSort bs = new BubbleSort();
            Console.WriteLine("冒泡排序：");
            bs.MyBulleSort(arr_bs);
            /*result
                7 26 22 32 28 38 23 24 53 27 54 33 78
                7 22 26 28 32 23 24 38 27 53 33 54 78
                7 22 26 28 23 24 32 27 38 33 53 54 78
                7 22 26 23 24 28 27 32 33 38 53 54 78
                7 22 23 24 26 27 28 32 33 38 53 54 78
                7 22 23 24 26 27 28 32 33 38 53 54 78
                7 22 23 24 26 27 28 32 33 38 53 54 78
                7 22 23 24 26 27 28 32 33 38 53 54 78
                7 22 23 24 26 27 28 32 33 38 53 54 78
                7 22 23 24 26 27 28 32 33 38 53 54 78
                7 22 23 24 26 27 28 32 33 38 53 54 78
                7 22 23 24 26 27 28 32 33 38 53 54 78
                程序的运行时间：0.0242318 秒
             */

            int[] arr_qs = { 7, 26, 53, 22, 32, 28, 38, 23, 24, 54, 27, 78, 33 };
            //快速排序
            QuickSort qs = new QuickSort();
            Console.WriteLine("快速排序：");
            qs.MyQuickSort(arr_qs, 0, arr_qs.Length - 1);
            /*result
                7 26 53 22 32 28 38 23 24 54 27 78 33
                7 24 23 22 26 28 38 32 53 54 27 78 33
                7 22 23 24 26 28 38 32 53 54 27 78 33
                7 22 23 24 26 28 38 32 53 54 27 78 33
                7 22 23 24 26 27 28 32 53 54 38 78 33
                7 22 23 24 26 27 28 32 53 54 38 78 33
                7 22 23 24 26 27 28 32 33 38 53 78 54
                7 22 23 24 26 27 28 32 33 38 53 78 54
                7 22 23 24 26 27 28 32 33 38 53 54 78
             */

            int[] arr_iss = { 7, 26, 53, 22, 32, 28, 38, 23, 24, 54, 27, 78, 33 };
            //插入排序
            InsertionSort iss = new InsertionSort();
            Console.WriteLine("插入排序：");
            iss.MyInsertionSort(arr_iss);
            /*result
                7 26 53 22 32 28 38 23 24 54 27 78 33
                7 26 53 22 32 28 38 23 24 54 27 78 33
                7 22 26 53 32 28 38 23 24 54 27 78 33
                7 22 26 32 53 28 38 23 24 54 27 78 33
                7 22 26 28 32 53 38 23 24 54 27 78 33
                7 22 26 28 32 38 53 23 24 54 27 78 33
                7 22 23 26 28 32 38 53 24 54 27 78 33
                7 22 23 24 26 28 32 38 53 54 27 78 33
                7 22 23 24 26 28 32 38 53 54 27 78 33
                7 22 23 24 26 27 28 32 38 53 54 78 33
                7 22 23 24 26 27 28 32 38 53 54 78 33
                7 22 23 24 26 27 28 32 33 38 53 54 78
             */

            

            Console.ReadKey();
            
        }
    }
}
