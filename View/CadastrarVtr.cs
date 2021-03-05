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
    public partial class CadastrarVtr : Form
    {
        Model.Model model = new Model.Model();
        public string Foto = "";
        public CadastrarVtr()
        {
            InitializeComponent();
        }


        //Arrastar janela
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pessoas dado = new Pessoas();
            CadastroVtr(dado);

        }

        public void CadastroVtr(Pessoas dados)     // capturando dados dos textbox
        {


            try
            {
                dados.PatrimonioInfo = txbPatrimonio.Text;
                dados.ModeloInfo = txbModelo.Text;
                dados.SerialInfo = txbPlaca.Text;
                dados.LocalInfo = cmbLocal.Text;
                dados.PatrimonioPMInfo = txbPrefixo.Text;
                dados.ObservacaoInfo = txbObservacao.Text;
                dados.SrcFotoInfo = SrcFoto.Text;


                model.CadastroVtr(dados);
                MessageBox.Show("Salvo com Sucesso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar " + ex.Message);
            }
        }

        private void CadastrarVtr_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pbViatura_Click(object sender, EventArgs e)
        {
            // Carregando imagem na tela
            OpenFileDialogVtr.ShowDialog();
            if (OpenFileDialogVtr.FileName != "")
            {
                this.Foto = OpenFileDialogVtr.FileName;                           
                pbViatura.Load(this.Foto);
                


                Bitmap bmp = new Bitmap(OpenFileDialogVtr.FileName);
                Bitmap bmp2 = new Bitmap(bmp, pbViatura.Size);

                pbViatura.Image = bmp2;
                pbViatura.Image.Save(Application.StartupPath.ToString() + "\\ImagensVtr\\" + txbPatrimonio.Text + ".png", System.Drawing.Imaging.ImageFormat.Png);
                SrcFoto.Text = Application.StartupPath.ToString() + "\\ImagensVtr\\" + txbPatrimonio.Text + ".png";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbPlaca.Text = "";
            txbPatrimonio.Text = "";
            txbPrefixo.Text = "";
            txbModelo.Text = "";
            cmbLocal.Text = "";
            txbObservacao.Text = "";
        }
    }
}
