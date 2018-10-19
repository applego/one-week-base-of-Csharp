using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 一週間で身につくCsharpの基本
{
    class Sample502
    {
        public void write_sum_and_averate()
        {
            //double one, two, three;
            //double sum, avg;
            //one = 1.2;
            //two = 3.7;
            //three = 4.1;
            //Console.WriteLine(one + " " + two + " " + three);
            //sum = one + two + three;
            double[] d = new double[3];
            d[0] = 1.2;
            d[1] = 3.7;
            d[2] = 4.1;
            double sum, avg;
            sum = 0.0;
            for (int i = 0; i < d.Length; i++)
            {
                Console.Write(d[i] + " ");
                sum += d[1];
            }
            Console.WriteLine();
            avg = sum / 3.0;
            Console.WriteLine("合計値：" + sum);
            Console.WriteLine("平均値：" + avg);
        }
    }
}
