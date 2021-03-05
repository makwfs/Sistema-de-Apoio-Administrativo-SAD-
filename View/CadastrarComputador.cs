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
using SistemaMysql;
using SistemaMysql.Model;
using SistemaMysql.Entidades;
using System.Data.SqlClient;

namespace SistemaMysql.View
{
    public partial class CadastrarComputador : Form
    {
        PessoaModel model = new PessoaModel();
        public string Foto = "";
        public CadastrarComputador()
        {
            InitializeComponent();
        }
 
        
       
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbSerialComputador.Text = "";
            txbPatrimonioComputador.Text = "";
            txbObservacaoComputador.Text = "";
            txbModeloComputador.Text = "";
            cmbLocalComputador.Text = "";

        }

       

             

      

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Carregando imagem na tela
            OpenFileDialogPc.ShowDialog();
            if (OpenFileDialogPc.FileName != "")
            {
                this.Foto = OpenFileDialogPc.FileName;
                pbPc.Load(this.Foto);

                Bitmap bmp = new Bitmap(OpenFileDialogPc.FileName);
                Bitmap bmp2 = new Bitmap(bmp, pbPc.Size);

                pbPc.Image = bmp2;
                pbPc.Image.Save(Application.StartupPath.ToString() + "\\ImagensTmd\\" + txbPatrimonioComputador.Text + ".png", System.Drawing.Imaging.ImageFormat.Png);
                SrcFotoPc.Text = Application.StartupPath.ToString() + "\\ImagensTmd\\" + txbPatrimonioComputador.Text + ".png";
            }
           
        }

       

        public void CadastroPc(Pessoas dados)     // capturando dados dos textbox
        {


            try
            {
                dados.PatrimonioPc1 = txbPatrimonioComputador.Text;
                dados.ModeloPc1 = txbModeloComputador.Text;
                dados.SerialPc1 = txbSerialComputador.Text;
                dados.LocalPc1 = cmbLocalComputador.Text;
                dados.PatrimonioPMPc1 = txbPatrimônioComputadorPm.Text;
                dados.ObservacaoPc1 = txbObservacaoComputador.Text;
                dados.SrcFotoPc1 = SrcFotoPc.Text;


                model.CadastroPc(dados);
                MessageBox.Show("Salvo com Sucesso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar " + ex.Message);
            }
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            txbSerialComputador.Clear();
            txbPatrimonioComputador.Clear();
            txbObservacaoComputador.Clear();
            txbModeloComputador.Clear();
            txbPatrimônioComputadorPm.Clear();
            cmbLocalComputador.Text = "";
            txbModeloComputador.Clear();
        }

        private void btnCadastrarComputador_Click_1(object sender, EventArgs e)
        {
            Pessoas dado = new Pessoas();
            CadastroPc(dado);
        }

        private void CadastrarComputador_Load(object sender, EventArgs e)
        {

        }
    }
}
