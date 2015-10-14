using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonFunctions;

namespace test
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] i = { 1, 2, 3, 4, 55, 4, 3, 2, 3 };
            
            BuildList<int> list = new BuildList<int>(i);

            List<int> iList = list.List;

            foreach(int num in iList)
            {
                Console.WriteLine(num);
            }
            Console.Read();
        }
    }
}
