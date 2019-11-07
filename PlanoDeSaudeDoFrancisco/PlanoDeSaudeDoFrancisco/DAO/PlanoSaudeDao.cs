using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanoDeSaudeDoFrancisco.Model;



namespace PlanoDeSaudeDoFrancisco.DAO
{
    class PlanoSaudeDao
    {
        

        public IList<PlanoSaude> BuscaTodos()
        {
            IList<PlanoSaude> listaPlanos = new List<PlanoSaude>();
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM PlanoDeSaude";
            Conexao con = new Conexao();
            SqlDataReader dr = con.Selecionar(comando);
            if (dr.HasRows)
            {
                while(dr.Read())
                {
                    PlanoSaude p = new PlanoSaude();
                    p.Id = (int)dr["planoDeSaude"];
                    p.Nome = (string)dr["descricao"];
                    listaPlanos.Add(p);

                }
            }
            else
            {
                listaPlanos = null;
            }
            dr.Close();
            return listaPlanos;
            
        }
        internal void Insert(PlanoSaude p)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "INSERT INTO PlanoDeSaude (descricao) VALUES (@descricao)";
            comando.Parameters.AddWithValue("@descricao", p.Nome);

            Conexao con = new Conexao();
            con.Crud(comando);
        }
    }
}
