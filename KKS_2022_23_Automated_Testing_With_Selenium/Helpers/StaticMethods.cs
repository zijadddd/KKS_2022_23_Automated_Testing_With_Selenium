namespace KKS_2022_23_Automated_Testing_With_Selenium.Helpers {
    static class StaticMethods {

        public static bool CheckIfElementExistsByLinkText(IWebDriver webDriver, string text) {
            try {
                webDriver.FindElement(By.LinkText(text));
                return true;
            } catch (NoSuchElementException) {
                return false;
            }
        }

        public static bool CheckIfElementExistsById(IWebDriver webDriver, string elementId) {
            try {
                webDriver.FindElement(By.Id(elementId));
                return true;
            } catch (NoSuchElementException) {
                return false;
            }
        }

        public static void Login() {

        }
    }
}
