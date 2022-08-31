using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjRecantoDaVovo.classes
{
    class crianca : banco
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public string roupa { get; set; }
        public int sapato { get; set; }
        public DateTime nascimento { get; set; }
        public bool participacao { get; set; }
        public responsavel responsavel { get; set; }
        public sexo sexo { get; set; }

        public crianca(int codigo, string nome, string roupa, int sapato, DateTime nascimento, bool participacao, sexo sexo):base()
        {
            this.codigo = codigo;
            this.nome = nome;
            this.roupa = roupa;
            this.sapato = sapato;
            this.nascimento = nascimento;
            this.participacao = participacao;
            this.sexo = sexo;
        }

        public crianca(string nome, responsavel responsavel, int sapato, string roupa, sexo sexo):base()
        {
            this.nome = nome;
            this.responsavel = responsavel;
            this.sapato = sapato;
            this.roupa = roupa;
            this.sexo = sexo;
        }

        public crianca(int codigo):base()
        {
            this.codigo = codigo;
        }

        public crianca():base()
        { }

        public bool Inserir(string cpf)
        {
            string nomeSP = "criaCrianca";
            string[,] args = new string[1,2];

            args[0, 0] = "vCpf";
            args[0, 1] = cpf;

            return Executar(nomeSP, args);
        }

        public bool Atualiza(string cpf)
        {
            string nomeSP = "atualizaCrianca";
            string[,] args = new string[8,2];

            args[0, 0] = "vNome";
            args[0, 1] = this.nome;
            args[1, 0] = "vRoupa";
            args[1, 1] = this.roupa;
            args[2, 0] = "vSapato";
            args[2, 1] = this.sapato.ToString();
            args[3, 0] = "vNascimento";
            args[3, 1] = dataFormatada();
            args[4, 0] = "vParticipacao";
            args[4, 1] = this.participacao == true?"1":"0";
            args[5, 0] = "vSexo";
            args[5, 1] = this.sexo.codigo.ToString();
            args[6, 0] = "vCodigo";
            args[6, 1] = this.codigo.ToString();
            args[7, 0] = "vCpf";
            args[7, 1] = cpf;

            return Executar(nomeSP, args);
        }

        private string dataFormatada()
        {
            int dia = this.nascimento.Day;
            int mes = this.nascimento.Month;
            int ano = this.nascimento.Year;
            
            string penis = ano + "-";

            if (mes <= 9)
            { penis += "0" + mes + "-"; }
            else { penis += mes + "-"; }

            if (dia <= 9)
            { penis += "0" + dia; }
            else { penis += dia; }
            
            return penis;
        }
    }

    
}
