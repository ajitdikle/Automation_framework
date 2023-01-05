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
    public class LoginTest : AutomationWrapper

    {
        [Test]
        public void ValidLoginTest()
        {
            driver.FindElement(By.Name("username")).SendKeys("Admin");
            driver.FindElement(By.Name("password")).SendKeys("admin123");
            driver.FindElement(By.XPath("//button[@type = 'submit']")).Click();

            string actualUrl = driver.Url;
            Assert.That(actualUrl, Is.EqualTo("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login"));




        }





        [Test, TestCaseSource(typeof(DataSource), nameof(DataSource.InvalidLoginData))]

        
        public void InvalidLoginTest(string username, string password, string expectedError)
        {

            driver.FindElement(By.Name("username")).SendKeys(username);
            driver.FindElement(By.Name("password")).SendKeys(password);
            driver.FindElement(By.XPath("//button[@type = 'submit']")).Click();

            string actualError = driver.FindElement(By.XPath("//p[contains(normalize-space(),'cred')]")).Text;

            Assert.That(actualError.Contains(expectedError));

        }



    }

}