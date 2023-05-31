namespace KKS_2022_23_Automated_Testing_With_Selenium {
    public class ChangeInfo {
        private readonly IWebDriver webDriver;
        private readonly String url = "https://magento.softwaretestingboard.com/";

        public ChangeInfo() {
            ChromeOptions options = new ChromeOptions();
            options.AddUserProfilePreference("profile.default_content_setting_values.notifications", 2);

            new DriverManager().SetUpDriver(new ChromeConfig());
            webDriver = new ChromeDriver(options);
        }

        [OneTimeSetUp]
        public void Setup() {
            webDriver.Url = url;
            webDriver.Manage().Window.Maximize();
            StaticMethods.Login(webDriver, "nekiakount1@gmail.com", "KKStestaplikacije123");
        }

        [OneTimeTearDown]
        public void Teardown() {
            Thread.Sleep(15000);
            webDriver.Close();
            webDriver.Quit();
        }

        [Test]
        public void TestCase10() {
            using (HttpClient client = new HttpClient()) {
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.ClassName("customer-name")).Displayed);
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.ClassName("customer-name")).Enabled);
                webDriver.FindElement(By.ClassName("customer-name")).Click();


                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.LinkText("My Account")).Displayed);
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.LinkText("My Account")).Enabled);
                webDriver.FindElement(By.LinkText("My Account")).Click();

                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.LinkText("Edit")).Displayed);
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.LinkText("Edit")).Enabled);
                webDriver.FindElement(By.LinkText("Edit")).Click();

                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.Id("firstname")).Displayed);
                webDriver.FindElement(By.Id("firstname")).Clear();

                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.Id("firstname")).Displayed);
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.Id("firstname")).Enabled);
                webDriver.FindElement(By.Id("firstname")).SendKeys("Zijad");

                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.CssSelector("[title='Save']")).Displayed);
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.CssSelector("[title='Save']")).Enabled);
                webDriver.FindElement(By.CssSelector("[title='Save']")).Click();

                Assert.That(StaticMethods.CheckIfElementExistsByClassName(webDriver, "messages"), Is.True);
            }
        }

        [Test]
        public void TestCase11() {
            using (HttpClient client = new HttpClient()) {
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.ClassName("customer-name")).Displayed);
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.ClassName("customer-name")).Enabled);
                webDriver.FindElement(By.ClassName("customer-name")).Click();


                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.LinkText("My Account")).Displayed);
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.LinkText("My Account")).Enabled);
                webDriver.FindElement(By.LinkText("My Account")).Click();

                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.LinkText("Change Password")).Displayed);
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.LinkText("Change Password")).Enabled);
                webDriver.FindElement(By.LinkText("Change Password")).Click();

                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.Id("current-password")).Displayed);
                webDriver.FindElement(By.Id("current-password")).SendKeys("KKStestaplikacije123");

                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.Id("password")).Displayed);
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.Id("password")).Enabled);
                webDriver.FindElement(By.Id("password")).SendKeys("KKStestaplikacije123");

                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.Id("password-confirmation")).Displayed);
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.Id("password-confirmation")).Enabled);
                webDriver.FindElement(By.Id("password-confirmation")).SendKeys("KKStestaplikacije123");

                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.CssSelector("[title='Save']")).Displayed);
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.CssSelector("[title='Save']")).Enabled);
                webDriver.FindElement(By.CssSelector("[title='Save']")).Click();

                Assert.That(StaticMethods.CheckIfElementExistsByClassName(webDriver, "messages"), Is.True);
            }
        }
    }
}
