using OpenQA.Selenium;

namespace KKS_2022_23_Automated_Testing_With_Selenium.Helpers {
    static class StaticMethods {

        public static bool CheckIfElementExistsById(IWebDriver webDriver, string elementId) {
            try {
                webDriver.FindElement(By.Id(elementId));
                return true;
            } catch (NoSuchElementException) {
                return false;
            }
        }

        public static bool CheckIfElementExistsByClassName(IWebDriver webDriver, string elementClassName) {
            try {
                webDriver.FindElement(By.ClassName(elementClassName));
                return true;
            } catch (NoSuchElementException) {
                return false;
            }
        }

        public static bool CheckIfElementExistsByRoleAlert(IWebDriver webDriver) {
            try {
                webDriver.FindElement(By.CssSelector("[role='alert']"));
                return true;
            } catch (NoSuchElementException) {
                return false;
            }
        }

        public static bool CheckIfElementExistsByLinkText(IWebDriver webDriver, string elementText) {
            try {
                webDriver.FindElement(By.LinkText(elementText));
                return true;
            } catch (NoSuchElementException) {
                return false;
            }
        }

        public static void Login(IWebDriver webDriver, string email, string password) {
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.CssSelector(".authorization-link")).Displayed);
            webDriver.FindElement(By.CssSelector(".authorization-link")).Click();

            new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.Id("email")).Displayed);
            webDriver.FindElement(By.Id("email")).SendKeys(email);

            new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.Id("pass")).Displayed);
            webDriver.FindElement(By.Id("pass")).SendKeys(password);

            new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.Id("send2")).Displayed);
            webDriver.FindElement(By.Id("send2")).Click();
        }
    }
}
