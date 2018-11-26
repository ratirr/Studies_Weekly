using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_Webdriver.TestCases
{
    class TC1
    {
        public static void Main(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = ("https://app.studiesweekly.com/online/");
            string Title_Page = driver.Title;
            Console.WriteLine("Title of the page is {0}", Title_Page);
            int title_length = driver.Title.Length;
            Console.WriteLine("Length of the title : {0}",title_length);
            string page_source = driver.PageSource;
            Console.WriteLine("Length of the title : {0}", page_source);
            int pg_length = driver.PageSource.Length;
            Console.WriteLine("Length of the title : {0}", pg_length);
            string url_page = driver.Url;
            Console.WriteLine("Url is: {0}", url_page);
            int URL_length = driver.Url.Length;
            Console.WriteLine("Length of the title : {0}", URL_length);
            driver.Close();






        }
    }
}
