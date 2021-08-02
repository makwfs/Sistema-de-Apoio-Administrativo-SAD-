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
    public partial class EscolhaSaida : Form
    {
        ControleAcesso esc; // Construtor para buscar form principal
        public EscolhaSaida()
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

        public EscolhaSaida(String Valor, ControleAcesso Escolha)
        {
            InitializeComponent();
            //RECUPERANDO VALORES DO FORM CONTROLE DE ACESSO            
            esc = Escolha; // Construtor para buscar form principal

        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            esc.CadastrarSaidaVeiculo();
            this.Close();
        }
    }
}
