using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagment.Utilities
{
    public class DataSource
    {
        public static object[] InvalidLoginData()
        {


            string[] dataset1 = new string[3];
            dataset1[0] = "john";
            dataset1[1] = "john123";
            dataset1[2] = "invalid credentials";

            string[] dataset2 = new string[3];
            dataset2[0] = "peter";
            dataset2[1] = "peter123";
            dataset1[2] = "invalid credentials";
            string[] dataset3 = new string[3];
            dataset3[0] = "saul";
            dataset3[1] = "saul123";
            dataset1[2] = "invalid credentials";

            object[] allDataSet = new object[3];
            allDataSet[0] = dataset1;
            allDataSet[1] = dataset2;
            allDataSet[2] = dataset3;
            return allDataSet;
        }



        public static object[] EmployeeData()
        {

            string[] dataset1 = new string[6];
            dataset1[0] = "Admin";
            dataset1[1] = "admin123";
            dataset1[2] = "John";
            dataset1[3] = "W";
            dataset1[4] = "wick";
            dataset1[5] = "John wick";


            string[] dataset2 = new string[6];
            dataset2[0] = "Admin";
            dataset2[1] = "admin123";
            dataset2[2] = "saul";
            dataset2[3] = "g";
            dataset2[4] = "goodman";
            dataset2[5] = "saul goodman";


            object[] alldataset = new object[2];

            alldataset[0] = dataset1;
            alldataset[1] = dataset2;

            return alldataset;
        }

        public static object[] InvalidLoginData2()
        {
            object[] data = ExcelUtils.GetSheetIntoObjectArray

                (@"C:\Users\ajitd\Desktop\CSharp\AutomationFramework\EmployeeManagment\TestData\Orange_data.xlsx", "InvalidLoginData");

            return data;
        }

        public static object[] AddValidEmployeeData2()
        {
            object[] data = ExcelUtils.GetSheetIntoObjectArray(@"C:\Users\ajitd\Desktop\CSharp\AutomationFramework\EmployeeManagment\TestData\Orange_data.xlsx", "AddValidEmployee");
            return data;
        }
    }
}