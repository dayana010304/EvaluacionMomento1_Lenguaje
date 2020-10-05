using System;

namespace Eventos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eventos");
            Console.WriteLine("Exposicion: ");
            string Expo = Console.ReadLine();
            Console.WriteLine("Conferencia: ");
            string Confe = Console.ReadLine();
            Console.WriteLine("Aforo: ");
            int Aforo = int.Parse(Console.ReadLine());
            Console.WriteLine("Productos en venta");
            string Producto = Console.ReadLine();
            Console.WriteLine("Presentacion Empresa");
            string Social = Console.ReadLine();
            Console.WriteLine("Muestras De Productos");
            string Muestras = Console.ReadLine();


            Cultural cultural = new Cultural ()
            {
                Exposicion = Expo,
                Conferencia = Confe,
                Aforo = Aforo
            };

            Empresarial empresarial = new Empresarial()
            {
                Venta_Producto = Producto,
                Sociali_Empresa = Social
            };

            Feria feria = new Feria()
            {
                Mostrario = Muestras
            };

            Console.WriteLine($"{cultural.Exposicion} {cultural.Exposicion} {cultural.Aforo} {empresarial.Venta_produc} {empresarial.Sociali_empresa} {feria.Mostrario}");
        }   
        
    }
}
