namespace KKS_2022_23_Automated_Testing_With_Selenium {
    public class CartAddingItems {
        private readonly IWebDriver webDriver;
        private readonly String url = "https://magento.softwaretestingboard.com/";

        public CartAddingItems() {
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
            Thread.Sleep(35000);
            webDriver.Close();
            webDriver.Quit();
        }

        [Test]
        public void TestCase9() {
            using (HttpClient client = new HttpClient()) {
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.Id("ui-id-5")).Displayed);
                new Actions(webDriver).MoveToElement(webDriver.FindElement(By.Id("ui-id-5"))).Perform();
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.LinkText("Tops")).Displayed);
                webDriver.FindElement(By.LinkText("Tops")).Click();

                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.LinkText("Cassius Sparring Tank")).Displayed);
                webDriver.FindElement(By.LinkText("Cassius Sparring Tank")).Click();

                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.CssSelector("[role='listbox']")).Displayed);
                IReadOnlyCollection<IWebElement> childDiv = webDriver.FindElement(By.CssSelector("[role='listbox']")).FindElements(By.TagName("div"));
                childDiv.ElementAt(childDiv.Count - 1).Click();

                webDriver.FindElements(By.CssSelector("div[role='listbox']")).ElementAt(1).Click();
                IReadOnlyCollection<IWebElement> childDiv2 = webDriver.FindElements(By.CssSelector("div[role='listbox']")).ElementAt(1).FindElements(By.TagName("div"));
                childDiv2.ElementAt(childDiv2.Count - 1).Click();

                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.CssSelector("[title='Add to Cart']")).Displayed);
                webDriver.FindElement(By.CssSelector("[title='Add to Cart']")).Click();

                Assert.That(StaticMethods.CheckIfElementExistsByClassName(webDriver, "messages"), Is.True);
            }
        }
    }
}
