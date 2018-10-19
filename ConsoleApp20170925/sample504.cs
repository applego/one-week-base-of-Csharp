using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 一週間で身につくCsharpの基本
{
    class Sample504
    {
        public void test_foreach()
        {
            int[] n = { 1, 2, 3, 4 };
            foreach(int i in n)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
