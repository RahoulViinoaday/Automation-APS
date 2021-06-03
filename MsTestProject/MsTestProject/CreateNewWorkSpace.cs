using OpenQA.Selenium.Chrome;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Diagnostics;
using System.Threading;


namespace AutoPaginationSystem

{
    //[TestClass]

    public class NewWorkSpaceForm
    {


        /// <summary>
        /// driver1 is login page object for selenium methods
        /// </summary>
        /// <param name="driver1"></param>
        /// 
        //[TestMethod]
        public void NewFormPage(OpenQA.Selenium.IWebDriver driver1)
        {

            // Create new workspace flow
            driver1.Navigate().Refresh();
            driver1.FindElement(By.XPath("//*[@id='root']/div[2]/div/main/div/div/div/div[1]/div[1]/div[1]")).Click();

            var dashWindowHandle = driver1.WindowHandles[0];
            Assert.IsTrue(!string.IsNullOrEmpty(dashWindowHandle));
            driver1.SwitchTo().Window(driver1.WindowHandles[0]);
            System.Threading.Thread.Sleep(2000);
            driver1.FindElement(By.XPath("//input[@id='workspaceNameInput']")).SendKeys("Automation Workspace 100");
            driver1.FindElement(By.XPath("//input[@id='workspaceSubjectInput']")).SendKeys("Automation CaseNumber 100");
            driver1.FindElement(By.XPath("//input[@id='workspaceClaimantsInput']")).SendKeys("Automation Claimants John");

            driver1.FindElement(By.XPath("//input[@id='workspaceDefendantsInput']")).SendKeys("Automation Claimants John");

            driver1.FindElement(By.XPath("//div[contains(text(),'Create')]")).Click();


            Console.Write("\nSuccessfully created new workspace ");
            //driver1.Close();
        }
    }
}
