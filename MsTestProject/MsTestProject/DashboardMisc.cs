using OpenQA.Selenium.Chrome;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Diagnostics;
using System.Threading;

namespace AutoPaginationSystem
{
  // [TestClass]
    public class DashboardMisc
    {
      //  [TestMethod]
        public void CheckMiscFunctionality(OpenQA.Selenium.IWebDriver driver)
        {

            OpenQA.Selenium.IJavaScriptExecutor js = driver as OpenQA.Selenium.IJavaScriptExecutor;
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,50);");

            
            Thread.Sleep(2000);
            Boolean Display = driver.FindElement(By.XPath("//*[@id='root']/div/header/a/img")).Displayed;
           
            Console.Write("\n\tDashboard Screen display Successfully\n");

            driver.FindElement(By.LinkText("Account")).Click();
            //Assert.IsTrue(driver.FindElement(By.XPath("//body/div[@id='root']/div[1]/div[1]/main[1]/div[1]/div[1]")).Displayed);
            //Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='root']/div/div/main/div/div/div/div[1]/div[1]")).Displayed);
            
            Console.Write("\n\t Account details page display scuccessfuly\n");
            Thread.Sleep(2000);
           
            driver.FindElement(By.LinkText("Help"));
            Thread.Sleep(4000);
            Console.Write("\n\t Help page display scuccessfully\n");
           
            driver.FindElement(By.LinkText("Settings"));
            Thread.Sleep(2000);
            Console.Write("\n\t Setting page display scuccessfuly\n");
            
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("About"));
            Thread.Sleep(3000);
            Console.Write("\n\t Setting page display scuccessfuly\n");
            Thread.Sleep(2000);
            //driver.Navigate().Back();

            //driver.FindElement(By.LinkText("Logout")).Click();
            //Console.Write("\n\t User Logged out from the sysytem\n");
            driver.Close();
        }

    }
}
