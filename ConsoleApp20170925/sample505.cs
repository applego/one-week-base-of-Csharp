﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 一週間で身につくCsharpの基本
{
    class Sample505
    {
        public void 二次元配列()
        {
            int[,] a = new int[3, 4];
            int m, n;
            //二次元配列に値を代入
            for(m = 0; m < 3; m++){
                for(n= 0; n < 4; n++) {
                    a[m, n] = m + n;
                }
            }
            //二次元配列に値を出力
            for (m = 0; m < 3; m++)
            {
                for (n = 0; n < 4; n++)
                {
                    Console.Write("a[{0}][{1}] = {2}  ", m, n, a[m, n]);
                }
                Console.WriteLine();
            }
        }
    }
}
