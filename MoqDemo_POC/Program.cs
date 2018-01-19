using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqDemo_POC
{
    class Program
    {
        static void Main(string[] args)
        {
            IRepository repository = new Repository();
            BandController controller = new BandController(repository);
            controller.MethodToTest();
        }
    }
}
