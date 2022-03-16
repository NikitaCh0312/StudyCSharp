using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitApplication
{
    public class Calculator: ICalculator
    {

        private ISubstractor _substractor;

        #region Constructors

        public Calculator()
        {

        }

        public Calculator(ICreator substractor)
        {
            _substractor = substractor.GetSubstractor();
        }

        #endregion Constructors

        #region Methods

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Substract(int a, int b)
        {
            return _substractor.Substract(a,b);
        }

        #endregion Methods
    }
}
