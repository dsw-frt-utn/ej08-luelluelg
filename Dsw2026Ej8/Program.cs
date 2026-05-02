namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //problema 1
            var helper = new ProductHelper();

            string etiqueta = helper.ObtenerEtiquetaProducto(
                code: 1001,
                description: "Teclado Mecanico RGB",
                price: 25999.99m
            );

            Console.WriteLine(etiqueta);
            // salida esperada 1001, fin problema 1


            //problema 3
            Product miProducto = new Product("Descripción original");

            Problema3 p3 = new Problema3();
            string resultado = p3.CompararCopias(5, miProducto);

            Console.WriteLine(resultado);
            // Salida esperada: 5-6-Descripción modificada, fin problema3



            //inicio problema 4
            Problema4 p = new Problema4();
            // pruebas
            Console.WriteLine(p.CalcularPromedio(8, 6, 10));      // 8
            Console.WriteLine(p.CalcularPromedio(null, null, null)); //  0
            Console.WriteLine(p.CalcularPromedio(5, null, 9));    //  7
            Console.WriteLine(p.CalcularPromedio(-1, 8, 15));     //  8  (ignora -1 y 15)
            Console.WriteLine(p.CalcularPromedio(null, 7, null)); // 7




 
       
           //inicio problema 5
           Problema5 problema = new Problema5();

           // venta minorista $1000, sin descuento
           Sale retail = new RetailSale(1000m);
           decimal totalRetail = problema.ObtenerImporteFinal(retail);
           Console.WriteLine($"RetailSale    :${totalRetail}");   // $1000

            // venta mayorista $1000, 10% de descuento
            Sale wholesale = new WholesaleSale(1000m);
           decimal totalWholesale = problema.ObtenerImporteFinal(wholesale);
           Console.WriteLine($"WholesaleSale : ${totalWholesale}"); // $900
                                                                    //fin problema 5



            //inicio del problema 6
            Problema6 s = new Problema6();
            Console.WriteLine(s.NormalizarCodigoProducto(" ab 123 x ")); // AB-123-X
            Console.WriteLine(s.NormalizarCodigoProducto(null));          // SIN-CODIGO
            Console.WriteLine(s.NormalizarCodigoProducto("  hola mundo ")); // HOLA-MUNDO
            //fin problema 6

        }
    }
}
