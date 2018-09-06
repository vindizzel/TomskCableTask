using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TomskCable.TestTask.Fixture
{
    public class DialogFixture
    {
        public static string OpenSaveDialog()
        {
            var dialog = new SaveFileDialog();
            dialog.FileName = "Document";
            dialog.DefaultExt = ".xlsx"; 
            dialog.Filter = "Text documents (.xlsx)|*.xlsx"; 

            var result = dialog.ShowDialog();

            if (result == true)
                return dialog.FileName;

            return string.Empty;
        }

        public static void ShowOkDialog(string fileName)
        {
            MessageBox.Show($"Файл {fileName} успешно сохранен!", "", MessageBoxButton.OK);
        }
    }
}