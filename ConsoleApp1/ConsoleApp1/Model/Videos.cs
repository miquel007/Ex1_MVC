using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.View;
namespace ConsoleApp1.Model
{
   
    class Videos
    {
        public int id { get; private set; }
        public string title { get; set; }
        public string director { get; set; }
        public int cli_id { get; set; }
        public bool valido { get; set; }

        private static int ultimoValor = 0;

        private int Contador()
        {
            return ultimoValor++;
        }
        private int Contador_Restar()
        {
            return ultimoValor--;
        }

        public Videos(string title, string director, int cli_id, List<Client> list)
        {
            Vista nou = new Vista();

            this.id = Contador();
            this.title = title;
            this.director = director;
            this.valido = comprovante(list, cli_id);
            if (!valido)
            {
                nou.error_valor();
                Contador_Restar();
            }                
            else
                this.cli_id = cli_id;
        }

        private bool comprovante (List<Client> list, int cli_id)
        {
            foreach (Client c in list)
                if (c.id == cli_id)
                    return true;

            return false;
        }

        public string toString()
        {
            string frase = "id " + id +" titulo " + title +" director " + director +" cli_id " + cli_id;

            return frase;
        }

    }
}
