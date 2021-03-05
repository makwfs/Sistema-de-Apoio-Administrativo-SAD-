using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaMysql.Model;
using System.IO;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using SistemaMysql;
using SistemaMysql.DAO;
using SistemaMysql.Entidades;
using SistemaMysql.View;
using MySql.Data.MySqlClient;
using SistemaMysql.Cache;



namespace SistemaMysql.View
{


    public partial class TelaRecuperarSenha : Form
    {
        UsuarioModel model = new UsuarioModel();
       // MySqlCommand sql;
        Conexao con = new Conexao();
       // private MailMessage Email;
        Stopwatch Stop = new Stopwatch();


        public TelaRecuperarSenha()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
           

            /* Email = new MailMessage();
             Email.To.Add(new MailAddress(txtRecuperarEmail.Text));
             Email.From = new MailAddress(txtEnviarEmail.Text);
             Email.Subject = txbObservacao.Text;
             Email.IsBodyHtml = true;
             Email.Body = txbObservacao.Text;
             SmtpClient cliente = new SmtpClient("smtp.gmail.com", 587);
             using (cliente)
             {
                 cliente.Credentials = new System.Net.NetworkCredential(txtEnviarEmail.Text, txtSenha.Text);
                 cliente.EnableSsl = true;
                 cliente.Send(Email);
             }
             MessageBox.Show("Email enviado");

             /*var user = new UsuarioModel();
             var resultado = user.RecuperarSenha(txtRecuperarEmail.Text);
             lblResultado.Text = resultado;*/


        }

        public void CadastroPc(User userRequestig)     // capturando dados dos textbox
        {

            /*
            try
            {
                userRequestig.EMAIL = txtRecuperarEmail.Text;
              


              //  UsuarioModel.RecuperarSenha();
             
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar " + ex.Message);
            }*/
        }

    }
}
