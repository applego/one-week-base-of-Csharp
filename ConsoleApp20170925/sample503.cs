using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 一週間で身につくCsharpの基本
{
    class Sample503
    {
        public void write_arr()
        {
            int[] n = { 5, 4, 3, 2, 1 };
            string[] s = { "ABC", "DEF", "GHI" };
            int i;
            //整数型配列変数nの成分表示
            for(i = 0; i < n.Length; i++)
            {
                Console.Write(n[i] + " ");
            }
            Console.WriteLine();
            //文字列型配列ｓの成分表示
            for(i = 0; i < s.Length; i++)
            {
                Console.Write(s[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
