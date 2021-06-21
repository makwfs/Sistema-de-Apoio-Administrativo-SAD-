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
    public partial class ControleAcesso : Form
    {
        Model.Model model = new Model.Model();
        MySqlCommand sql;
        Conexao con = new Conexao();
        public ControleAcesso()
        {
            InitializeComponent();
        }

        //Arrastar janela
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void button1_Click(object sender, EventArgs e)
        {
            ControleAcessoCadastro form = new ControleAcessoCadastro();
            form.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label16_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void RE_TextChanged(object sender, EventArgs e)
        {
            if (RE.Text !="")
            {
                RG.Enabled = false;
                CBCARTAO.Enabled = false;
                PREFIXO.Enabled = false;

            }
            else
            {
                RG.Enabled = true;
                CBCARTAO.Enabled = true;
                PREFIXO.Enabled = true;
            }

        }

        public void RetornoDadosAcesso(Pessoas dados)
        {


        }
        public void ENTRADAControleAcesso(Pessoas dados)     // capturando dados dos textbox
        {


            try
            {
                STATUS.Text = "TRABALHANDO";
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
                dados.DATA1 = DATAATUAL.Text;
                dados.HORA1 = HORAATUAL.Text;
                dados.Id = Convert.ToInt32(ID.Text);
                dados.STATUS1 = STATUS.Text;


                model.ENTRADAControleAcesso(dados);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar " + ex.Message);
            }
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            if (ID.Text == "")
            {
                MessageBox.Show("ERRO: DIGITE UMA IDENTIFICAÇÃO", "                                 CUIDADO !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (STATUS.Text == "TRABALHANDO") {
                MessageBox.Show("ATENÇÃO: A PESSOA JÁ SE ENCONTRA NO INTERIOR DO BATALHÃO", "                                 CUIDADO !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Pessoas dado = new Pessoas();
                ENTRADAControleAcesso(dado);
            }

        }

        private void ControleAcesso_Load(object sender, EventArgs e)
        {
            DATAATUAL.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            HORAATUAL.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnPESQUISAR_Click(object sender, EventArgs e)
        {
            ControleAcessoPesquisar form = new ControleAcessoPesquisar();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }



        private void RE_KeyPress(object sender, KeyPressEventArgs e)
        {

            try
            {
                con.Conectar();
                sql = new MySqlCommand("SELECT id,NOME, RE, POSTO, RG, UNIDADE, CIA, SEÇÃO, CARTÃO, VENCIMENTO," +
                    "MARCA, MODELO, EMPLACAMENTO, CIDADE, COR FROM entradacontroleacessoteste WHERE RE = ?", con.con);

                //TESTE INNER JOIN
                //SELECT* FROM entradacontroleacessoteste INNER JOIN entradasaida.STATUS ON entradacontroleacessoteste.id = entradasaida.fk_id_ES;
                //SELECT* FROM `entradacontroleacessoteste` inner JOIN entradasaida ON entradacontroleacessoteste.id = entradasaida.fk_id_ES;

                sql.Parameters.Clear();
                sql.Parameters.Add("@RE", MySqlDbType.Int32).Value = RE.Text;
                sql.CommandType = CommandType.Text;

                MySqlDataReader dr;
                dr = sql.ExecuteReader();
                dr.Read();

                ID.Text = dr.GetString(0);
                NOME.Text = dr.GetString(1);
                TXBRE.Text = dr.GetString(2);
                CBPOSTOGRAD.Text = dr.GetString(3);
                TXBRG.Text = dr.GetString(4);
                UNIDADE.Text = dr.GetString(5);
                CBCIA.Text = dr.GetString(6);
                CBSECAO.Text = dr.GetString(7);
                NCARTAO.Text = dr.GetString(8);
                DATAVENCIMENTO.Text = dr.GetString(9);
                TXBMARCA.Text = dr.GetString(10);
                MODELOVEICULO.Text = dr.GetString(11);
                EMPLACAMENTO.Text = dr.GetString(12);
                CIDADE.Text = dr.GetString(13);
                COR.Text = dr.GetString(14);



            }
            catch (Exception)
            {

            }
        }

        private void RG_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                con.Conectar();
                sql = new MySqlCommand("SELECT id,NOME, RE, POSTO, RG, UNIDADE, CIA, SEÇÃO, CARTÃO, VENCIMENTO," +
                    "MARCA, MODELO, EMPLACAMENTO, CIDADE, COR FROM entradacontroleacessoteste WHERE RG = ?", con.con);
                sql.Parameters.Clear();
                sql.Parameters.Add("@RG", MySqlDbType.Int32).Value = RG.Text;
                sql.CommandType = CommandType.Text;

                MySqlDataReader dr;
                dr = sql.ExecuteReader();
                dr.Read();

                ID.Text = dr.GetString(0);
                NOME.Text = dr.GetString(1);
                TXBRE.Text = dr.GetString(2);
                CBPOSTOGRAD.Text = dr.GetString(3);
                TXBRG.Text = dr.GetString(4);
                UNIDADE.Text = dr.GetString(5);
                CBCIA.Text = dr.GetString(6);
                CBSECAO.Text = dr.GetString(7);
                NCARTAO.Text = dr.GetString(8);
                DATAVENCIMENTO.Text = dr.GetString(9);
                TXBMARCA.Text = dr.GetString(10);
                MODELOVEICULO.Text = dr.GetString(11);
                EMPLACAMENTO.Text = dr.GetString(12);
                CIDADE.Text = dr.GetString(13);
                COR.Text = dr.GetString(14);


            }
            catch (Exception)
            {

            }
        }

        private void CBCARTAO_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                con.Conectar();
                sql = new MySqlCommand("SELECT id,NOME, RE, POSTO, RG, UNIDADE, CIA, SEÇÃO, CARTÃO, VENCIMENTO," +
                    "MARCA, MODELO, EMPLACAMENTO, CIDADE, COR FROM entradacontroleacessoteste WHERE CARTÃO = ?", con.con);
                sql.Parameters.Clear();
                sql.Parameters.Add("@CARTÃO", MySqlDbType.Int32).Value = CBCARTAO.Text;
                sql.CommandType = CommandType.Text;

                MySqlDataReader dr;
                dr = sql.ExecuteReader();
                dr.Read();

                ID.Text = dr.GetString(0);
                NOME.Text = dr.GetString(1);
                TXBRE.Text = dr.GetString(2);
                CBPOSTOGRAD.Text = dr.GetString(3);
                TXBRG.Text = dr.GetString(4);
                UNIDADE.Text = dr.GetString(5);
                CBCIA.Text = dr.GetString(6);
                CBSECAO.Text = dr.GetString(7);
                NCARTAO.Text = dr.GetString(8);
                DATAVENCIMENTO.Text = dr.GetString(9);
                TXBMARCA.Text = dr.GetString(10);
                MODELOVEICULO.Text = dr.GetString(11);
                EMPLACAMENTO.Text = dr.GetString(12);
                CIDADE.Text = dr.GetString(13);
                COR.Text = dr.GetString(14);


            }
            catch (Exception)
            {

            }
        }

        private void PREFIXO_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                con.Conectar();
                sql = new MySqlCommand("SELECT * FROM controlevtr WHERE PREFIXO = ?", con.con);
                sql.Parameters.Clear();
                sql.Parameters.Add("@PREFIXO", MySqlDbType.Int32).Value = PREFIXO.Text;
                sql.CommandType = CommandType.Text;

                MySqlDataReader dr;
                dr = sql.ExecuteReader();
                dr.Read();

                PREFIXOVTR.Text = dr.GetString(8);
                MARCAVTR.Text = dr.GetString(3);
                MODELOVTR.Text = dr.GetString(2);
                PLACAVTR.Text = dr.GetString(7);
                CIDADEVTR.Text = dr.GetString(9);
                CORVTR.Text = dr.GetString(10);


            }
            catch (Exception)
            {

            }

        }

        private void RG_TextChanged(object sender, EventArgs e)
        {
            if (RG.Text != "")
            {
                RE.Enabled = false;
                CBCARTAO.Enabled = false;
                PREFIXO.Enabled = false;

            }
            else
            {
                RE.Enabled = true;
                CBCARTAO.Enabled = true;
                PREFIXO.Enabled = true;
            }
        }

        private void CBCARTAO_TextChanged(object sender, EventArgs e)
        {
            if (CBCARTAO.Text != "")
            {
                RE.Enabled = false;
                RG.Enabled = false;
                PREFIXO.Enabled = false;

            }
            else
            {
                RE.Enabled = true;
                RG.Enabled = true;
                PREFIXO.Enabled = true;
            }
        }

        private void PREFIXO_TextChanged(object sender, EventArgs e)
        {
            if (PREFIXO.Text != "")
            {
                RE.Enabled = false;
                RG.Enabled = false;
                CBCARTAO.Enabled = false;

            }
            else
            {
                RE.Enabled = true;
                RG.Enabled = true;
                CBCARTAO.Enabled = true;
            }
        }
    }
    
}

