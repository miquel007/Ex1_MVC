using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Model
{
    class Client
    {
        public int id { get; private set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public int dni { get; set; }
        public DateTime fecha { get; set; }

        private static int ultimoValor = 0;

        private int Contador()
        {
            return ultimoValor++;
        }

        public Client(string nombre, string apellido, string direccion, int dni, DateTime fecha)
        {
            this.id = Contador();
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.dni = dni;
            this.fecha = fecha;
        }


        public string toString()
        {
            string frase = "id " + id +" nom " + nombre +" cogmon " + apellido +" direccio " + direccion +" dni " + dni +" data " + fecha;

            return frase;
        }
    }
}
