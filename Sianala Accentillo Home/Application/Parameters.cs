using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    internal class Parameters
    {
        #region SettingsValues
        internal enum Theme
        {
            Black = 0,
            Blue = 1,
            White = 2
        }
        internal enum Lang
        {
            English = 0,
            Russian = 1
        }
        #endregion SettingsValues
        internal void Set(Lang Culture, Theme Theme)
        {
            var Cult = Culture.ToString();
            var Them = Theme.ToString();

        }
        internal class Get
        {

        }
    }
}
