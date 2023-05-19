using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKS_2022_23_Automated_Testing_With_Selenium.Helpers {
    static class StaticMethods {
        public static bool CheckIfElementExists(IWebDriver webDriver, string elementId) {
            try {
                webDriver.FindElement(By.Id(elementId));
                return true;
            } catch (NoSuchElementException) {
                return false;
            }
        }
    }
}
