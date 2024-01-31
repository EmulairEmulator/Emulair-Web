using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace TestEmulair
{
    public class FrontendTest
    {
        public IWebDriver Driver;

        [SetUp]

        public void Setup()
        {
            Console.WriteLine("Setup");
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AcceptInsecureCertificates = true;
            var chromeDriverPath = @"D:\FMI\Ingineria Software\Emulair-Web\TestEmulair\chromedriver.exe"; 
            Driver = new ChromeDriver(chromeDriverPath, chromeOptions);
        }

        [Test]

        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://localhost:7289/");
            Console.WriteLine("Test1");
            NUnit.Framework.Assert.Pass();
        }
    }
}
