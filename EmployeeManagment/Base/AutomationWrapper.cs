﻿using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagment.Base
{
    public class AutomationWrapper
    {
       protected IWebDriver driver;
        [SetUp]

        public void BeforeMethod()
        {

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Url = "https://opensource-demo.orangehrmlive.com/";

        }
        [TearDown]
        public void AfterMethod()
        {

            driver.Quit();


        }


    }

}