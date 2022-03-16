using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitApplication
{
    public class Creator:ICreator
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
        #endregion Constructors

        #region Methods

        public ISubstractor GetSubstractor()
        {
            return new Substractor();
        }

        #endregion Methods
    }
}
