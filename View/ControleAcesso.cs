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
        //String imgLoc = "";
        public ControleAcesso()
        {
            InitializeComponent();
        }

       /* public ControleAcesso(String Valor, ErroControle_Acesso Reset, EscolhaEntrada Escolha)
        {
            InitializeComponent();
            //RECUPERANDO VALORES DO FORM CONTROLE DE ACESSO
            STATUS.Text = Valor;
            
        }*/

        



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
                


                model.ENTRADAControleAcesso(dados);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar " + ex.Message);
            }
        }

        public void SAIDAControleAcesso(Pessoas dados)     // capturando dados dos textbox
        {


            try
            {
                                
                dados.DATA1 = DATAATUAL.Text;
                dados.HORA1 = HORAATUAL.Text;
                dados.STATUS1 = "DESCANSANDO";
                dados.Id = Convert.ToInt32(ID.Text);
                dados.IdSaida1 = Convert.ToInt32(ID_SAIDA.Text);
               



                model.SAIDAControleAcesso(dados);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar " + ex.Message);
            }
        }


        public void ENTRADAControleAcessoaPe(Pessoas dados)     // capturando dados dos textbox
        {
            // Entrada de pessoas a pé

            try
            {

                dados.NomeControleAcesso = NOME.Text;
                dados.REControleAcesso1 = TXBRE.Text;
                dados.POSTOGRADControleAcesso1 = CBPOSTOGRAD.Text;
                dados.TXBRGControleAcesso1 = TXBRG.Text;
                dados.UNIDADEControleAcesso1 = UNIDADE.Text;
                dados.CIAControleAcesso1 = CBCIA.Text;
                dados.SECAOControleAcesso1 = CBSECAO.Text;
                dados.NCARTAOontroleAcesso1 = " A PÉ ";
                dados.VENCIMENTOControleAcesso1 = " A PÉ ";
                dados.MARCAControleAcesso1 = " A PÉ ";
                dados.MODELOControleAcesso1 = " A PÉ ";
                dados.EMPLACAMENTOControleAcesso1 = " A PÉ ";
                dados.CIDADEControleAcesso1 = " A PÉ ";
                dados.CORControleAcesso1 = " A PÉ ";
                dados.DATA1 = DATAATUAL.Text;
                dados.HORA1 = HORAATUAL.Text;
                dados.Id = Convert.ToInt32(ID.Text);



                model.ENTRADAControleAcessoaPe(dados);

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
                //Tela de erro por não informar a identificação
                ErroControle_Acesso form = new ErroControle_Acesso();
                form.Show();                
                return;

            }
            if (STATUS.Text == "TRABALHANDO") {

                //Tela de Policial já se encontra no interior do quartel
                ErroEntradaControleAcesso form = new ErroEntradaControleAcesso(ID.Text,this);      
                form.Show();                
                return;
            }            
            else
            {
                Pessoas dado = new Pessoas();
                if (ID.Text != "")
                {
                    //Tela escolha o tipo de entrada (com veiculo ou a pé)
                    EscolhaEntrada form = new EscolhaEntrada(ID.Text,this);
                    form.Show();
                    return;
                }
                else
                {
                    /* try
                     {

                         con.Conectar();
                         sql = new MySqlCommand("UPDATE status SET STATUS = @STATUS WHERE ID = @ID", con.con);   // comando para editar dados no BD

                         sql.Parameters.AddWithValue("@ID", ID.Text);
                         sql.Parameters.AddWithValue("@STATUS", STATUS.Text = "TRABALHANDO");
                         sql.ExecuteNonQuery();
                         con.FecharConexao();

                     }
                     catch (Exception ex)
                     {

                         MessageBox.Show("Erro ao editar" + ex);
                         con.FecharConexao();
                     }
                     ENTRADAControleAcesso(dado);
                     ConfirmarEntrada form = new ConfirmarEntrada();
                     form.Show();
                     ReloadForm();
                 }*/
                }
                


            }

        }

        private void btnSAIDA_Click(object sender, EventArgs e)
        {
            if (ID.Text == "")
            {
                //Tela de erro por não informar a identificação
                ErroControle_Acesso form = new ErroControle_Acesso();
                form.Show();
                return;
            }
            if (STATUS.Text == "DESCANSANDO")
            {
                MessageBox.Show("O USUÁRIO JÁ SE ENCONTRA FORA DO QUARTEL", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (HORA_SAIDA.Text == "")
            {
                MessageBox.Show("O USUÁRIO NÃO SE ENCONTRA NO INTERIOR DO QUARTEL", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                EscolhaSaida form = new EscolhaSaida(ID_SAIDA.Text, this);
                form.Show();
                return;
            }

        }

        public void CadastrarEntradaVeiculo()
        {
            Pessoas dado = new Pessoas();
            try
            {

                con.Conectar();
                sql = new MySqlCommand("UPDATE status SET STATUS = @STATUS WHERE ID = @ID", con.con);   // comando para editar dados no BD
                sql.Parameters.AddWithValue("@ID", ID.Text);
                sql.Parameters.AddWithValue("@STATUS", STATUS.Text = "TRABALHANDO");
                sql.ExecuteNonQuery();
                con.FecharConexao();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao editar" + ex);
                con.FecharConexao();
            }
            ENTRADAControleAcesso(dado);
            ConfirmarEntrada form = new ConfirmarEntrada();
            form.Show();
            ReloadForm();
        }

        public void CadastrarSaidaVeiculo()
        {

            //MessageBox.Show(" ATÉ AQUI OK!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Pessoas dado = new Pessoas();
             try
             {

                 con.Conectar();
                 sql = new MySqlCommand("UPDATE acesso SET HORA_SAIDA = @HORA_SAIDA WHERE ID = @ID", con.con);   // comando para editar dados no BD
                 sql.Parameters.AddWithValue("@ID", ID_SAIDA.Text);
                 sql.Parameters.AddWithValue("@HORA_SAIDA", HORAATUAL.Text);                
                 sql.ExecuteNonQuery();
                 con.FecharConexao();

             }
             catch (Exception ex)
             {

                 MessageBox.Show("Erro ao editar" + ex);
                 con.FecharConexao();
                 return;
             }
             SAIDAControleAcesso(dado);
             ConfirmarEntrada form = new ConfirmarEntrada();
             form.Show();
             ReloadForm();
        }


        public void CadastrarEntradaaPe()
        {
            Pessoas dado = new Pessoas();
            try
            {

                con.Conectar();
                sql = new MySqlCommand("UPDATE status SET STATUS = @STATUS WHERE ID = @ID", con.con);   // comando para editar dados no BD
                sql.Parameters.AddWithValue("@ID", ID.Text);
                sql.Parameters.AddWithValue("@STATUS", STATUS.Text = "TRABALHANDO");
                sql.ExecuteNonQuery();
                con.FecharConexao();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao editar" + ex);
                con.FecharConexao();
            }
            ENTRADAControleAcessoaPe(dado);
            ConfirmarEntrada form = new ConfirmarEntrada();
            form.Show();
            ReloadForm();
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



        private void RE_KeyPress(object sender, KeyPressEventArgs e)
        {

            try
            {
                con.Conectar();
                sql = new MySqlCommand("SELECT id,NOME, RE, POSTO, RG, UNIDADE, CIA, SEÇÃO, CARTÃO, VENCIMENTO," +
                    "MARCA, MODELO, EMPLACAMENTO, CIDADE, COR, FOTO FROM cadastroguarda WHERE RE = ?", con.con);

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
                
                //RECUPERANDO IMAGEM DO BD
                byte[] img = (byte[])(dr[15]);

                
                PCFOTO.Image = SistemaMysql.Properties.Resources.police; 
                if (img == null)
                    PCFOTO.Image = null;
                else
                {
                    MemoryStream ms = new MemoryStream(img);
                    PCFOTO.Image = System.Drawing.Image.FromStream(ms);
                }


            }
            catch (Exception)
            {

            }
            try
            {
                con.Conectar();
                sql = new MySqlCommand("SELECT * FROM status WHERE fk_id_ES = ?", con.con);
                sql.Parameters.Clear();
                sql.Parameters.Add("@fk_id_ES", MySqlDbType.Int32).Value = ID.Text;
                sql.CommandType = CommandType.Text;

                MySqlDataReader dr;
                dr = sql.ExecuteReader();
                dr.Read();
                STATUS.Text = dr.GetString(4);               
                con.FecharConexao();


                //Pegando o último id com MAX(id)
                con.Conectar();
                sql = new MySqlCommand("SELECT MAX(id) from acesso WHERE RE = ?", con.con);
                sql.Parameters.Clear();
                sql.Parameters.Add("@RE", MySqlDbType.Int32).Value = RE.Text;
                dr = sql.ExecuteReader();
                dr.Read();                
                ID_SAIDA.Text = dr.GetString(0);
                



                con.Conectar();
                sql = new MySqlCommand("SELECT MAX(HORA_SAIDA) from acesso WHERE RE = ?", con.con);
                sql.Parameters.Clear();
                sql.Parameters.Add("@RE", MySqlDbType.Int32).Value = RE.Text;
                dr = sql.ExecuteReader();
                dr.Read();                
                HORA_SAIDA.Text = dr.GetString(0);



                con.FecharConexao();



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
                    "MARCA, MODELO, EMPLACAMENTO, CIDADE, COR FROM cadastroguarda WHERE RG = ?", con.con);
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
                    "MARCA, MODELO, EMPLACAMENTO, CIDADE, COR FROM cadastroguarda WHERE CARTÃO = ?", con.con);
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

        private void STATUS_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Conectar();
                sql = new MySqlCommand("SELECT * FROM status WHERE fk_id_ES = ?", con.con);
                sql.Parameters.Clear();
                sql.Parameters.Add("@fk_id_ES", MySqlDbType.Int32).Value = ID.Text;
                sql.CommandType = CommandType.Text;

                MySqlDataReader dr;
                dr = sql.ExecuteReader();
                dr.Read();

                STATUS.Text = dr.GetString(5);



            }
            catch (Exception)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RE.Text = "";
            RG.Text = "";
            CBCARTAO.Text = "";
            PREFIXO.Text = "";
            ID.Text = "";
            NOME.Text = "";
            TXBRE.Text = "";
            CBPOSTOGRAD.Text = "";
            TXBRG.Text = "";
            UNIDADE.Text = "";
            CBCIA.Text = "";
            CBSECAO.Text = "";
            NCARTAO.Text = "";
            DATAVENCIMENTO.Text = "";
            TXBMARCA.Text = "";
            MODELOVEICULO.Text = "";
            EMPLACAMENTO.Text = "";
            CIDADE.Text = "";
            COR.Text = "";
            STATUS.Text = "";
            PCFOTO.Image = SistemaMysql.Properties.Resources.police;
        }

        public void ReloadForm()
        {
            //STATUS.ResetText();
            RE.Text = "";
            RG.Text = "";
            CBCARTAO.Text = "";
            PREFIXO.Text = "";
            ID.Text = "";
            NOME.Text = "";
            TXBRE.Text = "";
            CBPOSTOGRAD.Text = "";
            TXBRG.Text = "";
            UNIDADE.Text = "";
            CBCIA.Text = "";
            CBSECAO.Text = "";
            NCARTAO.Text = "";
            DATAVENCIMENTO.Text = "";
            TXBMARCA.Text = "";
            MODELOVEICULO.Text = "";
            EMPLACAMENTO.Text = "";
            CIDADE.Text = "";
            COR.Text = "";
            STATUS.Text = "";
            PCFOTO.Image = SistemaMysql.Properties.Resources.police;

        }

        private void STATUS_TextChanged(object sender, EventArgs e)
        {

        }

        
    }

}

