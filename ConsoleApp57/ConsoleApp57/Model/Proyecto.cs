using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp57.Model
{
    class Proyecto
    {
        public string id { get; set; }

        public string nombre { get; set; }

        public int horas { get; set; }

        public Proyecto(string id,string nombre,int horas)
        {
            this.id = id;
            this.nombre = nombre;
            this.horas = horas;
        }

        public bool comprovant_id()
        {
            if (id.Length == 4)
                return true;

            return false;
        }

        public string toString()
        {
            string frase = "ID Proyecto " + id + " nombre " + nombre + " horas " + horas;

            return frase;
        }
    }
}
