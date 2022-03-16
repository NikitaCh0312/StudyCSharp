using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitApplication
{
    public class Substractor: ISubstractor
    {
        #region Enums
        #endregion Enums

        #region Constants
        #endregion Constants

        #region Fields

        #endregion Fields

        #region Properties
        #endregion Properties

        #region Events
        #endregion Events

        #region Constructors

        public Substractor()
        {

        }

        #endregion Constructors

        #region Methods

        public int Substract(int a, int b)
        {
            return a -b;
        }

        #endregion Methods
    }
}
