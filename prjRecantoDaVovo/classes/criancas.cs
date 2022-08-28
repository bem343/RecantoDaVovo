using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace prjRecantoDaVovo.classes
{
    class criancas : banco
    {
        private List<crianca> lista = null;

        public List<crianca> Listar(string cpf)
        {
            string nomeSP = "selecionaCrianca";
            MySqlDataReader dados = null;
            string[,] args = new string[1,2];
            args[0, 0] = "vCpf";
            args[0, 1] = cpf;

            if (Selecionar(nomeSP, args, ref dados))
            {
                if (dados != null)
                {
                    if (dados.HasRows)
                    {
                        while (dados.Read())
                        {
                            int codigo = int.Parse(dados[0].ToString());
                            string nome = dados[1].ToString();
                            string roupa = dados[2].ToString();
                            int sapato = int.Parse(dados[3].ToString());
                            DateTime nascimento = DateTime.Parse(dados[4].ToString());
                            bool participacao = bool.Parse(dados[5].ToString());
                            string nome_sexo = dados[6].ToString();

                            sexo sexo = new sexo(nome_sexo);
                            crianca crianca = new crianca(codigo, nome, roupa, sapato, nascimento, participacao, sexo);
                            lista.Add(crianca);
                        } 
                    }
                }
            }return lista;
        }

        public List<crianca> Convidadas()
        {
            string nomeSP = "gerarLista";
            MySqlDataReader dados = null;

            if (Selecionar(nomeSP, null, ref dados))
            {
                if (dados != null)
                {
                    if (dados.HasRows)
                    {
                        while (dados.Read())
                        {
                            string nome_crianca = dados[0].ToString();
                            string nome_responsavel = dados[1].ToString();
                            int sapato_crianca = int.Parse(dados[2].ToString());
                            string roupa_crianca = dados[3].ToString();
                            string nome_sexo = dados[4].ToString();

                            sexo sexo = new sexo(nome_sexo);
                            responsavel responsavel = new responsavel(nome_responsavel);
                            crianca crianca = new crianca(nome_crianca, responsavel, sapato_crianca, roupa_crianca, sexo);
                            lista.Add(crianca);
                        }
                    }
                }
            } return lista;
        }
    }
}
