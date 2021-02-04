using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp57.Model
{
    class Cientificos
    {
        public string DNI { get; set; }

        public string NomApels { get; set; }

        public Cientificos(string DNI,string nom)
        {
            this.DNI = DNI;
            this.NomApels = nom;
        }

        public bool comprovant_DNI()
        {
            if (DNI.Length == 8)
                return true;
            
            return false;
        }

        public string toString()
        {
            string frase = "DNI Cientifico " + DNI + " nombre " + NomApels;

            return frase;
        }
    }
}
