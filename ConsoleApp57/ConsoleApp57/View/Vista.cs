using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp57.View
{
    class Vista
    {
        public void menu()
        {
            Console.WriteLine("Has accedidio al programa");
        }

        public void menu_Objeto(string nom)
        {
            Console.WriteLine("Tienes que poner los datos del {0}", nom);
        }

        public void menu_Valor(string nom)
        {
            Console.WriteLine("Tienes que poner {0}", nom);
        }

        public void continuar(string nombre)
        {
            Console.WriteLine("Desea poner mas {0} ? YES[1], NO[2]", nombre);
        }

        public void error_fk(string nom1,string nom2)
        {
            Console.WriteLine("El {0} del {1} no coincide",nom1,nom2);
        }

        public void error_valor(string nom1, string nom2)
        {
            Console.WriteLine("El {0} del {1} no cumple los requisitos", nom1, nom2);
        }
    }
}
