using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjRecantoDaVovo.classes
{
    class responsavel : banco
    {
        public string cpf { get; set; }
        public string nome { get; set; }
        public string cel { get; set; }
        public string endereco { get; set; }

        public responsavel(string cpf, string nome, string cel, string endereco):base()
        {
            this.cpf = cpf;
            this.nome = nome;
            this.cel = cel;
            this.endereco = endereco;
        }
		public responsavel(string cpf) : base()
		{
			this.cpf = cpf;
		}

		public bool Verificar()
        {
            string nomeSP = "verificaResponsavel";
            MySqlDataReader dados = null;
            string[,] args = new string[1,2];
            args[0,0] = "vCpf";
            args[0,1] = cpf;
            if (Selecionar(nomeSP, args, ref dados))
            {
                if (dados != null)
                {
                    if (dados.HasRows)
                    {
                        while (dados.Read())
                        {
                            this.nome = dados[0].ToString();
                            this.cel = dados[1].ToString();
                            this.endereco = dados[2].ToString();
                        } return true;
                    } 
                }
            } return false;
        }

        public bool Inserir()
        {
            string nomeSP = "criaResponsavel";
            string[,] args = new string[1,2];
            args[0, 0] = "vCpf";
            args[0, 1] = this.cpf;
            return Executar(nomeSP, args);
        }

        public bool Atualiza()
        {
            string nomeSP = "atualizaResponsavel";
            string[,] args = new string[4,2];

            args[0, 0] = "vNome";
            args[0, 1] = this.nome;
            args[1, 0] = "vCel";
            args[1, 1] = this.cel;
            args[2, 0] = "vEndereco";
            args[2, 1] = this.endereco;
            args[3, 0] = "vCpf";
            args[3, 1] = this.cpf;

            return Executar(nomeSP, args);
        }
    }
}
