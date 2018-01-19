using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqDemo_POC
{
    public interface IRepository
    {
        List<Band> GetBands();
    }
}
