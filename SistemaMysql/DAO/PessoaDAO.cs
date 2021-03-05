using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace SistemaMysql.DAO
{
    public class PessoaDAO
    {
        string conexao = @"server=localhost; database=pimviii; uid=root@localhost; pwd=;"; // conexão com o BD
        MySqlConnection con = null;
        MySqlCommand  sql;

        public DataTable Listar()
        {
            try                                                      // Usar o try para caso ocorra algum erro
            {
                con = new MySqlConnection(conexao);
                sql = new MySqlCommand("select * from pessoas", con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
