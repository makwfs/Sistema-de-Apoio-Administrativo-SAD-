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
    public partial class CadastrarInformatica : Form
    {
        Model.Model model = new Model.Model();
        public string Foto = "";
        public CadastrarInformatica()
        {
            InitializeComponent();
        }

        //Arrastar janela
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbSerial.Text = "";
            txbPatrimonio.Text = "";
            txbObservacao.Text = "";
            txbModelo.Text = "";
            cmbLocal.Text = "";
            pbTmd.Image = null;
            
        }
     

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pessoas dado = new Pessoas();
             

            if (cmbTipoInformatica.Text == "TMD")
            {
                CadastroTmd(dado);
            }
            else if(cmbTipoInformatica.Text == "COMPUTADOR")
            {
                CadastroPc(dado);
            }
            else if (cmbTipoInformatica.Text == "RÁDIO")
            {
                CadastroRadio(dado);
            }
            else
            {
                CadastroImpressora(dado);
            }
        }


        public void CadastroPc(Pessoas dados)     // capturando dados dos textbox
        {


            try
            {
                dados.PatrimonioInfo = txbPatrimonio.Text;
                dados.ModeloInfo = txbModelo.Text;
                dados.SerialInfo = txbSerial.Text;
                dados.LocalInfo = cmbLocal.Text;
                dados.PatrimonioPMInfo = txbPatrimonioPm.Text;
                dados.ObservacaoInfo = txbObservacao.Text;
                dados.SrcFotoInfo = SrcFoto.Text;


                model.CadastroPc(dados);
                MessageBox.Show("Salvo com Sucesso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar " + ex.Message);
            }
        }

        public void CadastroImpressora(Pessoas dados)     // capturando dados dos textbox
        {


            try
            {
                dados.PatrimonioInfo = txbPatrimonio.Text;
                dados.ModeloInfo = txbModelo.Text;
                dados.SerialInfo = txbSerial.Text;
                dados.LocalInfo = cmbLocal.Text;
                dados.PatrimonioPMInfo = txbPatrimonioPm.Text;
                dados.ObservacaoInfo = txbObservacao.Text;
                dados.SrcFotoInfo = SrcFoto.Text;


                model.CadastroImpressora(dados);
                MessageBox.Show("Salvo com Sucesso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar " + ex.Message);
            }
        }

        public void CadastroRadio(Pessoas dados)     // capturando dados dos textbox
        {


            try
            {
                dados.PatrimonioInfo = txbPatrimonio.Text;
                dados.ModeloInfo = txbModelo.Text;
                dados.SerialInfo = txbSerial.Text;
                dados.LocalInfo = cmbLocal.Text;
                dados.PatrimonioPMInfo = txbPatrimonioPm.Text;
                dados.ObservacaoInfo = txbObservacao.Text;
                dados.SrcFotoInfo = SrcFoto.Text;


                model.CadastroRadio(dados);
                MessageBox.Show("Salvo com Sucesso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar " + ex.Message);
            }
        }

        public void CadastroTmd(Pessoas dados)     // capturando dados dos textbox
        {
            if (txbPatrimonio.Text != "")
            {
                try
                {   
                    dados.PatrimonioInfo = txbPatrimonio.Text;
                    dados.ModeloInfo = txbModelo.Text;
                    dados.SerialInfo = txbSerial.Text;
                    dados.LocalInfo = cmbLocal.Text;
                    dados.PatrimonioPMInfo = txbPatrimonioPm.Text;
                    dados.ObservacaoInfo = txbObservacao.Text;
                    dados.SrcFotoInfo = SrcFoto.Text;
                    


                    

                    model.CadastroTmd(dados);
                    MessageBox.Show("Salvo com Sucesso!");

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro ao Salvar " + ex.Message);
                }



            }
            else
            {
                MessageBox.Show("Insira os dados corretamente !", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

      

        private void pbTmd_Click(object sender, EventArgs e)
        {
            // Carregando imagem na tela
            OpenFileDialogTmd.ShowDialog();
            if(OpenFileDialogTmd.FileName != "")
            {
                               

                    this.Foto = OpenFileDialogTmd.FileName;
                    pbTmd.Load(this.Foto);





                    Bitmap bmp = new Bitmap(OpenFileDialogTmd.FileName);
                    Bitmap bmp2 = new Bitmap(bmp, pbTmd.Size);

                    pbTmd.Image = bmp2;
                    pbTmd.Image.Save(Application.StartupPath.ToString() + "\\ImagensTmd\\" + txbPatrimonio.Text + ".png", System.Drawing.Imaging.ImageFormat.Png);
                    SrcFoto.Text = Application.StartupPath.ToString() + "\\ImagensTmd\\" + txbPatrimonio.Text + ".png";
                
                
            }
            else
            {
                MessageBox.Show("Cadastre uma imagem ! ", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        private void CadastrarTmd_Load(object sender, EventArgs e)
        {

        }

        private void txbPatrimonioTmdPm_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CadastrarInformatica_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void SrcFoto_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

   
}

