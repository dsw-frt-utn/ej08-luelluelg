using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema2
    {

        
            public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
            {         
                
                decimal total;      //para el total
            
                if (quantity <= 0) {
                    total = 0;         
                }else { 
                   total = quantity * unitPrice;         
                }               
                var resumen = new    {
                    Code = productCode,             
                    Description = productDescription,             
                    Quantity = quantity,             
                    Total = total         
                };         
                
                string resultado = resumen.Code + "-" + resumen.Description + "-" + resumen.Total;         return resultado;    
            } 
    }

            
}

