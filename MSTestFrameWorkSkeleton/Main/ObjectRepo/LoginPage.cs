using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTestFrameWorkSkeleton.Main.ObjectRepo
{
    public class LoginPage
    {

        [FindsBy(How = How.Id, Using = "usernmae")]
        private IWebElement username { get; set; }

        [FindsBy(How = How.Id, Using = "inputPassword")]
        private IWebElement password { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[.='Sign in']")]
        private IWebElement login { get; set; }

        public LoginPage(IWebDriver driver) 
        {
            PageFactory.InitElements(driver, this);
        }

        public void Login(string userName,string passWord)
        {
            username.SendKeys(userName);
            password.SendKeys(passWord);
            login.Submit();
        }

    }
}
