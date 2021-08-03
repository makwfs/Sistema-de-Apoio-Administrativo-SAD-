using SistemaMysql.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SistemaMysql;
using SistemaMysql.Model;
using SistemaMysql.Entidades;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace SistemaMysql.View
{
    public partial class ErroEntradaControleAcesso : Form
    {

        MySqlCommand sql;
        Conexao con = new Conexao();
        ControleAcesso rst; // Construtor para limpar campos do form principal
        public ErroEntradaControleAcesso()
        {
            InitializeComponent();
        }
        public ErroEntradaControleAcesso(String Valor, ControleAcesso Reset)
        {
            InitializeComponent();
            //RECUPERANDO VALORES DO FORM CONTROLE DE ACESSO
            ID.Text = Valor;
            rst = Reset; // Construtor para limpar campos do form principal
        }

        //FECHAR FORM AO APERTAR ESC
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                this.Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }



        private void ErroEntradaControleAcesso_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Close();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {


            try
            {

                con.Conectar();
                sql = new MySqlCommand("UPDATE status SET STATUS = @STATUS WHERE ID = @ID", con.con);   // comando para editar dados no BD

                sql.Parameters.AddWithValue("@ID", ID.Text);
                sql.Parameters.AddWithValue("@STATUS", STATUS.Text);

                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao editar" + ex);
                con.FecharConexao();
            }
            MessageBox.Show("SAÍDA CADASTRADA!");
            rst.ReloadForm();// Construtor para limpar campos do form principal
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ErroEntradaControleAcesso_Load(object sender, EventArgs e)
        {


            STATUS.Text = "DESCANSANDO";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ErroEntradaControleAcesso_FormClosed(object sender, FormClosedEventArgs e)
        {
            rst.ReloadForm();// Construtor para limpar campos do form principal
        }
    }
}
