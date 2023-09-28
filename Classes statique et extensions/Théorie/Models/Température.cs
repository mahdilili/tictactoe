using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Théorie.Models
{
    public static class Température
    {
        #region Méthodes

        static public float ConvertirEnCelsius(float fFahrenheit)
            {
                return (fFahrenheit - 32) * 5 / 9;
            }
            static public float ConvertirEnFarhenheit(float fCelsius)
            {
                return (fCelsius * 9 / 5) + 32;
            }
        #endregion
        
    }
}
