using ConsoleApp57.Model;
using ConsoleApp57.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp57.Controller
{
    class Control
    {
        private Vista vista;


        public Control(Vista vista)
        {
            this.vista = vista;
        }

        public Cientificos Creacio_Cientifico()
        {
            string nombre;

            nombre = "Cientifico";
            vista.menu_Objeto(nombre);

            nombre = "dni del Cientifico";
            vista.menu_Valor(nombre);
            string DNI = Console.ReadLine();

            nombre = "nombre del  Cientifico";
            vista.menu_Valor(nombre);
            string nom = Console.ReadLine();

            Cientificos nou = new Cientificos(DNI, nom);

            if (nou.comprovant_DNI())
                return nou;
            else
            {
                nombre = "Cientifico";
                nom = "DNI";

                vista.error_valor(nom,nombre);

                return null;
            }
        }

        public Proyecto Creacio_Proyecto()
        {
            string nombre;

            nombre = "Proyecto";
            vista.menu_Objeto(nombre);

            nombre = "id del Proyecto";
            vista.menu_Valor(nombre);
            string id = Console.ReadLine();

            nombre = "nombre del  Proyecto";
            vista.menu_Valor(nombre);
            string nom = Console.ReadLine();

            nombre = "horas del  Proyecto";
            vista.menu_Valor(nombre);
            int horas = Convert.ToInt32( Console.ReadLine());

            Proyecto nou = new Proyecto(id, nom, horas);

            if (nou.comprovant_id())
                return nou;
            else
            {
                nombre = "Proyecto";
                nom = "ID";

                vista.error_valor(nom, nombre);

                return null;
            }
        }

        public Asignado_A Creacio_Asignado(List<Cientificos>list1,List<Proyecto>list2)
        {
            string nombre;
            string nom;

            nombre = "Asignado_A";
            vista.menu_Objeto(nombre);

            nombre = "dni del Cientifico";
            vista.menu_Valor(nombre);
            string DNI = Console.ReadLine();

            nombre = "id del Proyecto";
            vista.menu_Valor(nombre);
            string id = Console.ReadLine();

            Asignado_A nou = new Asignado_A(DNI, id);

            bool comprovant1 = nou.comprovant_cientifico(list1);
            bool comprovant2 = nou.comprovant_proyecto(list2);

            if (comprovant1 && comprovant2)
                return nou;
            else 
            {
                if (!comprovant1 && !comprovant2)
                {
                    nombre = "Cientifico";
                    nom = "DNI";

                    vista.error_fk(nom, nombre);

                    nombre = "Proyecto";
                    nom = "ID";

                    vista.error_fk(nom, nombre);

                    return null;
                }
                else if (!comprovant1)
                {
                    nombre = "Cientifico";
                    nom = "DNI";

                    vista.error_fk(nom, nombre);

                    return null;
                }
                else
                {
                    nombre = "Proyecto";
                    nom = "ID";

                    vista.error_fk(nom, nombre);

                    return null;
                }
               
            }
        }
    }
}
