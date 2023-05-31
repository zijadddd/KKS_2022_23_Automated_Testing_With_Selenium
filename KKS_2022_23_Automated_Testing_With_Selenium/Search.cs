namespace KKS_2022_23_Automated_Testing_With_Selenium {
    public class Search {
        private readonly IWebDriver webDriver;
        private readonly String url = "https://magento.softwaretestingboard.com/";

        public Search() {
            ChromeOptions options = new ChromeOptions();
            options.AddUserProfilePreference("profile.default_content_setting_values.notifications", 2);

            new DriverManager().SetUpDriver(new ChromeConfig());
            webDriver = new ChromeDriver(options);
        }

        [OneTimeSetUp]
        public void Setup() {
            webDriver.Url = url;
            webDriver.Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        public void Teardown() {
            Thread.Sleep(5000);
            webDriver.Close();
            webDriver.Quit();
        }

        [Test]
        public void TestCase12() {
            using (HttpClient client = new HttpClient()) {
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.Id("search")).Displayed);
                webDriver.FindElement(By.Id("search")).SendKeys("laptop");
                webDriver.FindElement(By.Id("search")).SendKeys(Keys.Enter);
                Thread.Sleep(5000);
                Assert.That(StaticMethods.CheckIfElementExistsByClassName(webDriver, "toolbar-amount"), Is.True);
            }
        }

        [Test]
        public void TestCase13() {
            using (HttpClient client = new HttpClient()) {
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.Id("ui-id-5")).Displayed);
                IWebElement men = webDriver.FindElement(By.Id("ui-id-5"));
                Actions hover = new Actions(webDriver);
                hover.MoveToElement(men).Perform();

                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.Id("ui-id-18")).Displayed);
                IWebElement bottoms = webDriver.FindElement(By.Id("ui-id-18"));
                Actions hover2 = new Actions(webDriver);
                hover2.MoveToElement(bottoms).Perform();

                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.LinkText("Shorts")).Displayed);
                webDriver.FindElement(By.LinkText("Shorts")).Click();

                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.ClassName("base")).Displayed);
                IWebElement provjera = webDriver.FindElement(By.ClassName("base"));

                Assert.That(provjera.Text, Is.EqualTo("Shorts"));
            }
        }

    }
}
