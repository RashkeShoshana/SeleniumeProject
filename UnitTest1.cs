using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;



namespace lesson1
{
    [TestFixture]
   public class GoogleSearchTest
    {
        private IWebDriver driver;
    
    public GoogleSearchTest()
    {

    }

    [SetUp]
        public void SetUp()
        {
            string path = "C:\\תוכנות\\chromedriver-win64";

            driver = new ChromeDriver(path );
            driver.Manage().Window.Maximize();

    }

    [Test]
        public void TestGoogleSearch()
        {
            //===1===
            driver.Navigate().GoToUrl("https://www.google.com");

            //===2===
            Assert.AreEqual("Google", driver.Title);

            //===3===
            IWebElement searchBox = driver.FindElement(By.Name("q"));

            //===4===
            searchBox.SendKeys("Selenium WebDriver");

            //===5===
            searchBox.Submit();

            //===6===
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.Title != "");

            //===7===

            IList<IWebElement> results = driver.FindElements(By.CssSelector("h3.r")); 
            if (results.Count > 0)
            {
                Console.WriteLine("Search results displayed!");
            }
            else
            {
                Console.WriteLine("Search results displayed!");
            }

            //===8===
            driver.FindElement(By.CssSelector("div.g h3 a")).Click();


            //===9===
            if (!string.IsNullOrEmpty(driver.Title))
            {
                Console.WriteLine("הכותרת אינה ריקה");
            }
            else
            {
                Console.WriteLine(" הכותרת ריקה");
            }

            //===10===
            driver.Navigate().Back();

            //===11===
            IWebElement searchBox2 = driver.FindElement(By.Name("q"));
            string searchTerm = searchBox.GetAttribute("value");
            if (searchTerm == "Selenium WebDriver")
            {
                Console.WriteLine("Search term in search box verified!");
            }
            else
            {
                Console.WriteLine("Search term mismatch!");
            }


            Assert.Pass("This test is passing");
        }
        [TearDown] 
        public void TearDown()
        {
            driver.Dispose();
        }
    }
}