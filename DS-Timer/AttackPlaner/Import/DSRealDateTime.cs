using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS_Timer.AttackPlaner.Import
{
    class DSRealDateTime : IFormatProvider
    {
        #region IFormatProvider Members

        public object GetFormat(Type formatType)
        {
            return String.Format("dd.MM.2011 - HH.mm.ss");
        }

        #endregion
    }
}
