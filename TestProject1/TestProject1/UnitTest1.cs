using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace TestProject1
{
    public class Tests
    {
        private IWebDriver driver;
        private readonly By singInButton = By.XPath("//span[text()='Войти']");
        private readonly By signButton1 = By.XPath("//span[text()='Другим способом']");
        private readonly By UserNameTBPath = By.XPath("//input[@name='username']");
        private readonly By signButton2 = By.XPath("//span[text()='Продолжить']");
        private readonly By signButton3 = By.XPath("//span[contains(@class, '_25d45facb5--box--FHmxp _25d45facb5--box--LJe53')]");
        private readonly By signButton4 = By.XPath("//span[text()='Продолжить']");
        private readonly By signButton5 = By.XPath("//input[@name='password']");
        private readonly By signButton6 = By.XPath("//span[text()='Зарегистрироваться']");
        private readonly By signButton7 = By.XPath("//span[text()='Хорошо']");

        private readonly By signButton8 = By.XPath("//button[@data-mark='ContinueAuthBtn']");
        private const string ExpectedId = "ID 87123169";
        private readonly By IDXPath = By.XPath("//a[@class='_25d45facb5--full-name--K5jY5']");
        private readonly By IDXXPath = By.XPath("//img[@class='_25d45facb5--avatar--sVaKv']");

        [SetUp]
        public void Setup()
        {
            var options = new ChromeOptions().BinaryLocation = @"C:\";
            driver = new ChromeDriver(options);

            driver.Navigate().GoToUrl("https://cian.ru");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(20);
            string login = "vakulskaya15@mail.ru";
            string password = "Elena1103";
            var singIn = driver.FindElement(singInButton);
            singIn.Click();

            var singIn1 = driver.FindElement(signButton1);
            singIn1.Click();
            var usernameTB = driver.FindElement(UserNameTBPath);
            usernameTB.SendKeys(login);
            var singIn2 = driver.FindElement(signButton2);
            singIn2.Click();
            var singIn3 = driver.FindElement(signButton3);
            singIn3.Click();
            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(10);
            var singIn4 = driver.FindElement(signButton4);
            singIn4.Click();
            var passwordTB = driver.FindElement(signButton5);
            passwordTB.SendKeys(password);
            var signIn6 = driver.FindElement(signButton6);
            signIn6.Click();
            var signIn7 = driver.FindElement(signButton7);
            signIn7.Click();
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(20);
            string login = "zubkoandrew983@gmail.com";
            string password = "Elena1103";
            var singIn = driver.FindElement(singInButton);
            singIn.Click();

            var singIn1 = driver.FindElement(signButton1);
            singIn1.Click();
            var usernameTB = driver.FindElement(UserNameTBPath);
            usernameTB.SendKeys(login);
            var singIn2 = driver.FindElement(signButton2);
            singIn2.Click();
            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(10);
            var passwordTB = driver.FindElement(signButton5);
            passwordTB.SendKeys(password);
            var singIn8 = driver.FindElement(signButton8);
            singIn8.Click();
            Thread.Sleep(5000);
            var singIn9 = driver.FindElement(IDXXPath);
            singIn9.Click();
            var ActualID = driver.FindElement(IDXPath).Text;
            Assert.AreEqual(ExpectedId, ActualID, "ID НЕ СОВПАЛИ");
        }
    }
}