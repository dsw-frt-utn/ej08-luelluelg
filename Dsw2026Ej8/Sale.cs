using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Sale
    {



        public decimal Amount { get; set; }  // importe bruto

        public Sale(decimal amount)
        {
            Amount = amount;
        }

        // virtual, hago esto, pero una subclase puede cambiarlo
        public virtual decimal CalculateTotal()
        {
            return Amount;
        }







    }
}
