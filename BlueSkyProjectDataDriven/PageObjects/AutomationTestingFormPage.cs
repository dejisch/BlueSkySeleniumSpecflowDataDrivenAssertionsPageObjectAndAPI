using BlueSkyProject2.Hooks;
using BlueSkyProjectDataDriven.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace BlueSkyProject2.PageObjects
{
    class AutomationTestingFormPage
    {
        IWebDriver driver;

        Waits waits;

        IWebElement singleLineText => driver.FindElement(By.Id("nf-field-135"));

        IWebElement selectOneTwoThree => driver.FindElement(By.XPath("//*[@id='nf-field-136']"));

        IWebElement multiSelect123 => driver.FindElement(By.CssSelector("#nf-field-137"));

        IWebElement selectRadio => driver.FindElement(By.Id("nf-label-class-field-138-0"));

        IWebElement dateFromCalendar => driver.FindElement(By.CssSelector("input.pikaday__display.pikaday__display--pikaday.ninja-forms-field.nf-element.datepicker"));

        IWebElement emailAddress => driver.FindElement(By.Name("email"));

        IWebElement passwordText => driver.FindElement(By.Id("nf-field-144"));

        IWebElement submit => driver.FindElement(By.Id("nf-field-133"));

        IWebElement errorMsg => driver.FindElement(By.CssSelector("#nf-form-errors-9 > nf-errors > nf-section > div"));

        public string GetPageTitle => driver.Title;

        public string GetPageURL => driver.Url;

        //public string GetPageTitle()
        //{
        //    return driver.Title;
        //}


        public void CheckErrorMessageIsDisplayed()
        {
            Assert.IsTrue(errorMsg.Displayed);
            
        }

        public string GetTextForError()
        {

            //return waits.WaitForElement(driver, errorMsg).Text;
            IWebDriver myDriver = driver;
            return waits.MyDriverWait(myDriver, errorMsg).Text;
        }

        public void ClickOnSubmit()
        {
            waits.WaitForElement(driver, submit).Click();
            //submit.Click();
        }

        public void EnterPassword(string password)
        {
            passwordText.SendKeys(password);
        }

        public void  SelectDateFromCalendar()
        {
            dateFromCalendar.SendKeys("01/01/2020");

        }

        public void EnterEmail(string email)
        {
            emailAddress.SendKeys(email);
        }

        public void SelectOneFromSelectRadio()
        {
            selectRadio.Click();
        }
        public void SelectMultiSelector()
        {
            SelectElement multiSelector = new SelectElement(multiSelect123);
            multiSelector.SelectByText("Two");
            multiSelector.SelectByText("Three");

        }


        public void SelectOneFromSelectOneTwoThree()
        {
            SelectElement select = new SelectElement(selectOneTwoThree);
            select.SelectByValue("one");
        }

        public void EnterSingleLineText()
        {
            singleLineText.SendKeys("Deji");
        }

        public AutomationTestingFormPage()
        {
            driver = Hook.driver;
            waits = new Waits();
        }


        public void NavigateToForm()
        {
            driver.Navigate().GoToUrl("http://blueskycitadel.com/automation-testing-form/");
        }

        public void NavigateToFormWithParameter(string url)
        {
            driver.Navigate().GoToUrl(url);

        }
    }
}
