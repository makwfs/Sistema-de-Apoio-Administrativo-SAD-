using SistemaMysql.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaMysql.Model
{
    public class PessoaModel
    {
        PessoaDAO dao = new PessoaDAO();      // acessar os metodos de DAO

		public DataTable Listar()
        {

			try
			{
				DataTable dt = new DataTable();
				dt = dao.Listar();
				return dt;
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
    
    }
}
