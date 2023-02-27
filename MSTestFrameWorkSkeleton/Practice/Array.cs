using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MSTestFrameWorkSkeleton.Practice
{
    [TestClass]
    public class Array
    {
        [TestMethod]
        public void arr()
        {
            int[] a = { 4, 5, 6, 2, 3, 2, 1 };
            int[] b = { 4, 6, 5, 2, 3, 2, 5 };
            int count = 0;
            bool c=false;
            for (int i=0; i < a.Length; i++)
            {
                count = 0;
                for (int j = 0; j < b.Length; j++)
                {
                     
                    if (a[i] == b[j])
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine(" arrays are not same" );
                    c = true;
                    break;

                }
            }
            if (c == false)
            {
                Console.WriteLine("are same");
            }
        }
    }
}
