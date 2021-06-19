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
        public string Foto = "";
        public ControleAcessoCadastro()
        {
            InitializeComponent();
        }

        //Arrastar janela
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        

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

        private void DATAATUAL_Click(object sender, EventArgs e)
        {

        }

        private void HORAATUAL_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
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
            CADASTROFOTO.Image = null;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
       
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ControleAcessoCadastro_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ControleAcessoBtnFoto_Click(object sender, EventArgs e)
        {
            // Carregando imagem na tela

            if(OpenFileDialogFoto.ShowDialog() == DialogResult.OK)  // Dar prosseguimento apenas se o usuário escolher uma foto
            {
                this.Foto = OpenFileDialogFoto.FileName;
                CADASTROFOTO.Load(this.Foto);





                Bitmap bmp = new Bitmap(OpenFileDialogFoto.FileName);
                Bitmap bmp2 = new Bitmap(bmp, CADASTROFOTO.Size);

                CADASTROFOTO.Image = bmp2;
                CADASTROFOTO.Image.Save(Application.StartupPath.ToString() + "\\FotosCadastro\\" + NOME.Text + ".png", System.Drawing.Imaging.ImageFormat.Png);
            }            
            else
            {                
                return;
            }            

        }
    }        
    
}
