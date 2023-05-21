namespace KKS_2022_23_Automated_Testing_With_Selenium {
    public class Tests {
        public class AuthenticationTests {
            private readonly IWebDriver webDriver;
            private readonly String url = "https://magento.softwaretestingboard.com/";

            public AuthenticationTests() {
                ChromeOptions options = new ChromeOptions();
                options.AddUserProfilePreference("profile.default_content_setting_values.notifications", 2);

                new DriverManager().SetUpDriver(new ChromeConfig());
                webDriver = new ChromeDriver(options);
            }

            [SetUp]
            public void Setup() {
                webDriver.Url = url;
            }

            [TearDown]
            public void Teardown() {
                Thread.Sleep(5000);
                webDriver.Close();
                webDriver.Quit();
            }
        }
    }
}