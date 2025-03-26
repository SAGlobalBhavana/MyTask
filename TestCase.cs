
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium;
using System.Data;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Support.UI;

namespace MSTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DemoTesting()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://www.amazon.in/ap/signin?openid.pape.max_auth_age=0&openid.return_to=https%3A%2F%2Fwww.amazon.in%2F%3F%26tag%3Dgooghydrabk1-21%26ref%3Dnav_signin%26adgrpid%3D155259813593%26hvpone%3D%26hvptwo%3D%26hvadid%3D674893540034%26hvpos%3D%26hvnetw%3Dg%26hvrand%3D12004303100118941920%26hvqmt%3De%26hvdev%3Dc%26hvdvcmdl%3D%26hvlocint%3D%26hvlocphy%3D9198840%26hvtargid%3Dkwd-64107830%26hydadcr%3D14452_2316413%26gad_source%3D1&openid.identity=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.assoc_handle=inflex&openid.mode=checkid_setup&openid.claimed_id=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.ns=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0");
            driver.FindElement(By.XPath("//input[@name=\"email\"]")).SendKeys("BhavanaaR@saglobal.com");
            driver.FindElement(By.XPath("//input[@type=\"submit\"]")).Click();
            driver.Close();
        }
