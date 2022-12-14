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
        private List<crianca> lista = new List<crianca>();

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
                            string nome = null;
                            string roupa = null;
                            int sapato = 0;
                            DateTime nascimento = DateTime.Parse("01/01/0001");
                            string nome_sexo = null;
                            int codigoSexo = -1;

                            if (dados[1].ToString() != "") { nome = dados[1].ToString(); }                         
                            if (dados[2].ToString() != "") { roupa = dados[2].ToString(); }                            
                            if (dados[3].ToString() != "") { sapato = int.Parse(dados[3].ToString()); }                            
                            if (dados[4].ToString() != "") { nascimento = DateTime.Parse(dados[4].ToString()); }
                            bool participacao = dados[5].ToString() == "1"?true:false;                            
                            if (dados[6].ToString() != "") 
                            { 
                                nome_sexo = dados[6].ToString();
                                if (nome_sexo == "Feminino") { codigoSexo = 1; }
                                else { codigoSexo = 0; }
                            }
                            sexo sexo = new sexo(codigoSexo, nome_sexo);
                            crianca crianca = new crianca(codigo, nome, roupa, sapato, nascimento, participacao, sexo);
                            lista.Add(crianca);
                        } 
                    }
                }
            }
            fechaDados(dados);
            fechaConexao(); return lista;
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
                            responsavel responsavel = new responsavel(null, nome_responsavel, null, null);
                            crianca crianca = new crianca(nome_crianca, responsavel, sapato_crianca, roupa_crianca, sexo);
                            lista.Add(crianca);
                        }
                    }
                }
            }
            fechaDados(dados);
            fechaConexao(); return lista;
        }
    }
}
