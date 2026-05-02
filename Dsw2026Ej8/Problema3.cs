using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema3
    {

        public string CompararCopias(int originalValue, Product product)
        {
           
            int copia = originalValue;

            copia++;
         
            Product productoCopia = product;

            productoCopia.SetDescription("Descripción modificada");


            return originalValue + "-" + copia + "-" + product.Description;
        }



    }
}
