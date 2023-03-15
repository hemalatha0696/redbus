using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using redbus.Helpers;
using redbus.Locators;
using System;
using System.Data.Common;
using System.Security.Policy;
using System.Xml.Linq;

namespace redbus.RedBus
{
    public class LoginPage : DriverHelper
    {

        Homepage_Locators hp = new Homepage_Locators();
        [OneTimeSetUp]
        public void oneSetup()
        {
            GenericHelpers.CurrentTestName();
            BrowserHelpers bp = new BrowserHelpers();

            driver = bp.ChromeInitialize(driver, "https://www.redbus.in/");
        }

        [Test,Order(0), Category("Seraching All operators in home page")]
        public void SearchOperator()
        {
            GenericHelpers.CurrentTestName();
            JSExecutorHelper js = new JSExecutorHelper();
            GenericHelpers gp = new GenericHelpers();
            
            try
            {
                var ele = driver.FindElement(By.XPath(hp.homeoperator));
                JSExecutorHelper.jsjs(driver, ele);
                //Thread.Sleep(1000);
                GenericHelpers.Clickelement(driver, hp.homeoperator);
                GenericHelpers.switchtabs(driver);
            }
            catch (Exception ex)
            {
                if (driver != null)
                    driver.Quit();
                throw;
            }
            //finally
            //{
            //    if (driver != null)
            //        driver.Quit();
            //}

        }

        [Test,Order(1), Category("Search I operators")]
        public void SearchWithIndexOperator_I()
        {

            GenericHelpers.CurrentTestName();
            try
            {
                GenericHelpers.findallelements(driver, hp.operators);
                GenericHelpers.searchElement(driver, hp.operatorPage, hp.OperatorElement + "i");
                driver.SwitchTo().ActiveElement();

            }
            catch (Exception ex) { throw; }
        
   
        }
        [Test, Order(4),Category("Search R operators")]
        public void SearchWithIndexOperator_R()
        {

            GenericHelpers.CurrentTestName();
            try
            {
                GenericHelpers.findallelements(driver, hp.operators);
                GenericHelpers.searchElement(driver, hp.operatorPage, hp.OperatorElement+"r");
                driver.SwitchTo().ActiveElement();

            }
            catch (Exception ex) { throw; }

        }
        [Test, Order(7), Category("Search A operators")]
        public void SearchWithIndexOperator_A()
        {
            GenericHelpers.CurrentTestName();

            try
            {
                GenericHelpers.findallelements(driver, hp.operators);
                GenericHelpers.searchElement(driver, hp.operatorPage, hp.OperatorElement + "a");
                driver.SwitchTo().ActiveElement();

            }
            catch (Exception ex) { throw; }

        }
        [Test, Order(2), Category("Get pagination for I operator")]
        public void pagination_I()
        {
            GenericHelpers.CurrentTestName();
            try
            {
                GenericHelpers.searchPages(driver, hp.I_operator_pages,"3");
            }
            catch (Exception ex) { throw; }
        }

        [Test,Order(3), Category("Print all bus operators for I operator")]
        public void PrintAllRecordsforPage_I()
        {
            GenericHelpers.CurrentTestName();
            try
            {
                GenericHelpers.readallelements(driver, hp.I_operator,"I");
            }
            catch (Exception ex) { throw; }

        }
        [Test, Order(5), Category("Get pagination for R operator")]
        public void pagination_R()
        {
            GenericHelpers.CurrentTestName();
            try
            {
                GenericHelpers.searchPages(driver, hp.R_operator_pages, "3");
            }
            catch (Exception ex) { throw; }
        }
        [Test, Order(6), Category("Print all bus operators for R operator")]
        public void PrintAllRecordsforPage_R()
        {
            GenericHelpers.CurrentTestName();
            try
            {
                GenericHelpers.readallelements(driver, hp.R_operator,"R");
            }
            catch (Exception ex) { throw; }

        }
        [Test, Order(7), Category("Get pagination for A operator")]
        public void pagination_A()
        {
            GenericHelpers.CurrentTestName();
            try
            {
                GenericHelpers.searchPages(driver, hp.A_operator_pages, "3");
            }
            catch (Exception ex) { throw; }
        }
        [Test, Order(8), Category("Print all bus operators for A operator")]
        public void PrintAllRecordsforPage_A()
        {
            GenericHelpers.CurrentTestName();
            try
            {
                GenericHelpers.readallelements(driver, hp.A_operator,"A");
            }
            catch (Exception ex) { throw; }

        }
        //{
        //    Assert.Pass();
        //}

        [OneTimeTearDown]
        public void oneTimeTeardown()
        {
            GenericHelpers.CurrentTestName();
            driver.Quit();
        }
    }
}