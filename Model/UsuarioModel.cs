using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaMysql.Entidades;
using SistemaMysql.DAO;
using System.Windows.Forms;
using SistemaMysql.Cache;


namespace SistemaMysql.Model
{
    public  class UsuarioModel
    {
        UsuarioDao dao = new UsuarioDao();

        public User Login(User dados)
        {
            try
            {
                return dao.Login(dados);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void CadastroUsuarios(User dados)
        {

            try
            {
                dao.CadastroUsuarios(dados);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao cadastrar MODEL" + ex); 
            }
        }

        public void CtrAcesso()
        {
            if (UserLoginCache.Função == UserFunção.P1)
            {

            }
            else if (UserLoginCache.Função == UserFunção.P2)
            {

            }
            else if (UserLoginCache.Função == UserFunção.P3)
            {

            }
            else if (UserLoginCache.Função == UserFunção.P4)
            {

            }
            else if (UserLoginCache.Função == UserFunção.P5)
            {

            }
            else if (UserLoginCache.Função == UserFunção.GUARDA)
            {

            }
            else if (UserLoginCache.Função == UserFunção.RESERVADEARMAS)
            {

            }
            else if (UserLoginCache.Função == UserFunção.TELEMATICA)
            {

            }
        }

        public void RecuperarSenha(string userRequesting)
        {
             dao.RecuperarSenha(userRequesting);
        }

       

    }

}
