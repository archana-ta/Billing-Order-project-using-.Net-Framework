using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace BillingIo
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "http://qaauto.co.nz/billing-order-form/";
            
        }
        [Test]

        public void Billing()
        {
            Start();
            Form();
        }
        public void Start()
        {
            IWebElement passwd = driver.FindElement(By.CssSelector("#wpforms-locked-24-field_form_locker_password"));
            passwd.SendKeys("Testing");
            IWebElement sub = driver.FindElement(By.XPath("//div/button[@name]"));
            sub.Click();
            Form();
        }

            public void Form()
            {

                IWebElement name = driver.FindElement(By.CssSelector("#wpforms-24-field_0"));
                name.SendKeys("tom");
                IWebElement lastname = driver.FindElement(By.CssSelector("#wpforms-24-field_0-last"));
                lastname.SendKeys("luke");
                IWebElement email = driver.FindElement(By.CssSelector("#wpforms-24-field_1"));
                email.SendKeys("tom.luke@gmail.com");
                IWebElement phone = driver.FindElement(By.CssSelector("#wpforms-24-field_1"));
                phone.SendKeys("0212045453");
                IWebElement add = driver.FindElement(By.CssSelector("#wpforms-24-field_3"));
                add.SendKeys("adelaid street");
                IWebElement addline1 = driver.FindElement(By.CssSelector("#wpforms-24-field_3-address2"));
                addline1.SendKeys("jersey2323");
                IWebElement addline2 = driver.FindElement(By.CssSelector("#wpforms-24-field_3-city"));
                addline2.SendKeys("jersey");

                SelectElement select = new SelectElement(driver.FindElement(By.CssSelector("#wpforms-24-field_3-state")));
                select.SelectByIndex(4);

                IWebElement city = driver.FindElement(By.CssSelector("#wpforms-24-field_3-postal"));
                city.SendKeys("60606");

                IWebElement radiobtn = driver.FindElement(By.CssSelector("#wpforms-24-field_4_2"));
                radiobtn.Click();

                IWebElement msg = driver.FindElement(By.CssSelector("#wpforms-24-field_6"));
                msg.SendKeys("Good and Thanks");

                IWebElement submit2 = driver.FindElement(By.CssSelector("#wpforms-submit-24"));
                submit2.Click();
            }
        
        [TearDown]
        public void Close()
        {

            driver.Close();
        }















        
    }
}