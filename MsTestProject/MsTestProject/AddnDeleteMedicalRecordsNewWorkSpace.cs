using AutoPaginationSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace AutoPaginationSystem
{
    [TestClass]
    public class AddnDeleteMedicalRecordsNewWorkSpace
    {
        //[TestMethod]
        public void AddMedicalRecord(OpenQA.Selenium.IWebDriver driver)
        {         
            NewWorkSpaceForm space = new NewWorkSpaceForm();
            space.NewFormPage(driver);
            Thread.Sleep(5000);
            //driver.Navigate().Refresh();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/main[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[3]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/div[1]")).Click();
            
            var option = driver.FindElement(By.Id("workspaceInput"));
            var selectElement = new SelectElement(option);
            Thread.Sleep(2000);
            selectElement.SelectByIndex(2);
            driver.FindElement(By.XPath("//div[contains(text(),'Add')]")).Click();
            
            IWebElement Addrecord = driver.FindElement(By.XPath("//*[@id='addToOrCreateWorkspaceModal']/div/div/div[4]"));
            Console.WriteLine("\n"+Addrecord.Text);
            Thread.Sleep(5000);
            OpenQA.Selenium.IJavaScriptExecutor js = driver as OpenQA.Selenium.IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,1000);");
            Thread.Sleep(3000);
         //  driver.FindElement(By.XPath("//*[@id='cell-86tfHl0E8o-5e7465ba-7efc-44c4-b595-628a904aa0cc']/div/button[1]")).Click();
          driver.FindElement(By.XPath("//body/div[@id='root']/div[2]/div[1]/main[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/div[3]/div[5]/div[1]/button[1]")).Click();
            //driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/main[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/div[5]/div[5]/div[1]/button[1")).Click();
            Thread.Sleep(2000);
            IWebElement deleterecord = driver.FindElement(By.XPath("//body/div[2]/div[1]/div[1]/div[1]"));
            Console.WriteLine(deleterecord.Text);
            driver.FindElement(By.XPath("//button[contains(text(),'Yes')]")).Click();

            driver.Close();

        }
    }
}
