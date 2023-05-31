namespace KKS_2022_23_Automated_Testing_With_Selenium {
    public class Registration {
        private readonly IWebDriver webDriver;
        private readonly String url = "https://magento.softwaretestingboard.com/";

        public Registration() {
            ChromeOptions options = new ChromeOptions();
            options.AddUserProfilePreference("profile.default_content_setting_values.notifications", 2);

            new DriverManager().SetUpDriver(new ChromeConfig());
            webDriver = new ChromeDriver(options);
        }

        [SetUp]
        public void Setup() {
            webDriver.Url = url;
            webDriver.Manage().Window.Maximize();
        }

        [TearDown]
        public void Teardown() {
            Thread.Sleep(5000);
            webDriver.Close();
            webDriver.Quit();
        }

        [Test]
        public void TestCase1() {
            using (HttpClient client = new HttpClient()) {
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.LinkText("Create an Account")).Displayed);
                webDriver.FindElement(By.LinkText("Create an Account")).Click();

                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.Id("firstname")).Displayed);
                webDriver.FindElement(By.Id("firstname")).SendKeys("John");

                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.Id("lastname")).Displayed);
                webDriver.FindElement(By.Id("lastname")).SendKeys("Smith");

                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.Id("is_subscribed")).Displayed);
                webDriver.FindElement(By.Id("is_subscribed")).Click();

                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.Id("email_address")).Displayed);
                webDriver.FindElement(By.Id("email_address")).SendKeys("nekiakount1@gmail.com");

                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.Id("password")).Displayed);
                webDriver.FindElement(By.Id("password")).SendKeys("KKStestaplikacije123");

                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.CssSelector("#password-confirmation")).Displayed);
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.CssSelector("#password-confirmation")).Enabled);
                webDriver.FindElement(By.CssSelector("#password-confirmation")).SendKeys("KKStestaplikacije123");

                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.CssSelector("[title='Create an Account']")).Displayed);
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.CssSelector("[title='Create an Account']")).Enabled);
                webDriver.FindElement(By.CssSelector("[title='Create an Account']")).Click();
            }
        }
    }
}
