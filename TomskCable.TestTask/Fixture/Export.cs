using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TomskCable.TestTask.ViewModel;

namespace TomskCable.TestTask.Fixture
{
    public class Export
    {
        private string fileName = string.Empty;

        public Export(string fileName)
        {
            this.fileName = fileName;
        }

        public void Save(IList<TestDataVm> data)
        {
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Тестовые данные");

                worksheet.Cells[1, 1].Value = "A";
                worksheet.Cells[1, 2].Value = "B";
                worksheet.Cells[1, 3].Value = "C";
                worksheet.Cells[1, 4].Value = "D";
                worksheet.Cells[1, 5].Value = "E";
                worksheet.Cells[1, 6].Value = "F";
                worksheet.Cells[1, 7].Value = "G";
                worksheet.Cells[1, 8].Value = "H";
                worksheet.Cells[1, 9].Value = "I";
                worksheet.Cells[1, 10].Value = "J";
                worksheet.Cells[1, 11].Value = "K";
                worksheet.Cells[1, 12].Value = "L";
                worksheet.Cells[1, 13].Value = "M";
                worksheet.Cells[1, 14].Value = "N";
                worksheet.Cells[1, 15].Value = "O";

                for (var i = 0; i < data.Count; i++)
                {
                    var item = data[i];
                    worksheet.Cells[$"A{i + 2}"].Value = item.A;
                    worksheet.Cells[$"B{i + 2}"].Value = item.B;
                    worksheet.Cells[$"C{i + 2}"].Value = item.C;
                    worksheet.Cells[$"D{i + 2}"].Value = item.D;
                    worksheet.Cells[$"E{i + 2}"].Value = item.E;
                    worksheet.Cells[$"F{i + 2}"].Value = item.F;
                    worksheet.Cells[$"G{i + 2}"].Value = item.G;
                    worksheet.Cells[$"H{i + 2}"].Value = item.H;
                    worksheet.Cells[$"I{i + 2}"].Value = item.I;
                    worksheet.Cells[$"J{i + 2}"].Value = item.J;
                    worksheet.Cells[$"K{i + 2}"].Value = item.K;
                    worksheet.Cells[$"L{i + 2}"].Value = item.L;
                    worksheet.Cells[$"M{i + 2}"].Value = item.M;
                    worksheet.Cells[$"N{i + 2}"].Value = item.N;
                    worksheet.Cells[$"O{i + 2}"].Value = item.O;
                }

                package.SaveAs(new FileInfo(fileName));
            }
        }
    }
}
