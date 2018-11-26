using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace Selenium_Webdriver.UnitTestCases
    
{
    class tc1_unit
    {
        IWebDriver driver = new ChromeDriver();
        [SetUp]
        public void start()
        {
            driver.Url = ("https://app.studiesweekly.com/online/");
        }

        [Test]
        public void test()
        {
            int title_length = driver.Title.Length;
            string a = title_length.ToString();
            System.Diagnostics.Debug.Write("Length of the title : {0}", a);
            string page_source = driver.PageSource;
            System.Diagnostics.Debug.Write("Length of the title : {0}", page_source);
            int pg_length = driver.PageSource.Length;
            string b = title_length.ToString();
            System.Diagnostics.Debug.Write("Length of the title : {0}", b);
            string url_page = driver.Url;
            System.Diagnostics.Debug.Write("Url is: {0}", url_page);
            int URL_length = driver.Url.Length;
            string c = title_length.ToString();
            System.Diagnostics.Debug.Write("Length of the title : {0}", c);
        }

        [TearDown]
        public void end()
        {
            driver.Close();
    
        }






    }
}
