namespace KKS_2022_23_Automated_Testing_With_Selenium {
    public class Tests {
        public class Authentication {
            private readonly IWebDriver webDriver;
            private readonly String url = "https://magento.softwaretestingboard.com/";

            public Authentication() {
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
            public void TestCase2() {
                using (HttpClient client = new HttpClient()) {
                    StaticMethods.Login(webDriver, "izmisljeniakount1@outlook.com", "KKStestaplikacije123");
                    Thread.Sleep(5000);
                    Assert.That(StaticMethods.CheckIfElementExistsByRoleAlert(webDriver), Is.True);
                }
            }

            [Test]
            public void TestCase3() {
                using (HttpClient client = new HttpClient()) {
                    StaticMethods.Login(webDriver, "nekiakount1@gmail.com", "KKStestaplikacije1234");
                    Thread.Sleep(5000);
                    Assert.That(StaticMethods.CheckIfElementExistsByRoleAlert(webDriver), Is.True);
                }
            }

            [Test]
            public void TestCase4() {
                using (HttpClient client = new HttpClient()) {
                    StaticMethods.Login(webDriver, "izmisljeniakount1@outlook.com", "KKStestaplikacije1234");
                    Thread.Sleep(5000);
                    Assert.That(StaticMethods.CheckIfElementExistsByRoleAlert(webDriver), Is.True);
                }
            }

            [Test]
            public void TestCase5() {
                using (HttpClient client = new HttpClient()) {
                    StaticMethods.Login(webDriver, "nekiakount1@gmail.com", "KKStestaplikacije123");
                    Thread.Sleep(5000);
                    Assert.That(StaticMethods.CheckIfElementExistsByClassName(webDriver, "logged-in"), Is.True);
                }
            }
        }
    }
}