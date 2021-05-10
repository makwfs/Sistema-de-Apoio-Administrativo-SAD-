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
    public partial class CadastrarMaterialBelico : Form
    {
        Model.Model model = new Model.Model();
        public string Foto = "";
        public CadastrarMaterialBelico()
        {
            InitializeComponent();
        }

        //Arrastar janela
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void cmbTipoInformatica_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.Text == "ARMA")
            {
                cmbModelo.Items.Clear();
                cmbFabricante.Items.Clear();
                cmbModelo.Items.Add("FUZIL 5.56");
                cmbModelo.Items.Add("METRALHADORA FAMAE CAL.40");
                cmbModelo.Items.Add("PISTOLA GLOCK G22 G5 .40");
                cmbModelo.Items.Add("PISTOLA CAL .40 PT - 640");
                cmbModelo.Items.Add("PISTOLA .40 - 24 / 7 PRO");
                cmbModelo.Items.Add("PISTOLA .40 24 / 7 PRO TACT");
                cmbModelo.Items.Add("TASER CLASS III - X2");
                cmbFabricante.Items.Add("GLOCK");
                cmbFabricante.Items.Add("TAURUS");
                cmbFabricante.Items.Add("IMBEL");
            }
            if (cmbTipo.Text == "ALGEMA")
            {
                cmbModelo.Items.Clear();
                cmbModelo.Items.Add("ALGEMA DE AÇO");
                
            }
            if (cmbTipo.Text == "COLETE")
            {
                cmbModelo.Items.Clear();
                cmbFabricante.Items.Clear();
                cmbFabricante.Items.Add("CBC");
                cmbFabricante.Items.Add("INBRATERRESTRE");
            }

        }

        private void cmbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
                  
        }

        public void CadastroMatBel(Pessoas dados)     // capturando dados dos textbox
        {


            try
            {
                dados.PatrimonioInfo = txbPatrimonio.Text;
                dados.Tipo = cmbTipo.Text;
                dados.ModeloInfo = txbRE.Text;
                dados.Fabricante = cmbFabricante.Text;
                dados.SerialInfo = txbSerial.Text;
                dados.PatrimonioPMInfo = txbPatrimonioPm.Text;
                dados.Estado = cmbEstado.Text;
                dados.RE = txbRE.Text;
                dados.Nome = txbNome.Text;
                dados.ObservacaoInfo = txbObservacao.Text;
                dados.SrcFotoInfo = SrcFoto.Text;


                model.CadastroMaterialBelico(dados);
                MessageBox.Show("Salvo com Sucesso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar " + ex.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pessoas dado = new Pessoas();
                
                CadastroMatBel(dado);
           
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbPatrimonio.Text = "";
            cmbTipo.Text = "";
            cmbModelo.Text = ""; 
            txbRE.Text = "";
            cmbFabricante.Text = "";
            txbSerial.Text = "";
            txbPatrimonioPm.Text = "";
            cmbEstado.Text = "";
            txbRE.Text = "";
            txbNome.Text = "";
            txbObservacao.Text = "";
            SrcFoto.Text = "";
            
        }

        private void pbTmd_Click(object sender, EventArgs e)
        {
            // Carregando imagem na tela
            OpenFileDialog.ShowDialog();
            if (OpenFileDialog.FileName != "")
            {


                this.Foto = OpenFileDialog.FileName;
                pbTmd.Load(this.Foto);





                Bitmap bmp = new Bitmap(OpenFileDialog.FileName);
                Bitmap bmp2 = new Bitmap(bmp, pbTmd.Size);

                pbTmd.Image = bmp2;
                pbTmd.Image.Save(Application.StartupPath.ToString() + "\\ImagensMatBel\\" + txbPatrimonio.Text + ".png", System.Drawing.Imaging.ImageFormat.Png);
                SrcFoto.Text = Application.StartupPath.ToString() + "\\ImagensMatbel\\" + txbPatrimonio.Text + ".png";


            }
            else
            {
                MessageBox.Show("Cadastre uma imagem ! ", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }


    

   

}
