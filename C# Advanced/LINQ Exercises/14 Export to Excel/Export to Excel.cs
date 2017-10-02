using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;

namespace _14_Export_to_Excel
{
    public class _14_Export_to_Excel
    {
        public static void Main()
        {
            var xlsPackage = new ExcelPackage();
            var workSheet = xlsPackage.Workbook.Worksheets.Add("Course Result");

            workSheet.Cells[1, 1, 1, 11].Merge = true;
            workSheet.Cells[1, 1, 1, 11].Style.Font.Size = 20;
            workSheet.Cells[1, 1, 1, 11].Style.Font.Bold = true;
            workSheet.Cells[1, 1, 1, 11].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            workSheet.Cells[1, 1].Value = "SoftUni OOP Results";

            using (var reader = new StreamReader("../../StudentData.txt"))
            {
                var line = reader.ReadLine();
                var row = 2;
                while (line != null)
                {
                    var columns = line.Split('\t');
                    for (int i = 1; i <= columns.Length; i++)
                    {
                        workSheet.Cells[row,i].Value = columns[i-1];                        
                    }
                    row++;
                    line = reader.ReadLine();
                }
                workSheet.Cells[2, 1, 2, 11].Style.Font.Bold = true;
                workSheet.Cells[2, 1, 2, 11].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;         
               
                var output = new FileStream("../../StudentData.xlsx", FileMode.Create);
                xlsPackage.SaveAs(output);
            }
        }
    }
}
