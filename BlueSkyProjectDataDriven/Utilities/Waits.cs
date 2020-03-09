using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueSkyProjectDataDriven.Utilities
{
    public class Waits
    {
        public IWebElement WaitForElement(IWebDriver driver, IWebElement element)
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(500);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            if (fluentWait.Until(x => element.Displayed))
                return element;
            else
                return null;
        }

        public IWebElement MyDriverWait(IWebDriver driver, IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
            Func<IWebDriver, IWebElement> waitForElement = new Func<IWebDriver, IWebElement>((IWebDriver driver) =>
            {
                return element;
            });
            wait.Until(waitForElement);
            return element;
            
        }

    }
}
