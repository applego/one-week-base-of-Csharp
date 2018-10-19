using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 一週間で身につくCsharpの基本
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample502 sample502 = new Sample502();
            sample502.write_sum_and_averate();

            //配列
            Sample503 sample503 = new Sample503();
            sample503.write_arr();

            //ループ
            Sample504 sample504 = new Sample504();
            sample504.test_foreach();

            //二次元配列
            Sample505 sample505 = new Sample505();
            sample505.二次元配列();

            //二次元配列②
            Sample506 sample506 = new Sample506();
            sample506.二次元配列second();

            //問題５
            Sample507 sample507 = new Sample507();
            sample507.q_5();
        }
    }
}
