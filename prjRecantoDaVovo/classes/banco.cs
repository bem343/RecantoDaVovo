using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;

namespace prjRecantoDaVovo.classes
{
	public class banco
    {

        #region Variáveis
            private string linhaConexao = "";
            private MySqlConnection conexao = null;
            private MySqlCommand cSQL = null;
        #endregion

        #region Métodos

            #region Fechar Dados
                public void fechaDados(MySqlDataReader dados)
                {
                    if (!dados.IsClosed) { dados.Close(); };
                }
            #endregion

            #region Fechar Conexão
                public void fechaConexao()
                {
                    if (conexao.State == ConnectionState.Open) { conexao.Close(); }
                }
            #endregion

            #region Conectar ao Banco
                private void conexaoBanco()
                {
                    conexao = new MySqlConnection(linhaConexao);
                }
            #endregion

            #region Abrir banco
                private bool abrirBanco()
                {
                    try{
                        conexao.Open();
                    }
                    catch{
                        return false;
                    }
                    return true;
                }
            #endregion

        #endregion

        #region Contrutor
            public banco()
            {
                linhaConexao = execucao.getConexao();
            }
        #endregion

        #region Selecionar
            public bool Selecionar(string nomeSP, string[,] args, ref MySqlDataReader dados)
            {
                try
                {
                    conexaoBanco();
                    if (!abrirBanco())
                    {
                        return false;
                    }

                    cSQL = new MySqlCommand(nomeSP, conexao);
                    cSQL.CommandType = CommandType.StoredProcedure;
                    cSQL.Parameters.Clear();
                    if (args != null)
                    {
                        for (int i = 0; i < args.Length / 2; i++)
                        {
                            cSQL.Parameters.Add(new MySqlParameter(args[i, 0], args[i, 1]));
                        }
                    }
                    dados = cSQL.ExecuteReader();
                    return true;
                }
                catch
                {
                    fechaDados(dados);
                    fechaConexao();
                    return false;
                }
            }
        #endregion

        #region Executar
            public bool Executar(string nomeSP, string[,] args)
            {
                try
                {
                    conexaoBanco();
                    if (!abrirBanco())
                    {
                        return false;
                    }
                    cSQL = new MySqlCommand(nomeSP, conexao);
                    cSQL.CommandType = CommandType.StoredProcedure;
                    cSQL.Parameters.Clear();
                    if(args != null)
                    {
                        for (int i = 0; i < args.Length / 2; i++)
                        {
                            cSQL.Parameters.Add(new MySqlParameter(args[i, 0], args[i, 1]));
                        }
                    }
                    cSQL.ExecuteNonQuery();
                    fechaConexao();
                    return true;
                }
                catch
                {
                    fechaConexao();
                    return false;
                }
            }
        #endregion

    }
}