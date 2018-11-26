using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Selenium_Webdriver.TestCases
{
    class TC1
    {
        public static void Main(String[] args)
        {
            //IWebDriver driver = new ChromeDriver();
            //driver.Url = ("https://app.studiesweekly.com/online/");
            //string Title_Page = driver.Title;
            //Console.WriteLine("Title of the page is {0}", Title_Page);
            //int title_length = driver.Title.Length;
            //Console.WriteLine("Length of the title : {0}",title_length);
            //string page_source = driver.PageSource;
            //Console.WriteLine("Length of the title : {0}", page_source);
            //int pg_length = driver.PageSource.Length;
            //Console.WriteLine("Length of the title : {0}", pg_length);
            //string url_page = driver.Url;
            //Console.WriteLine("Url is: {0}", url_page);
            //int URL_length = driver.Url.Length;
            //Console.WriteLine("Length of the title : {0}", URL_length);


            //TC2

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://app.studiesweekly.com/online/";

            // Store the parent window into a variable for further use 
            String parentWindowHandle = driver.CurrentWindowHandle;
            Console.WriteLine("Parent window's handle -> " + parentWindowHandle);

            IWebElement clickElement = driver.FindElement(By.Id("cleverLogin"));
            //I am using 'for' loop to get multiple windows by clicking the element
            for (var i = 0; i < 1; i++)
            {
                clickElement.Click();

            }

            /*
            * driver.WindowHandles is a ReadOnlycollection So i am using '.ToList()' and store into the 'List<string>'
            * Again using 'for loop' to traverse all window which are opened by the above loop 
            * then i use '.SwitchTo().Window'. Basically this is use to switch your control from parent window to current window
            **/

            List<string> lstWindow = driver.WindowHandles.ToList();
            String lastWindowHandle = "";
            foreach (var handle in lstWindow)
            {
                Console.WriteLine("Switching to window - > " + handle);
                Console.WriteLine("Navigating to google.com");

                //Switch to the desired window first and then execute commands using driver
                driver.SwitchTo().Window(handle);

                driver.Navigate().GoToUrl("https://clever.com/oauth/district-picker?response_type=code&redirect_uri=https%3A%2F%2Fapp.studiesweekly.com%2Fonline%2Fclever&client_id=907888321594e36e4579");
                lastWindowHandle = handle;
            }

            //Switch to the parent window
            driver.SwitchTo().Window(parentWindowHandle);

            //close the parent window
            driver.Close();

            //at this point there is no focused window, we have to explicitly switch back to some window.
            driver.SwitchTo().Window(lastWindowHandle);

            driver.Url = "https://app.studiesweekly.com/online/";






        }
    }
}
