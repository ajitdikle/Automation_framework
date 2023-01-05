using EmployeeManagment.Base;
using EmployeeManagment.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagment
{
    public class EmployeeTest : AutomationWrapper

    {
        [Test, TestCaseSource(typeof(DataSource), nameof(DataSource.EmployeeData))]
        public void AddValidEmployee(string username, string password, String firstName, string middleName, string lastName, string employeename)
        {




            driver.FindElement(By.Name("username")).SendKeys(username);
            driver.FindElement(By.Name("password")).SendKeys(password);
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();



           driver.FindElement(By.XPath("//span[text()='PIM']")).Click();



         



            driver.FindElement(By.XPath("//button[normalize-space()=\"Add\"]")).Click();




            driver.FindElement(By.Name("firstName")).SendKeys(firstName);
            driver.FindElement(By.Name("middleName")).SendKeys(middleName);
            driver.FindElement(By.Name("lastName")).SendKeys(lastName);



            driver.FindElement(By.XPath("//button[normalize-space()='Save']")).Click();



            string actualtext = driver.FindElement(By.CssSelector("[class='oxd-text oxd-text--h6 --strong']")).Text;
            actualtext.ToString();
            Assert.That(employeename.Contains(actualtext), "Assert in  error msg");
        }
        
        








        }

    }

