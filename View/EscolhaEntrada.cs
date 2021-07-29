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
using System.Data.SqlClient;
using System.Windows.Controls;
using SistemaMysql.Entidades;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;   // Biblioteca para arrastar tela

namespace SistemaMysql.View
{
    public partial class EscolhaEntrada : Form
    {
       
        ControleAcesso esc; // Construtor para buscar form principal
        public EscolhaEntrada()
        {
            InitializeComponent();
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
        public EscolhaEntrada(String Valor, ControleAcesso Escolha)
        {
            InitializeComponent();
            //RECUPERANDO VALORES DO FORM CONTROLE DE ACESSO            
            esc = Escolha; // Construtor para buscar form principal

        }


        private void EscolhaEntrada_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Esc(object sender, KeyPressEventArgs e)
        {
            this.Close();
        }

        private void EscolhaEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            esc.CadastrarEntradaVeiculo();
            this.Close();
            
        }

        private void EscolhaEntrada_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            esc.CadastrarEntradaaPe();
            this.Close();
        }
    }
}
