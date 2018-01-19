using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqDemo_POC
{
    public class BandController
    {
        IRepository repository;
        public BandController(IRepository repository)
        {
            this.repository = repository;
        }

        public void MethodToTest()
        {
            var bands = this.repository.GetBands();
            foreach (var band in bands)
            {
                if (band.Name == "Band New 2")
                {
                    Console.WriteLine("I love this song");
                }
            }
        }

    }
}
