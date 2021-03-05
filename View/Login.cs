using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaMysql;
using System.Runtime.InteropServices;   // biblioteca para arrastar tela
using SistemaMysql.Entidades;
using SistemaMysql.Model;

namespace SistemaMysql.View
{
    public partial class Login : Form
    {
        UsuarioModel model = new UsuarioModel();

        public Login()
        {
            InitializeComponent();
        }

        //Arrastar janela
        [DllImport ("user32.DLL", EntryPoint = "ReleaseCapture")] 
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtRE.Text == "RE")
            {
                txtRE.Text = "";
                txtRE.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtRE.Text == "") 
            {
                txtRE.Text = "RE";
                txtRE.ForeColor = Color.Silver;
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "SENHA")
            {
                txtSenha.Text = "";
                txtSenha.ForeColor = Color.LightGray;
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "SENHA";
                txtSenha.ForeColor = Color.Silver;
                txtSenha.UseSystemPasswordChar = false;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            User dado = new User();
            LoginUser(dado);
        }

        private void msgErro(string msg)
        {
            lbErro.Text = "          " + msg;
            lbErro.Visible = true;
        }

        private void logout(object sender, FormClosedEventArgs e)
        {
            txtRE.Text = "RE";
            txtSenha.Text = "SENHA";
            txtSenha.UseSystemPasswordChar = false;
            lbErro.Visible = false;
            this.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaRecuperarSenha form = new TelaRecuperarSenha();
            form.Show();
        }

        public void LoginUser(User dado)
        {
            try
            {
                if (txtRE.Text != "RE")
                {
                    if (txtSenha.Text != "SENHA")
                    {
                        dado.RE = txtRE.Text;
                        dado.Senha1 = txtSenha.Text;

                        dado = model.Login(dado);

                        if (dado.RE == null)
                        {
                            msgErro("Login ou Senha incorretos \n        verifique e tente novamente !");
                            txtSenha.Clear();
                            txtRE.Focus();
                            return;
                        }

                        TelaInicial form = new TelaInicial();
                        form.Show();
                        form.FormClosed += logout;
                        this.Hide();
                        
                    }
                    else msgErro("Insira sua Senha !");


                }
                else msgErro("Insira seu RE !");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Logar" + ex);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaCadastrarUsuario form = new TelaCadastrarUsuario();
            form.Show();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }



}
