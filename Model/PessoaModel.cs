using SistemaMysql.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SistemaMysql.Entidades;
using SistemaMysql;
using System.Windows.Forms;

namespace SistemaMysql.Model
{
    public class PessoaModel  // Camada 2
    {
		public bool tem;
        PessoaDAO dao = new PessoaDAO();              // acessar os metodos de DAO
		public String mensagem = "";

        

		public DataTable Listar()
        {

			try                                       // Utilizar o try pra caso ocorra o erro ele retorne
			{

				DataTable dt = new DataTable();
				dt = dao.Listar();
				return dt;
			}
			catch (Exception )
			{

				throw;
			}
		}

        public DataTable ListarTmd()
        {

            try                                       // Utilizar o try pra caso ocorra o erro ele retorne
            {

                DataTable dt = new DataTable();
                dt = dao.ListarTmd();
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable ListarPc()
        {

            try                                       // Utilizar o try pra caso ocorra o erro ele retorne
            {

                DataTable dt = new DataTable();
                dt = dao.ListarPc();
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable ListarTodos()
        {

            try                                       // Utilizar o try pra caso ocorra o erro ele retorne
            {

                DataTable dt = new DataTable();
                dt = dao.ListarTodos();
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public void CadastroTmd(Pessoas dados)
        {

            try
            {
                dao.CadastroTmd(dados);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar" + ex);
            }
        }

        public void CadastroPc(Pessoas dados)
        {

            try
            {
                dao.CadastroPc(dados);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar" + ex);
            }
        }


        public void EditarDadosTmd(Pessoas dados)
        {
            try
            {
                dao.EditarDadosTmd(dados);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Editar" + ex);
            }
        }

        public void ExcluirTmd(Pessoas dados)
        {
            try
            {
                dao.ExcluirTmd(dados);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Excluir!" + ex);
            }
        }

        public void ExcluirPc(Pessoas dados)
        {
            try
            {
                dao.ExcluirPc(dados);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Excluir!" + ex);
            }
        }

        public object PesquisarTmd(Pessoas dados)
        {
            try                                       
            {
                DataTable dt = new DataTable();
                dt = dao.PesquisarTmd(dados);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public object PesquisarPc(Pessoas dados)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.PesquisarPc(dados);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
