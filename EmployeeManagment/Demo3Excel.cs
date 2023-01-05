using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagment
{
   public class Demo3Excel
    {
        [Test]
        public void DemoExcelRead()
        { 
        
        XLWorkbook book = new XLWorkbook(@"C:\Users\ajitd\Desktop\CSharp\AutomationFramework\EmployeeManagment\TestData\Orange_data.xlsx");

            IXLWorksheet sheet = book.Worksheet("InvalidLoginData");

            IXLRange range = sheet.RangeUsed();

            string value = range.Cell(2,2).GetString();
            Console.WriteLine(value);
        
        }

    }
}
