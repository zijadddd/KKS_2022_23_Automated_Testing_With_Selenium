using com.sun.tools.javac.jvm;

namespace KKS_2022_23_Automated_Testing_With_Selenium {
    public class WishList {
        private readonly IWebDriver webDriver;
        private readonly String url = "https://magento.softwaretestingboard.com/";

        public WishList() {
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
        public void TestCase6() {
            using (HttpClient client = new HttpClient()) {
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.Id("ui-id-3")).Displayed);
                webDriver.FindElement(By.Id("ui-id-3")).Click();

                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.LinkText("Shorts")).Displayed);
                IReadOnlyCollection<IWebElement> shorts = webDriver.FindElements(By.LinkText("Shorts"));

                if (shorts.Count >= 2) shorts.ElementAt(1).Click();

                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.LinkText("Hawkeye Yoga Short")).Displayed);
                webDriver.FindElement(By.LinkText("Hawkeye Yoga Short")).Click();

                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.XPath("//span[contains(text(), 'Add to Wish List')]")).Displayed);
                webDriver.FindElement(By.XPath("//span[contains(text(), 'Add to Wish List')]")).Click();

                Assert.That(StaticMethods.CheckIfElementExistsByRoleAlert(webDriver), Is.True);
            }
        }

        [Test]
        public void TestCase7() {
            using (HttpClient client = new HttpClient()) {
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.ClassName("customer-name")).Displayed);
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.ClassName("customer-name")).Enabled);
                webDriver.FindElement(By.ClassName("customer-name")).Click();

                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.LinkText("My Account")).Displayed);
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.LinkText("My Account")).Enabled);
                webDriver.FindElement(By.LinkText("My Account")).Click();

                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.LinkText("My Wish List")).Displayed);
                webDriver.FindElement(By.LinkText("My Wish List")).Click();

                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.CssSelector(".product-item-info")).Displayed);
                new Actions(webDriver).MoveToElement(webDriver.FindElement(By.CssSelector(".product-item-info"))).Perform();
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.CssSelector("[title='Remove Item']")).Displayed);
                webDriver.FindElement(By.CssSelector("[title='Remove Item']")).Click();
                Assert.That(StaticMethods.CheckIfElementExistsByRoleAlert(webDriver), Is.True);
            }
        }
    }
}
