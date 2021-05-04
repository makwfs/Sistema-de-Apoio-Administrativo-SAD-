using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMysql
{
    public  class Conexao
    {
        private string conexao = "server=localhost; database=sad; uid=root; pwd=;"; //  BD LOCAL HOST   conexão de principal
        public MySqlConnection con = null;
       

        public void Conectar()                           
        {
            try
            {
                con = new MySqlConnection(conexao);
                con.Open();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }


        public void FecharConexao()
        {
            try
            {
                con = new MySqlConnection(conexao);
                con.Close();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

    

    }
}
