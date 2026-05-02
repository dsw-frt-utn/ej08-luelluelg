using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Dsw2026Ej8
{
   
        public partial class ProductHelper
        {
     
            private const string CulturaMoneda = "es-AR"; // dinero argentino

   
            private string FormatearPrecio(decimal precio)
            {
                CultureInfo cultura = new CultureInfo(CulturaMoneda);
                return precio.ToString("C", cultura);
            }
        }
    
}
