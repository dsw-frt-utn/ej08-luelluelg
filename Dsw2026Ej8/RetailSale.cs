using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
     // clase derivada 1: venta minorist
  internal class RetailSale : Sale
    {
        public RetailSale(decimal amount) : base(amount) {
        }

        public override decimal CalculateTotal()
        {
            // sin descuento
            return Amount;
        }
    }
}
