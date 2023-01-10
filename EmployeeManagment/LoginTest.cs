using EmployeeManagment.Base;
using EmployeeManagment.Pages;
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
            LoginPage loginpage = new LoginPage(driver);

            loginpage.EnterUsername("Admin");
            loginpage.EnterPassword("admin123");




            
            driver.FindElement(By.XPath("//button[@type = 'submit']")).Click();

            string actualUrl = driver.Url;
            Assert.That(actualUrl, Is.EqualTo("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login"));




        }





        [Test, TestCaseSource(typeof(DataSource), nameof(DataSource.InvalidLoginData2))]

        
        public void InvalidLoginTest(string username, string password, string expectedError)
        {
            LoginPage loginpage = new LoginPage(driver);

            loginpage.EnterUsername("john");
            loginpage.EnterPassword("a123");
           
            driver.FindElement(By.XPath("//button[@type = 'submit']")).Click();

            string actualError = driver.FindElement(By.XPath("//p[contains(normalize-space(),'cred')]")).Text;

            Assert.That(actualError.Contains(expectedError));

        }



    }

}