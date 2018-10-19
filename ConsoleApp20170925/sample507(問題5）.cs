using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 一週間で身につくCsharpの基本
{
    class Sample507
    {
        public void q_5()
        {
            int[] a = new int[7];
            Random r = new Random();
            /*for(int i = 0; i < 10; i++) {}*/
            //int m = 0;
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            for (int n = 0;n<a.Length;n++)
            {
                int r1 = r.Next(1, 11);
                a[n] = r1;
                Console.Write("a[{0}] = {1}  ", n, a[n]);
                //m++;
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            double[] d = new double[4] { 0.2,-5.1,3.2,1.8};
            int i = 0;
            foreach(double x in d)
            {
                Console.Write("d[{0}] = {1}  ", i, x);
                i++;
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            int[] data = new int[10];
            string odd= "奇数：";
            string even = "偶数：";
            for(int m = 0; m < data.Length; m++)
            {
                int r2 = r.Next(1, 101);
                data[m] = r2;
                if(data[m]%2 == 0)
                {
                    even += data[m].ToString()+" ";
                }
                else
                {
                    odd += data[m]+" ";
                }
                Console.Write("data[{0}] = {1}  ", m, data[m]);
            }
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine(odd);
            Console.WriteLine(even);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            string san_no_baisuu = "3の倍数：";
            string not_san_no_baisuu = "3の倍数以外の数：";

            for (int o = 0; o < data.Length; o++)
            {
                int r3 = r.Next(1, 11);
                data[o] = r3;
                if(data[o]%3 == 0)
                {
                    san_no_baisuu += data[o] +" ";
                }
                else
                {
                    not_san_no_baisuu += data[o] + " ";
                }
                Console.Write(data[o] + " ");
            }
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine(san_no_baisuu);
            Console.WriteLine(not_san_no_baisuu);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            for(int m = 0; m < data.Length; m++)
            {
                data[m] = r.Next(1, 11);
                Console.Write(data[m] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("最大値：{0}",data.Max());
            Console.WriteLine("最小値：{0}", data.Min());
            Console.WriteLine("平均値：{0}", data.Average());
        }
    }
}
