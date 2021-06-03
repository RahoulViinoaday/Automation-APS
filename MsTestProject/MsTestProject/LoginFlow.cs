using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Diagnostics;
using System.Threading;
using System;


namespace AutoPaginationSystem
{
    [TestClass]
    public class LoginFlow
    {
        //[TestMethod]
        //public static void Main(string[] args)
        //{
        //    int option;
        //    option = 3;
        //    LoginFlow loginFlow = new LoginFlow();
        //    OpenQA.Selenium.IWebDriver driver = loginFlow.Login();
        //    switch (option)
        //    {
                
        //        // Creat New workspace 
        //        case 1:
        //            NewWorkSpaceForm form = new NewWorkSpaceForm();
        //            form.NewFormPage(driver);
        //            //  goto case 3 ;
        //            break;
        //        case 2:
        //            UploadFile UF = new UploadFile();
        //            UF.FileUploadFlow(driver);
        //            break;

        //        //3 : Recent workspace flow
        //        case 3:
        //            Recentworkspace RF = new Recentworkspace();
        //            RF.NavigateToRecentWorkspace(driver);
        //            break;

        //        // 4 : For To verify Dashbaord UI Functionality(Left Panel,Header)
        //        case 4:
        //            DashboardMisc DM = new DashboardMisc();
        //            DM.CheckMiscFunctionality(driver);
        //            break;

        //        // 5 : For to verify the page selection and Drop in category folder
        //        case 5:
        //            RecentWorkSpace_PageSelection PS = new RecentWorkSpace_PageSelection();
        //            PS.NavigateToRecentWorkspacePageSelection(driver);
        //            break;

        //    }

           // driver.Close();

       // }

        [TestMethod]
        public IWebDriver Login()
        {
            OpenQA.Selenium.IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://aps.stg.fs.co.uk/");
          
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(40);
            driver.Manage().Cookies.DeleteAllCookies();
            
            driver.FindElement(By.TagName("button")).Click();
            Thread.Sleep(4000);
            var newWindowHandle = driver.WindowHandles[1];
            Assert.IsTrue(!string.IsNullOrEmpty(newWindowHandle));
            driver.SwitchTo().Window(driver.WindowHandles[1]);
          Thread.Sleep(2000);
            //driver.FindElement(By.XPath("//body[1]/div[1]/form[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/input[1]")).SendKeys("rahoulviinoaday@fs.co.uk");
            driver.FindElement(By.CssSelector("#i0116")).SendKeys("rahoulviinoaday@fs.co.uk");
            driver.FindElement(By.CssSelector("#idSIButton9")).Click();
            driver.FindElement(By.CssSelector("#i0118")).SendKeys("Rvaishu$25"); 
            Thread.Sleep(2000);

            driver.FindElement(By.CssSelector("#idSIButton9")).Click();
          Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#idSIButton9")).Click();
            //driver.FindElement(By.XPath("/html/body/div/form[1]/div/div/div[2]/div/div/div[1]/div[2]/div[2]/div/div[2]/div/div[3]/div[2]/div/div/div/div/input")).Click();
            //driver.FindElement(By.XPath("//input[@id='idBtn_Back']")).Click();
            Thread.Sleep(3000);
            var dashWindowHandle = driver.WindowHandles[0];
            Assert.IsTrue(!string.IsNullOrEmpty(dashWindowHandle));
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Thread.Sleep(3000);
            driver.Manage().Window.Maximize();
            //driver.FindElement(By.XPath("//header/ul[1]/li[2]/a[1]/span[1]")).Click(); //Profile Button//
            // driver.FindElement(By.ClassName("border-bottom")).Click();                                                         

            //driver.FindElement(By.CssSelector("#talos-dropzone")).Click();

            //// driver.FindElement(By.XPath("//div[@id='talos-mergezone-container']")).Click();
            ////driver.FindElement(By.XPath("//span[contains(text(),'Choose file(s)')]")).Click();
            //// driver.FindElement(By.XPath("//body/div[@id='root']/div[1]/div[1]/main[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/span[1]")).Click();

            Console.Write("\nTest Executed suceessfully from loginFlow \n");

            return driver;

        }
    }
}
