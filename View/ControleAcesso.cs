﻿using System;
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
           

        }

        public void RetornoDadosAcesso(Pessoas dados)
        {

           
        }


        private void RE_Enter(object sender, EventArgs e)
        {
            

        }



        public void ENTRADAControleAcesso(Pessoas dados)     // capturando dados dos textbox
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
            try
            {
                con.Conectar();
                sql = new MySqlCommand("SELECT id,NOME, RE, POSTO, RG, UNIDADE, CIA, SEÇÃO FROM entradacontroleacessoteste WHERE RE = ?", con.con);
                sql.Parameters.Clear();
                sql.Parameters.Add("@RE", MySqlDbType.Int32).Value = RE.Text;
                sql.CommandType = CommandType.Text;

                MySqlDataReader dr;
                dr = sql.ExecuteReader();
                dr.Read();

                NOME.Text = dr.GetString(1);

            }
            catch (Exception)
            {

            }

        }

        public void TESTE(Pessoas dados)     // capturando dados dos textbox
        {


            try
            {
                con.Conectar();
                sql = new MySqlCommand("select * from entradacontroleacessoteste where  RE LIKE @RE", con.con);
                sql.Parameters.AddWithValue("@RE", dados.REControleAcesso1 + "%");
                sql.Parameters.Clear();
                sql.Parameters.Add("@entradacontroleacessoteste", MySqlDbType.Int32).Value = ID.Text;
                sql.CommandType = CommandType.Text;

                MySqlDataReader dr;
                dr = sql.ExecuteReader();
                dr.Read();

                NOME.Text = dr.GetString(1);

            }
            catch (Exception)
            {

            }
        }
    }
    
}
