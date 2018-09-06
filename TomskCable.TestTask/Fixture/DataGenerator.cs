using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TomskCable.TestTask.ViewModel;

namespace TomskCable.TestTask.Fixture
{
    public class DataGenerator
    {
        public static IEnumerable<TestDataVm> Generate()
        {
            var random = new Random();

            for(var i = 0; i < 200; i++)
            {
                yield return new TestDataVm
                {
                    A = random.NextDouble(),
                    B = random.NextDouble(),
                    C = random.NextDouble(),
                    D = random.NextDouble(),
                    E = random.NextDouble(),
                    F = random.NextDouble(),
                    G = random.NextDouble(),
                    H = random.NextDouble(),
                    I = random.NextDouble(),
                    J = random.NextDouble(),
                    K = random.NextDouble(),
                    L = random.NextDouble(),
                    M = random.NextDouble(),
                    N = random.NextDouble(),
                    O = random.NextDouble()                    
                };
            }
        }
    }
}
