using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestFrameWorkSkeleton.Generic;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MSTestFrameWorkSkeleton.Tests
{
    [TestClass]
    public class RmgProjectTest : BaseClass
    {

        [ClassInitialize]
        public static void link(TestContext context)
        {
            driver.Url = url;
        }
        [TestMethod]
        public void createAnEmployeeTest()
        {
            //  driver.FindElement(By.XPath("//a[.='Projects']")).Click();
            // driver.FindElement(By.XPath("//span[.='Create Project']")).Click();
            Console.WriteLine("");
        }
        [ClassCleanup]
        public static void cleanup()
        {
            driver.Close();
        }

    }
}
