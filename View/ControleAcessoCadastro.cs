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
using System.Runtime.InteropServices;   // Biblioteca para arrastar tela

namespace SistemaMysql.View
{
    public partial class ControleAcessoCadastro : Form
    {
        Model.Model model = new Model.Model();
        public ControleAcessoCadastro()
        {
            InitializeComponent();
        }


        private void ControleAcessoBtnCadastrar_Click(object sender, EventArgs e)
        {
            Pessoas dado = new Pessoas();
            CadastroControleAcesso(dado);
        }

        public void CadastroControleAcesso(Pessoas dados)     // capturando dados dos textbox
        {


            try
            {
                dados.NomeControleAcesso = NOME.Text;
                dados.REControleAcesso1 = TXBRE.Text;
                dados.POSTOGRADControleAcesso1 = CBPOSTOGRAD.Text;
                dados.TXBRGControleAcesso1 = TXBRG.Text;
                dados.UNIDADEControleAcesso1 = UNIDADE.Text;
                dados.CIAControleAcesso1 = CBCIA.Text;
                dados.SECAOControleAcesso1 = CBSECAO.Text;
                dados.NCARTAOontroleAcesso1 = NCARTAO.Text;
                dados.VENCIMENTOControleAcesso1 = DATAVENCIMENTO.Text;
                dados.MARCAControleAcesso1 = TXBMARCA.Text;
                dados.MODELOControleAcesso1 = MODELOVEICULO.Text;
                dados.EMPLACAMENTOControleAcesso1 = EMPLACAMENTO.Text;
                dados.CIDADEControleAcesso1 = CIDADE.Text;
                dados.CORControleAcesso1 = COR.Text;
                dados.DATA1 = DATA.Text;
                dados.HORA1 = HORA.Text;


                model.CadastroControleAcesso(dados);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar " + ex.Message);
            }
        }

        private void DATA_TextChanged(object sender, EventArgs e)
        {
            string Date = DateTime.Now.ToString("dd-MM-yyyy");
            Console.WriteLine("The Current Date Without Time is {0}.", Date);
            //DATA.Text == Date;
        }

        private void ControleAcessoCadastro_Load(object sender, EventArgs e)
        {
            DATAATUAL.Text = DateTime.Now.ToString("dd/MM/yyyy");            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            HORAATUAL.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
