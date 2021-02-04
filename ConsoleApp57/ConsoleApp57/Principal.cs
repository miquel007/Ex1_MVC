using ConsoleApp57.Controller;
using ConsoleApp57.Model;
using ConsoleApp57.View;
using System;
using System.Collections.Generic;

namespace ConsoleApp57
{
    class Principal
    {
        static void Main(string[] args)
        {
            List<Cientificos> list_cientificos = new List<Cientificos>();
            List<Proyecto> list_proyectos = new List<Proyecto>();
            List<Asignado_A> list_asignado = new List<Asignado_A>();

            Vista v = new Vista();
            Control c = new Control(v);
            bool stop1 = false;
            bool stop2 = false;
            bool stop3 = false;

            while (!stop1)
            {
                Cientificos nou = c.Creacio_Cientifico();

                if(nou !=null)
                    list_cientificos.Add(nou);

                v.continuar("Cientifico");
                int opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 2)
                    stop1 = true;
            }

            while (!stop2)
            {
                Proyecto nou = c.Creacio_Proyecto();

                if (nou != null)
                {
                    list_proyectos.Add(nou);
                }

                v.continuar("Proyecto");
                int opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 2)
                    stop2 = true;
            }

            while (!stop3)
            {
                Asignado_A nou = c.Creacio_Asignado(list_cientificos,list_proyectos);

                if (nou != null)
                {
                    list_asignado.Add(nou);
                }

                v.continuar("Asignacion");
                int opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 2)
                    stop3= true;
            }

            Console.WriteLine("\n");

            foreach (Cientificos cien in list_cientificos)
            {
                Console.WriteLine(cien.toString());
            }

            Console.WriteLine("\n");

            foreach (Proyecto videos in list_proyectos)
            {
                Console.WriteLine(videos.toString());
            }

            Console.WriteLine("\n");

            foreach (Asignado_A videos in list_asignado)
            {
                Console.WriteLine(videos.toString());
            }
        }
    }
}
