using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTestFrameWorkSkeleton.Main.ObjectRepo
{
    public class HomePage
    {
        [FindsBy(How=How.XPath,Using = "//p[.='Menu']/parent::ul/descendant::a[.='Home']")]
        private IWebElement homeLink { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//p[.='Menu']/parent::ul/descendant::a[.='Projects']")]
        private IWebElement projectsLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[.='Menu']/parent::ul/descendant::a[.='Users']")]
        private IWebElement userLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[.='Menu']/parent::ul/descendant::a[.='Settings']")]
        private IWebElement settingsLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[.='Menu']/parent::ul/descendant::a[.='Logout']")]
        private IWebElement logoutLink { get; set; }

        public HomePage(IWebDriver driver) 
        {
            PageFactory.InitElements(driver, this);
        }

        public void Home()
        {
            homeLink.Click();
        }

        public void Projects()
        {
            projectsLink.Click();
        }

        public void User()
        {
            userLink.Click();
        }

        public void Settings()
        {
            settingsLink.Click();
        }
        
        public void Logout()
        {
            logoutLink.Click();
        }

    }
}
