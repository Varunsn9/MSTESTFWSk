using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestFrameWorkSkeleton.Main.ObjectRepo;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSTestFrameWorkSkeleton.Generic
{
    [TestClass]
    public class BaseClass
    {
       public static IWebDriver driver;
        public static string url = "http://localhost:8084/";   
        public static LoginPage loginPage;


        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
            //MessageBox.Show("AssemblyInit " + context.TestName);
            driver = new ChromeDriver();
        }

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            //MessageBox.Show("ClassInit " + context.TestName);
        }

        [TestInitialize]
        public void Initialize()
        {
            //MessageBox.Show("TestMethodInit");
            loginPage=new LoginPage(driver);
            loginPage.Login("rmgyantra","rmgy@9999");
        }

        [TestCleanup]
        public void Cleanup()
        {
            Thread.Sleep(1000);
            //MessageBox.Show("TestMethodCleanup");
            driver.FindElement(By.XPath("//a[.='Logout']")).Click();
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            //MessageBox.Show("ClassCleanup");
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            //MessageBox.Show("AssemblyCleanup");
            driver.Quit();
        }

        [TestMethod]
        //[ExpectedException(typeof(System.DivideByZeroException))]
        public void DivideMethodTest()
        {
            Console.WriteLine("amazon");
        }
    }
}
