using MySql.Data.MySqlClient;
using SistemaMysql.Entidades;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaMysql.Cache;
using System.Data;
using SistemaMysql;
using System.IO;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;



namespace SistemaMysql.DAO
{
    public class UsuarioDao 
    {
        MySqlCommand sql;
        Conexao con = new Conexao();

        private MailMessage Email;
        Stopwatch Stop = new Stopwatch();

        public User Login(User dado)
        {
            try                                                                                                               // Usar o try para caso ocorra algum erro
            {
                con.Conectar();
                sql = new MySqlCommand("select * from usuarios where RE = @RE AND Senha = @Senha", con.con);                                  // Verificar se RE e Senha conferem no BD para realizar login
                sql.Parameters.AddWithValue("@RE", dado.RE);
                sql.Parameters.AddWithValue("@Senha", dado.Senha1);
                MySqlDataReader dr;
                dr = sql.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        UserLoginCache.Nome = dr.GetString(2);
                        UserLoginCache.Função = dr.GetString(5);
                    }

                    while (dr.Read())
                        dado.RE = Convert.ToString(dr["RE"]);
                    dado.RE = Convert.ToString(dr["Senha"]);
                }
                else
                {
                    dado.RE = null;
                    dado.Senha1 = null;
                }
                return dado;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public void CadastroUsuarios(User dados)
        {

            try
            {
                con.Conectar();
                sql = new MySqlCommand("INSERT INTO usuarios (RE,Nome,Senha,EMAIL,Função) values ( @RE,@nome,@Senha,@EMAIL, @Função)", con.con);  // inclusão de usuários no BD 

                sql.Parameters.AddWithValue("@Nome", dados.Nome);
                sql.Parameters.AddWithValue("@RE", dados.RE);
                sql.Parameters.AddWithValue("@Senha", dados.Senha);
                sql.Parameters.AddWithValue("@EMAIL", dados.EMAIL);
                sql.Parameters.AddWithValue("@Função", "SEM FUNÇÃO");
                sql.ExecuteNonQuery();
                MessageBox.Show("Salvo com Sucesso!");



            }
            catch (Exception ex)
            {
                //MessageBox.Show("            RE já cadastrado \n verifique e tente novamente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Erro ao cadastrar DAO" + ex);
                con.FecharConexao();
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



        public string RecuperarSenha(string userRequesting)
        {


            con.Conectar();
            sql = new MySqlCommand("select * from usuarios where Nome=@Nome or EMAIL=@EMAIL", con.con);  // 

            sql.Parameters.AddWithValue("@Nome", userRequesting);
            sql.Parameters.AddWithValue("@EMAIL", userRequesting);
            sql.CommandType = CommandType.Text;
            MySqlDataReader reader = sql.ExecuteReader();



            Email = new MailMessage();
            Email.To.Add(new MailAddress(reader.GetString(2)));
            Email.From = new MailAddress("suportesistemasad@gmail.com");
            Email.Subject = "RECUPERAÇÃO DE SENHA SAD";
            Email.IsBodyHtml = true;
            Email.Body = "Olá , você solicitou recuperar sua senha de acesso!\n";


            if (reader.Read() == true)
            {

                string Nome = reader.GetString(2);
                string EmailBD = reader.GetString(4);
                string Senha = reader.GetString(3);

                SmtpClient cliente = new SmtpClient("smtp.gmail.com", 587);
                using (cliente)
                {
                    cliente.Credentials = new System.Net.NetworkCredential("suportesistemasad@gmail.com", "S1st3m4S4d()");
                    cliente.EnableSsl = true;
                    cliente.Send(Email);
                }
                return "Olá " + Nome + ", você solicitou recuperar sua senha de acesso!\n" +
                       "Por favor confira seu E-mail:  " + EmailBD;
            }
            else
            {
                return "Desculpe, não consegui encontrar seu RE ou seu E-mail.\n" +
                        "Verifique os dados e tente novamente!";





            }
        }
    }
}
