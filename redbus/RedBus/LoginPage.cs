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
            BrowserHelpers bp = new BrowserHelpers();

            driver = bp.ChromeInitialize(driver, "https://www.redbus.in/");
        }

        [Test,Order(0)]
        public void SearchOperator()
        {
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

        [Test,Order(1)]
        public void SearchWithIndexOperator_I()
        {
            
            try
            {
                GenericHelpers.findallelements(driver, hp.operators);
                GenericHelpers.searchElement(driver, hp.operatorPage, hp.OperatorElement + "i");
                driver.SwitchTo().ActiveElement();

            }
            catch (Exception ex) { throw; }
        
   
        }
        [Test, Order(4)]
        public void SearchWithIndexOperator_R()
        {

            try
            {
                GenericHelpers.findallelements(driver, hp.operators);
                GenericHelpers.searchElement(driver, hp.operatorPage, hp.OperatorElement+"r");
                driver.SwitchTo().ActiveElement();

            }
            catch (Exception ex) { throw; }

        }
        [Test, Order(7)]
        public void SearchWithIndexOperator_A()
        {
            
            try
            {
                GenericHelpers.findallelements(driver, hp.operators);
                GenericHelpers.searchElement(driver, hp.operatorPage, hp.OperatorElement + "a");
                driver.SwitchTo().ActiveElement();

            }
            catch (Exception ex) { throw; }

        }
        [Test, Order(2)]
        public void pagination_I()
        {
            try
            {
                GenericHelpers.searchPages(driver, hp.I_operator_pages,"3");
            }
            catch (Exception ex) { throw; }
        }

        [Test,Order(3)]
        public void PrintAllRecordsforPage_I()
        {
            try
            {
                GenericHelpers.readallelements(driver, hp.I_operator,"I");
            }
            catch (Exception ex) { throw; }

        }
        [Test, Order(5)]
        public void pagination_R()
        {
            try
            {
                GenericHelpers.searchPages(driver, hp.R_operator_pages, "3");
            }
            catch (Exception ex) { throw; }
        }
        [Test, Order(6)]
        public void PrintAllRecordsforPage_R()
        {
            try
            {
                GenericHelpers.readallelements(driver, hp.R_operator,"R");
            }
            catch (Exception ex) { throw; }

        }
        [Test, Order(7)]
        public void pagination_A()
        {
            try
            {
                GenericHelpers.searchPages(driver, hp.A_operator_pages, "3");
            }
            catch (Exception ex) { throw; }
        }
        [Test, Order(8)]
        public void PrintAllRecordsforPage_A()
        {
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
            driver.Quit();
        }
    }
}