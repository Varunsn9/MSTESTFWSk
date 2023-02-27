using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTestFrameWorkSkeleton.Main.ObjectRepo
{
    public class ProjectsPage
    {
        [FindsBy(How = How.XPath, Using = "//span[.='Create Project']")]
        private IWebElement createProject { get; set; }

        [FindsBy(How = How.Name, Using = "projectName")]
        private IWebElement projectName { get; set; }

        [FindsBy(How = How.Name, Using = "createdBy")]
        private IWebElement projectManager { get; set; }

        [FindsBy(How = How.Name, Using = "status")]
        private IWebElement status { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='Add Project']/preceding-sibling::input")]
        private IWebElement cancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='Add Project']")]
        private IWebElement addProject { get; set; }
        
       

    }
}
