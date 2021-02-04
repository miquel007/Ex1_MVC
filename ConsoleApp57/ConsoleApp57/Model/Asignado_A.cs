using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp57.Model
{
    class Asignado_A
    {
        public string Cientifico { get; set; }
        public string Proyecto { get; set; }

        public Asignado_A(string Cientifico, string proyecto)
        {
            this.Cientifico = Cientifico;
            this.Proyecto = proyecto;
        }

        public bool comprovant_cientifico (List<Cientificos> list1)
        {
            foreach (Cientificos cien in list1)
                if (string.Compare(cien.DNI, Cientifico, true) == 0)
                {
                    return true;
                }

            return false;
        }

        public bool comprovant_proyecto(List<Proyecto> list2)
        {
            foreach (Proyecto pro in list2)
                if (string.Compare(pro.id, Proyecto, true) == 0)
                {
                    return true;
                }
                  
            return false;
        }

        public string toString()
        {
            string frase = "DNI Cientifico " + Cientifico + " id Proyecto " + Proyecto;

            return frase;
        }

    }
}
