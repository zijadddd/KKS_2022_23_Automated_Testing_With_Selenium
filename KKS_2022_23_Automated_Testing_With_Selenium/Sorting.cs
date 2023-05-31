namespace KKS_2022_23_Automated_Testing_With_Selenium {
    public class Sorting {
        private readonly IWebDriver webDriver;
        private readonly String url = "https://magento.softwaretestingboard.com/";

        public Sorting() {
            ChromeOptions options = new ChromeOptions();
            options.AddUserProfilePreference("profile.default_content_setting_values.notifications", 2);

            new DriverManager().SetUpDriver(new ChromeConfig());
            webDriver = new ChromeDriver(options);
        }

        [SetUp]
        public void Setup() {
            webDriver.Url = url;
            webDriver.Manage().Window.Maximize();
            StaticMethods.Login(webDriver, "nekiakount1@gmail.com", "KKStestaplikacije123");
        }

        [TearDown]
        public void Teardown() {
            Thread.Sleep(15000);
            webDriver.Close();
            webDriver.Quit();
        }

        [Test]
        public void TestCase8() {
            using (HttpClient client = new HttpClient()) {
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.Id("ui-id-3")).Displayed);
                webDriver.FindElement(By.Id("ui-id-3")).Click();

                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.LinkText("Hoodies & Sweatshirts")).Displayed);
                IReadOnlyCollection<IWebElement> hoodie = webDriver.FindElements(By.LinkText("Hoodies & Sweatshirts"));

                if (hoodie.Count >= 2) hoodie.ElementAt(1).Click();

                new SelectElement(webDriver.FindElement(By.Id("sorter"))).SelectByValue("name");

                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.CssSelector("[title='Set Descending Direction']")).Displayed);
                webDriver.FindElement(By.CssSelector("[title='Set Descending Direction']")).Click();
                Assert.That(webDriver.FindElements(By.CssSelector(".products.list.items.product-items")).ElementAt(0).FindElement(By.ClassName("product-item-link")).Text, Is.EqualTo("Teton Pullover Hoodie"));
            }
        }
    }
}
