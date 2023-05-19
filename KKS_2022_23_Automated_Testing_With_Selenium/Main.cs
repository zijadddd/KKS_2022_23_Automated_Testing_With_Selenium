namespace KKS_2022_23_Automated_Testing_With_Selenium {
    public class Tests {
        public class AuthenticationTests {
            private readonly IWebDriver webDriver;
            private readonly String webPage = "https://youtube.com/";

            public AuthenticationTests() {
                ChromeOptions options = new ChromeOptions();
                options.AddUserProfilePreference("profile.default_content_setting_values.notifications", 2);

                new DriverManager().SetUpDriver(new ChromeConfig());
                webDriver = new ChromeDriver(options);
            }

            [SetUp]
            public void Setup() {
                webDriver.Url = webPage;
            }

            [TearDown]
            public void Teardown() {
                Thread.Sleep(15000);
                webDriver.Close();
                webDriver.Quit();
            }

            [Test]
            public void TestCase10() {
                // Wait until button is displayed, then click.
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.CssSelector(".yt-spec-button-shape-next.yt-spec-button-shape-next--outline.yt-spec-button-shape-next--call-to-action.yt-spec-button-shape-next--size-m.yt-spec-button-shape-next--icon-leading")).Displayed);
                webDriver.FindElement(By.CssSelector(".yt-spec-button-shape-next.yt-spec-button-shape-next--outline.yt-spec-button-shape-next--call-to-action.yt-spec-button-shape-next--size-m.yt-spec-button-shape-next--icon-leading")).Click();

                // Wait until input is displayed, then fill.
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.Name("identifier")).Displayed);
                webDriver.FindElement(By.Name("identifier")).SendKeys("nekiakount1@gmail.com");

                // Wait until button is displayed, then click.
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.CssSelector(".VfPpkd-LgbsSe.VfPpkd-LgbsSe-OWXEXe-k8QpJ.VfPpkd-LgbsSe-OWXEXe-dgl2Hf.nCP5yc.AjY5Oe.DuMIQc.LQeN7.qIypjc.TrZEUc.lw1w4b")).Displayed);
                webDriver.FindElement(By.CssSelector(".VfPpkd-LgbsSe.VfPpkd-LgbsSe-OWXEXe-k8QpJ.VfPpkd-LgbsSe-OWXEXe-dgl2Hf.nCP5yc.AjY5Oe.DuMIQc.LQeN7.qIypjc.TrZEUc.lw1w4b")).Click();

                // Wait until input is displayed, then fill.
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.Name("Passwd")).Displayed);
                webDriver.FindElement(By.Name("Passwd")).SendKeys("kkstestaplikacije");

                // Wait until button is displayed, then click.
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.CssSelector(".VfPpkd-LgbsSe.VfPpkd-LgbsSe-OWXEXe-k8QpJ.VfPpkd-LgbsSe-OWXEXe-dgl2Hf.nCP5yc.AjY5Oe.DuMIQc.LQeN7.qIypjc.TrZEUc.lw1w4b")).Displayed);
                webDriver.FindElement(By.CssSelector(".VfPpkd-LgbsSe.VfPpkd-LgbsSe-OWXEXe-k8QpJ.VfPpkd-LgbsSe-OWXEXe-dgl2Hf.nCP5yc.AjY5Oe.DuMIQc.LQeN7.qIypjc.TrZEUc.lw1w4b")).Click();

                // Wait until button is displayed, then click.
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.Id("avatar-btn")).Displayed);
                Assert.That(StaticMethods.CheckIfElementExists(webDriver, "avatar-btn"), Is.True);
            }
        }
    }
}