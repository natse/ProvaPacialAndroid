using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace PlanoDeSaudeDoFrancisco.DAO
{
    internal class Conexao
    {
        internal int Crud(SqlCommand comando)
        {
            SqlConnection  con = Conectar();
            comando.Connection = con;
            int id = Convert.ToInt32(comando.ExecuteScalar());
            con.Close();
            return id;
        }
        public SqlConnection Conectar()
        {
            string stringConexao = ConfigurationManager.ConnectionStrings["ConLaboratorio"].ConnectionString;
            SqlConnection conexao = new SqlConnection(stringConexao);
            conexao.Open();
            return conexao;
        }

        public  SqlDataReader Selecionar(SqlCommand comando)
            {
            SqlConnection con = Conectar();
            comando.Connection = con;
            SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
            }
        
       
    }
}