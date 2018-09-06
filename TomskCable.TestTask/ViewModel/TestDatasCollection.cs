using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TomskCable.TestTask.Fixture;

namespace TomskCable.TestTask.ViewModel
{
    public class TestDataCollectionVm
    {
        public TestDataCollectionVm()
        {
            testData = new ObservableCollection<TestDataVm>();
            var index = 1;
            foreach (var item in DataGenerator.Generate())
            {
                item.Index = index;
                testData.Add(item);
                index++;
            }
        }

        private ObservableCollection<TestDataVm> testData;

        public ObservableCollection<TestDataVm> Data => testData;
    }
}
