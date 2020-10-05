using System;

namespace Eventos
{
    class Empresarial : Cultural
    {
       //Propiedades
        public string Venta_Producto{ get; set; }
        public string Sociali_Empresa { get; set; }
        
       //Funciones
        public void Charla()
        {
            Console.WriteLine("Comenzamos Pronto");
        }
    }
}