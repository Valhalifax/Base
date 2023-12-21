using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLibrary
{
    public interface IGenerator
    {
        public IEnumerable<int> Generate(int maxIterations = 10);
    }
}
