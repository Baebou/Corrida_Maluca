using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooRacingGame
{
    public class Corredor
    {
        public static Random rnd = new Random();
        public Corredor()
        {
            this.Nome = "";

        }

        public Corredor(String nome)
        {
            this.Nome = nome;

        }

        private String nome;

        public String Nome
        {
            get { return this.nome; }
            set
            {
                this.nome = value.ToLower();
                if (value.Length > 999) this.nome = value[0].ToString().ToLower();
                if (value.Length == 0) this.nome = "nn";
            }
        }

        public int Correr()
        {
            return Corredor.rnd.Next(1, 10);
        }

    }
}
