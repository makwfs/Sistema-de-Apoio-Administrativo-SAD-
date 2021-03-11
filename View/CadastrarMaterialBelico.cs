using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaMysql.Entidades;
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
            if (cmbTipo.Text == "ALGEMA")
            {
                cmbModelo.Items.Clear();
                cmbModelo.Text = "";
                string[] algema = new string[]
             {
                   "ALGEMA DE AÇO"

             };
             cmbModelo.Items.AddRange(algema);

            }
            else if (cmbTipo.Text == "ARMA")
            {
                cmbModelo.Items.Clear();
                cmbModelo.Text = "";
                string[] armas = new string[]
                {
                    "PISTOLA GLOCK G22 G5 .40",
                    "PISTOLA CAL .40 PT-640",
                    "PISTOLA .40 - 24/7 PRO",
                    "PISTOLA .40 24/7 PRO TACT",
                    "ESPINGARDA CAL 12",
                    "FUZIL 5,56",
                    "TASER CLASS III - X2"
                       
                };
                cmbModelo.Items.AddRange(armas);              
                                               
            }
            else if (cmbTipo.Text == "COLETE")
            {
                cmbModelo.Items.Clear();
                cmbModelo.Text = "";
                string[] colete = new string[]
                {
                    
                    "CBC",
                    "INBRATERRESTRE"

                };
                cmbModelo.Items.AddRange(colete);
            }
            else if (cmbTipo.Text == "CAPACETE BALISTICO")
            {
                cmbModelo.Items.Clear();
                cmbModelo.Text = "";
                string[] colete = new string[]
                {

                    "CAPACETE BALISTICO NIVEL II COM VISOR"
                   

                };
                cmbModelo.Items.AddRange(colete);
            }
            else if (cmbTipo.Text == "ESCUDO BALISTICO")
            {
                cmbModelo.Items.Clear();
                cmbModelo.Text = "";
                string[] colete = new string[]
                {

                    "ESCUDO BALISTICO"


                };
                cmbModelo.Items.AddRange(colete);
            }
        }

        public void CadastroMatBel(Pessoas dados)     // capturando dados dos textbox
        {


            try
            {
                dados.PatrimonioInfo = txbPatrimonio.Text;
                dados.Tipo = cmbTipo.Text;
                dados.Modelo = cmbModelo.Text;
                dados.Fabricante = cmbFabricante.Text;
                dados.Serial = txbSerial.Text;
                dados.PatrimonioPM = txbPatrimonioPm.Text;
                dados.Situacao = cmbSituacao.Text;
                dados.RE = txbRE.Text;
                dados.Nome = txbNome.Text;
                dados.ObservacaoInfo = txbObservacao.Text;
                dados.SrcFotoInfo = SrcFoto.Text;


                model.CadastroMatBel(dados);
                MessageBox.Show("Cadastrado com Sucesso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar " + ex.Message);
            }
        }

        private void CadastrarMaterialBelico_Load(object sender, EventArgs e)
        {

         

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

        private void CadastrarMaterialBelico_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pessoas dado = new Pessoas();
            CadastroMatBel(dado);
        }

        private void pbTmd_Click(object sender, EventArgs e)
        {
            // Carregando imagem na tela
            OpenFileDialogMatBel.ShowDialog();
            if (OpenFileDialogMatBel.FileName != "")
            {


                this.Foto = OpenFileDialogMatBel.FileName;
                pbTmd.Load(this.Foto);





                Bitmap bmp = new Bitmap(OpenFileDialogMatBel.FileName);
                Bitmap bmp2 = new Bitmap(bmp, pbTmd.Size);

                pbTmd.Image = bmp2;
                pbTmd.Image.Save(Application.StartupPath.ToString() + "\\ImagensMatBel\\" + txbPatrimonio.Text + ".png", System.Drawing.Imaging.ImageFormat.Png);
                SrcFoto.Text = Application.StartupPath.ToString() + "\\ImagensMatBel\\" + txbPatrimonio.Text + ".png";


            }
            else
            {
                MessageBox.Show("Cadastre uma imagem ! ", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbPatrimonio.Text = "";
            cmbTipo.Text = "";
            cmbModelo.Text = "";
            cmbFabricante.Text = "";
            txbSerial.Text = "";
            txbPatrimonioPm.Text = "";
            cmbSituacao.Text = "";
            txbRE.Text = "";
            txbNome.Text = "";
            txbObservacao.Text = "";
            SrcFoto.Text = "";
        }
    }


    

   

}
