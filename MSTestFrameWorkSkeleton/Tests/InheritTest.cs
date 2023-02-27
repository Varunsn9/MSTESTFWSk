using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestFrameWorkSkeleton.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSTestFrameWorkSkeleton.Tests
{
    [TestClass]
    [TestCategory("TestClass")]
    public class InheritTest : BaseClass
    {
        [ClassInitialize]
        public static void classini(TestContext context)
        {
            MessageBox.Show("Class ini "+context.TestName);
        }
        [ClassCleanup]
        public static void ClassCleanUp()
        {
            MessageBox.Show("ClassCleanUp");
        }

        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("hello");
            MessageBox.Show("TestMethod1");
        }
        
    }
   
}
