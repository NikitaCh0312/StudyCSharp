using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitApplication
{
    public interface ICreator
    {
        ISubstractor GetSubstractor();
    }
}
