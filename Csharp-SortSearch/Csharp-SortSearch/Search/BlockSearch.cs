﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_SortSearch.Search
{
    /*
     * 功能
     * 分块查找
     * 块间有序，块内无序
     * Epulari T 
     * 2018.8.14
     */
    class BlockSearch
    {
        /// <summary>
        /// 分块查找-数组已经是需要的结构
        /// </summary>
        /// <param name="arr">数组</param>
        /// <param name="key">关键字</param>
        public int MyBlockSearch(int[] arr, int key, int blen)
        {
            int len = arr.Length;

            int num = len / blen, remainder = len % blen;
            if(remainder != 0)
            {
                num += 1;
            }

            int[][] temp = new int[num][];
            int[] minmax = new int[2 * num];
            int k = 0;
            for(int i = 0; i < num; i++)
            {
                if(i != num -1)
                {
                    temp[i] = new int[blen];
                }
                else
                {
                    int lastlen = len - k;
                    temp[i] = new int[lastlen];
                }

                minmax[i] = arr[i * blen];
                for (int j = 0; j < temp[i].Length; j++)
                {
                    temp[i][j] = arr[k++];
                    minmax[i] = Math.Min(minmax[i], temp[i][j]);
                    minmax[i + num] = Math.Max(minmax[i], temp[i][j]);

                }
            }
            Console.WriteLine("序列数组：");
            foreach (int[] m in temp)
            {
                if (m != null)
                {
                    foreach (int n in m)
                    {
                        Console.Write(n + " ");
                    }
                    //换行，每个序列为一行
                    Console.WriteLine();
                }
            }
            Console.WriteLine("最小值最大值：");
            foreach (int m in minmax)
            {
                Console.Write(m + " ");
            }
            Console.WriteLine();

            BinarySearch bs = new BinarySearch();
            int indexblock = bs.MyBinarrySearchRange(minmax, key, num);
            if (indexblock != -1)
            {
                //使用二分查找找到关键值在块内的索引
                int indexnum = bs.MyBinarySearch(temp[indexblock], key);
                if (indexnum != -1)
                {
                    return indexnum + indexblock * blen;
                }
            }
            return -1;
        }
    }
}
