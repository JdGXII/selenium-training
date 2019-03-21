using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace ExtensionMethodTest
{
    class Program
    {
        static void Main(string[] args)
        {
            RegularWay();
            GetElementByLinkText();
            GetAllLinks();
        }

        public static void RegularWay()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.belatrixsf.com/");
            IWebElement webElement = driver.FindElement(By.ClassName("text-container-video"));

            Console.Write($"Regular way: {webElement.Text}");           
        }

        public static void GetElementByLinkText()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.belatrixsf.com/");
            IWebElement link = driver.FindElementByLinkText("SERVICES");
            link.Click();            

            Console.Write($"Link text: {link.Text}");
        }

        public static void GetAllLinks()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.belatrixsf.com/");
            IReadOnlyCollection<IWebElement> anchors = driver.FindElementsByTagName("a");

            foreach(IWebElement element in anchors)
            {
                Console.WriteLine($"Texto del link: {element.Text}");
            }
        }

        public static void FillAndSubmitAForm()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://regularcoder.com/demo/selenium-ide-test/");
            IWebElement movieTitleTextBox = driver.FindElementById("title");
            movieTitleTextBox.SendKeys("VICE");
            IWebElement movieCreatedAtTextBox = driver.FindElementById("year");
            movieCreatedAtTextBox.SendKeys("2018");
            IWebElement movieDirectorTextBox = driver.FindElementById("director");
            movieDirectorTextBox.SendKeys("Tarantonto");           
            IWebElement movieDescriptionTextBox = driver.FindElementById("description");
            movieDescriptionTextBox.SendKeys("Great movie");

            IWebElement submitButton = driver.FindElementByTagName("button");
            submitButton.Click();
        }
    }
}
