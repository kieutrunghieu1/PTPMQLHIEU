using OfficeOpenXml;
using System.Data;
using System.IO;

namespace MvcMovie.Models.Process
{
    public class ExcelProcess
    {
       
        public DataTable ExcelToDataTable(string filePath)
        {
         
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            var dt = new DataTable();

         
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

           
                bool hasHeader = true; 
                foreach (var firstRowCell in worksheet.Cells[1, 1, 1, worksheet.Dimension.End.Column])
                {
                    dt.Columns.Add(hasHeader ? firstRowCell.Text : $"Column {firstRowCell.Start.Column}");
                }

           
                var startRow = hasHeader ? 2 : 1; 
                for (int rowNum = startRow; rowNum <= worksheet.Dimension.End.Row; rowNum++)
                {
                    var wsRow = worksheet.Cells[rowNum, 1, rowNum, worksheet.Dimension.End.Column];
                    DataRow row = dt.NewRow();
                    int colIndex = 0;
                    foreach (var cell in wsRow)
                    {
                        row[colIndex++] = cell.Text;
                    }
                    dt.Rows.Add(row);
                }
            }

            return dt;
        }
    }
}
