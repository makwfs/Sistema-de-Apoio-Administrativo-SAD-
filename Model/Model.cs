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
    public class Model  // Camada 2
    {
		public bool tem;
        DAO.DAO dao = new DAO.DAO();              // acessar os metodos de DAO
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

        public DataTable ListarImpressora()
        {

            try                                       // Utilizar o try pra caso ocorra o erro ele retorne
            {

                DataTable dt = new DataTable();
                dt = dao.ListarImpressora();
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable ListarVtr()
        {

            try                                       // Utilizar o try pra caso ocorra o erro ele retorne
            {

                DataTable dt = new DataTable();
                dt = dao.ListarVtr();
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable ListarRadio()
        {

            try                                       // Utilizar o try pra caso ocorra o erro ele retorne
            {

                DataTable dt = new DataTable();
                dt = dao.ListarRadio();
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable ListarUsuario()
        {

            try                                       // Utilizar o try pra caso ocorra o erro ele retorne
            {

                DataTable dt = new DataTable();
                dt = dao.ListarUsuario();
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

        public void CadastroRadio(Pessoas dados)
        {

            try
            {
                dao.CadastroRadio(dados);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar" + ex);
            }
        }

        public void CadastroImpressora(Pessoas dados)
        {

            try
            {
                dao.CadastroImpressora(dados);

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

        public void CadastroVtr(Pessoas dados)
        {

            try
            {
                dao.CadastroVtr(dados);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar" + ex);
            }
        }
        public void CadastroControleAcesso(Pessoas dados)
        {

            try
            {
                dao.CadastroControleAcesso(dados);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar" + ex);
            }
        }

        public void ENTRADAControleAcesso(Pessoas dados)
        {

            try
            {
                dao.ENTRADAControleAcesso(dados);

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

        public void EditarDadosPc(Pessoas dados)
        {
            try
            {
                dao.EditarDadosPc(dados);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Editar" + ex);
            }
        }

        public void EditarDadosRadio(Pessoas dados)
        {
            try
            {
                dao.EditarDadosRadio(dados);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Editar" + ex);
            }
        }

        public void EditarUsuario(User dado)
        {
            try
            {
                dao.EditarUsuario(dado);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Editar" + ex);
            }
        }

        public void EditarDadosImpressora(Pessoas dados)
        {
            try
            {
                dao.EditarDadosImpressora(dados);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Editar" + ex);
            }
        }


        public void EditarVtr(Pessoas dados)
        {
            try
            {
                dao.EditarVtr(dados);

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

        public void ExcluirVtr(Pessoas dados)
        {
            try
            {
                dao.ExcluirVtr(dados);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Excluir!" + ex);
            }
        }

        public void ExcluirRadio(Pessoas dados)
        {
            try
            {
                dao.ExcluirRadio(dados);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Excluir!" + ex);
            }
        }

        public void ExcluirUsuario(Pessoas dados)
        {
            try
            {
                dao.ExcluirUsuario(dados);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Excluir!" + ex);
            }
        }

        public void ExcluirTodos(Pessoas dados)
        {
            try
            {
                dao.ExcluirTodos(dados);
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

        public object PesquisarUsuario(User dado)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.PesquisarUsuario(dado);
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

        public object PesquisarImpressora(Pessoas dados)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.PesquisarImpressora(dados);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public object PesquisarVtr(Pessoas dados)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.PesquisarVtr(dados);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public object PesquisarRadio(Pessoas dados)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.PesquisarRadio(dados);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
