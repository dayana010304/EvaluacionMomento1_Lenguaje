using System;

namespace Eventos
{
    class Feria: Cultural
    {
       //Propiedades
        public string Mostrario { get; set; }
       //Funciones
        public void Degustacion()
        {
            Console.WriteLine("Comenzamos Pronto");
        }
    }
}