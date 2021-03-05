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

namespace SistemaMysql.View
{
    public partial class CadastrarTmd : Form
    {
        PessoaModel model = new PessoaModel();
        public string Foto = "";
        public CadastrarTmd()
        {
            InitializeComponent();
        }

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
        }


        public void CadastroPc(Pessoas dados)     // capturando dados dos textbox
        {


            try
            {
                dados.PatrimonioPc1 = txbPatrimonio.Text;
                dados.ModeloPc1 = txbModelo.Text;
                dados.SerialPc1 = txbSerial.Text;
                dados.LocalPc1 = cmbLocal.Text;
                dados.PatrimonioPMPc1 = txbPatrimonioPm.Text;
                dados.ObservacaoPc1 = txbObservacao.Text;
                dados.SrcFotoPc1 = SrcFoto.Text;


                model.CadastroPc(dados);
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
                    dados.PatrimonioTmd1 = txbPatrimonio.Text;
                    dados.ModeloTmd1 = txbModelo.Text;
                    dados.SerialTmd1 = txbSerial.Text;
                    dados.LocalTmd1 = cmbLocal.Text;
                    dados.PatrimonioPMTmd1 = txbPatrimonioPm.Text;
                    dados.ObservacaoTmd1 = txbObservacao.Text;
                    dados.SrcFotoTmd1 = SrcFoto.Text;
                    


                    

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
                SrcFoto.Text = Application.StartupPath.ToString() + "\\ImagensTmd\\"+ txbPatrimonio.Text + ".png";
            }
            
        }

        private void CadastrarTmd_Load(object sender, EventArgs e)
        {

        }

        private void txbPatrimonioTmdPm_TextChanged(object sender, EventArgs e)
        {

        }
    }

   
}

