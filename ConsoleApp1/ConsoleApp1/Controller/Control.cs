using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.Model;
using ConsoleApp1.View;

namespace ConsoleApp1.Controller
{
    class Control
    {
        private Vista vista;


        public Control(Vista vista)
        {
            this.vista = vista;
        }

        public Client Creacio_Client()
        {
            string nombre;

            vista.menu_Ciente();

            nombre = "nombre cliente";
            vista.menu_string(nombre);
            string nom = Console.ReadLine();

            nombre = "apellido cliente";
            vista.menu_string(nombre);
            string apellido = Console.ReadLine();

            nombre = "direccion cliente";
            vista.menu_string(nombre);
            string direccion = Console.ReadLine();

            nombre = "dni(numeros) cliente";
            vista.menu_string(nombre);
            int dni = Convert.ToInt32(Console.ReadLine());


            Client nou = new Client(nom,apellido,direccion,dni,DateTime.Now);

            return nou;
        }

        public Videos creacio_Video(List<Client>list)
        {
            string nombre;
            vista.menu_Video();

            nombre = "titulo video";
            vista.menu_string(nombre);
            string titulo = Console.ReadLine();

            nombre = "director video";
            vista.menu_string(nombre);
            string director = Console.ReadLine();
         
            nombre = "id cliente";
            vista.menu_string(nombre);
            int id_cli = Convert.ToInt32(Console.ReadLine());

            Videos nou = new Videos(titulo,director,id_cli,list);

            if (nou.valido)
                return nou;
            else
                return null;
        }
    }
}
