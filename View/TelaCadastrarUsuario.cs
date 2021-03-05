using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaMysql.Entidades;
using SistemaMysql.Model;

namespace SistemaMysql.View
{
    public partial class TelaCadastrarUsuario : Form
    {
        UsuarioModel model = new UsuarioModel();

        public TelaCadastrarUsuario()
        {
            InitializeComponent();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtRE.Text == "DIGITE SEU RE")
            {
                txtRE.Text = "";
                txtRE.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtRE.Text == "")
            {
                txtRE.Text = "DIGITE SEU RE";
                txtRE.ForeColor = Color.Silver;
            }
        }

        private void SenhaCadastrar_Enter(object sender, EventArgs e)
        {
            if (txtSenhaCadastrar.Text == "DIGITE SUA SENHA")
            {
                txtSenhaCadastrar.Text = "";
                txtSenhaCadastrar.ForeColor = Color.LightGray;
                txtSenhaCadastrar.UseSystemPasswordChar = true;
            }
        }

        private void txtSenhaCadastrar_Leave(object sender, EventArgs e)
        {
            if (txtSenhaCadastrar.Text == "")
            {
                txtSenhaCadastrar.Text = "DIGITE SUA SENHA";
                txtSenhaCadastrar.ForeColor = Color.LightGray;
                txtSenhaCadastrar.UseSystemPasswordChar = false;
            }
        }

        private void txtConfirmarSenha_Enter(object sender, EventArgs e)
        {
            if (txtConfirmarSenha.Text == "CONFIRME SUA SENHA")
            {
                txtConfirmarSenha.Text = "";
                txtConfirmarSenha.ForeColor = Color.LightGray;
                txtConfirmarSenha.UseSystemPasswordChar = true;
            }
        }

        private void txtConfirmarSenha_Leave(object sender, EventArgs e)
        {
            if (txtConfirmarSenha.Text == "")
            {
                txtConfirmarSenha.Text = "CONFIRME SUA SENHA";
                txtConfirmarSenha.ForeColor = Color.LightGray;
                txtConfirmarSenha.UseSystemPasswordChar = false;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "DIGITE SEU E-MAIL")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.LightGray;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "DIGITE SEU E-MAIL";
                txtEmail.ForeColor = Color.LightGray;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void TelaCadastrarUsuario_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            User dado = new User();
            if (txtNome.Text != "DIGITE SEU NOME:")
            {
                if (txtEmail.Text != "DIGITE SEU E-MAIL")
                {
                    if (txtRE.Text != "DIGITE SEU RE")
                    {
                        if (txtSenhaCadastrar.Text != "DIGITE SUA SENHA")
                        {
                            if (txtConfirmarSenha.Text != "CONFIRME SUA SENHA")
                            {
                                if (txtSenhaCadastrar.Text == txtConfirmarSenha.Text)
                                {
                                    CadastroUsuario(dado);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show(" As senhas não sao iguais! \n verifique e tente novamente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else msgErro4("Confirme sua Senha!");
                        }
                        else msgErro3("Insira sua Senha !");
                    }
                    else msgErro2("Insira seu RE !");
                }
                else msgErro1("Insira seu E-mail !");

            }
            else msgErro5("Insira seu Nome !");


         
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "DIGITE SEU NOME:";
            txtEmail.Text = "DIGITE SEU E-MAIL";
            txtRE.Text = "DIGITE SEU RE";
            txtSenhaCadastrar.Text = "DIGITE SUA SENHA";
            txtConfirmarSenha.Text = "CONFIRME SUA SENHA";
            lbErro.Visible = false;
            lbErroRE.Visible = false;
            lbErroSenha.Visible = false;
            lbErroConfSenha.Visible = false;
            lbErroNome.Visible = false;
            txtConfirmarSenha.UseSystemPasswordChar = false;
            txtSenhaCadastrar.UseSystemPasswordChar = false;


        }

        private void msgErro1(string msg)
        {
            lbErro.Text = "" + msg;
            lbErro.Visible = true;
        }

        private void msgErro2(string msg)
        {
            lbErroRE.Text = "" + msg;
            lbErroRE.Visible = true;
        }

        private void msgErro3(string msg)
        {
            lbErroSenha.Text = "" + msg;
            lbErroSenha.Visible = true;
        }

        private void msgErro4(string msg)
        {
            lbErroConfSenha.Text = "" + msg;
            lbErroConfSenha.Visible = true;
        }

        private void msgErro5(string msg)
        {
            lbErroNome.Text = "" + msg;
            lbErroNome.Visible = true;
        }

        public void CadastroUsuario(User dado)     // capturando dados dos textbox
        {


            try
            {

                dado.Nome = txtNome.Text;
                dado.EMAIL = txtEmail.Text;
                dado.RE = txtRE.Text;
                dado.Senha = txtSenhaCadastrar.Text;
                


                model.CadastroUsuarios(dado);
                txtNome.Text = "DIGITE SEU NOME:";
                txtEmail.Text = "DIGITE SEU E-MAIL";
                txtSenhaCadastrar.Text = "DIGITE SUA SENHA";
                txtRE.Text = "DIGITE SEU RE";
                txtConfirmarSenha.Text = "CONFIRME SUA SENHA";
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar " + ex.Message);
            }
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            if (txtNome.Text == "DIGITE SEU NOME:")
            {
                txtNome.Text = "";
                txtNome.ForeColor = Color.LightGray;
            }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                txtNome.Text = "DIGITE SEU NOME:";
                txtNome.ForeColor = Color.LightGray;
            }
        }
    }
}



