using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TomskCable.TestTask.Fixture;
using TomskCable.TestTask.ViewModel;

namespace TomskCable.TestTask
{
    public partial class MainWindow : Window
    {
        private TestDataCollectionVm collectionVm = new TestDataCollectionVm();
        public MainWindow()
        {
            InitializeComponent();
            grid.ItemsSource = collectionVm.Data;
        }

        private void Export(object sender, RoutedEventArgs e)
        {
            var fileName = DialogFixture.OpenSaveDialog();

            if (!string.IsNullOrEmpty(fileName))
            {
                new Export(fileName).Save(collectionVm.Data);
                DialogFixture.ShowOkDialog(fileName);
            }
        }
    }
}
