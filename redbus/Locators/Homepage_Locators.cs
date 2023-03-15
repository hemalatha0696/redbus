using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redbus.Locators
{
    public class Homepage_Locators
    {
        public string homeoperator = "(//a[normalize-space()='All Operators >'])[1]";
        // public string[] operators = { "//ul[@class='D112_ul']//li" };

        public String OperatorElement = "https://www.redbus.in/travels/operators-directory/";

        public String[] operators = { "//ul[@class='D112_ul']//li" };

        public String operatorPage = "//ul[@class='D112_ul']//li//a";

        public String I_operator = "//li[@class='D113_item']";

        public String I_operator_pages = "//div[@class='D113_pagination']//a";

        public String R_operator_pages = "//div[@class='D113_pagination']//a";

        public String R_operator = "(//li[@class='D113_item'])";

        public String A_operator_pages = "//div[@class='D113_pagination']//a";

        public String A_operator = "(//li[@class='D113_item'])";

    }
}
