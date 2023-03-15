using OpenQA.Selenium;
using redbus.Locators;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using redbus.Helpers;

namespace redbus.RedBus
{
    public class Operator:DriverHelper
    {

        Homepage_Locators hp = new Homepage_Locators();
        [Test]
        public void searchoperators()
        {
            try
            {
                //for (int i = 1; i < 6; i++)
                //{
                //    var e = driver.FindElement(By.XPath("(//div[@class='card mt-4 top-card'])[" + i + "]"));
                //    JSExecutorHelper.jsjs(driver, e);
                //    GenericHelpers.Clickelement(driver, "(//div[@class='card mt-4 top-card'])[" + i + "]");
                //}
                GenericHelpers.findallelements(driver, hp.operators);
            }
            catch(Exception ex) { throw; }
            
            }
            }
}
