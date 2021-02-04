using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.View
{
    public class Vista
    {
        public void menu()
        {
            Console.WriteLine("Bienvenido al controlador de clientes y ventas");
 
        }

        public void menu_Ciente()
        {
            Console.WriteLine("Tienes que ponner datos del cliente");

        }

        public void menu_Video()
        {
            Console.WriteLine("Tienes que ponner datos del video");

        }

        public void menu_string(string nombre)
        {
            Console.WriteLine("Tienes que ponner {0}",nombre);
        }

        public void continuar (string nombre)
        {
            Console.WriteLine("Desea poner mas {0} ? YES[1], NO[2]", nombre);
        }

        public void error_valor()
        {
            Console.WriteLine("El id del cliente no existe");
        }


    }
}
