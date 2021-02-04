using ConsoleApp1.Model;
using ConsoleApp1.View;
using ConsoleApp1.Controller;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Principal
    {
        static void Main(string[] args)
        {
            List<Client> list_clients = new List<Client>();
            List<Videos> list_videos = new List<Videos>();

            Vista v = new Vista();
            Control c = new Control(v);
            bool stop1 = false;
            bool stop2 = false;

            v.menu();

            while (!stop1)
            {
                Client nou = c.Creacio_Client();

                list_clients.Add(nou);

                v.continuar("clientes");
                int opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 2)
                    stop1 = true;
            }

            while (!stop2)
            {
                Videos nou = c.creacio_Video(list_clients);

                if (nou != null)
                {
                    list_videos.Add(nou);
                }

                v.continuar("videos");
                int opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 2)
                    stop2 = true;
            }

            foreach (Client cli in list_clients)
            {
                Console.WriteLine(cli.toString());
            }

            foreach (Videos videos in list_videos)
            {
                Console.WriteLine(videos.toString());
            }


        }
    }
}