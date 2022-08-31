using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjRecantoDaVovo.classes
{
    class sexo 
    {
        public int codigo { get; set; }
        public string nome { get; set; }

        public sexo(int codigo, string nome): base()
        {
            this.codigo = codigo;
            this.nome = nome;
        }

        public sexo(string nome) : base()
        {
            this.nome = nome;
        }

        public sexo(int codigo):base()
        {
            this.codigo = codigo;
        }
    }
}
