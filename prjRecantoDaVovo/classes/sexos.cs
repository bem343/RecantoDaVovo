using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjRecantoDaVovo.classes
{
    class sexos : banco
    {
        private List<sexo> lista = null;

        public List<sexo> Listar()
        {
            string nomeSP = "selecionaSexos";
            MySqlDataReader dados = null;
            if(Selecionar(nomeSP, null, ref dados))
            {
                if (dados != null)
                {
                    if (dados.HasRows)
                    {
                        while (dados.Read())
                        {
                            int codigo = int.Parse(dados[0].ToString());
                            string nome = dados[1].ToString();
                            sexo sexo = new sexo(codigo, nome);
                            lista.Add(sexo);
                        }
                    }
                }
            } return lista;
        }
    }
}
