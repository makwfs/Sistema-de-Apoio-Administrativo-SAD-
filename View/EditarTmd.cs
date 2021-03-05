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
using SistemaMysql.Entidades;
using SistemaMysql.Model;
using SistemaMysql.View;


namespace SistemaMysql.View
{
    public partial class EditarTmd : Form
    {
        PessoaModel model = new PessoaModel();
        public string Foto = "";
        
        Conexao con = new Conexao();

        public EditarTmd()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Editar_Load(object sender, EventArgs e)
        {
            Listar();
        }

        public void Listar()
        {
            try
            {
                gridEditarTmd.DataSource = model.Listar(); // alimentar o grid 

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro com os dados" + ex.Message);

            }
        }

       

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txbId.Text == "")
            {
                MessageBox.Show("Selecione um registro na tabela para prosseguir com a edição!");
                return;
            }
            Pessoas dado = new Pessoas();
            EditarDados(dado);
            Listar();
        }

        public void EditarDados(Pessoas dados)
        {
            try
            {
                dados.Id = Convert.ToInt32(txbId.Text);
                dados.PatrimonioTmd1 = txbPatrimonioTmd.Text;
                dados.ModeloTmd1 = txbModeloTmd.Text;
                dados.SerialTmd1 = txbSerialTmd.Text;
                dados.LocalTmd1 = cmbLocal.Text;
                dados.PatrimonioPMTmd1 = txbPatrimonioTmdPm.Text;
                dados.ObservacaoTmd1 = txbObservacaoTmd.Text;
                dados.SrcEditarFotoTmd1 = SrcEditarFotoTmd.Text;



                model.EditarDadosTmd(dados);
                MessageBox.Show("Salvo com Sucesso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar  EEEE" + ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbSerialTmd.Text = "";
            txbPatrimonioTmd.Text = "";
            txbObservacaoTmd.Text = "";
            txbModeloTmd.Text = "";
            cmbLocal.Text = "";
        }

        private void btnEcluir_Click(object sender, EventArgs e)
        {
            if (txbId.Text == "")
            {
                MessageBox.Show("Selecione um registro na tabela para Ecluir!");
                return;
            }
            if(MessageBox.Show("Deseja realmente Exluir?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.No)  // DialogResult.No -> Caso o botão escolhido seja o 2 ele entra no return e não faz nada
            {
                return;
            }
            Pessoas dado = new Pessoas();
            Excluir(dado);
            Listar();
        }

        public void Excluir(Pessoas dados) 
        {
            try
            {
                dados.Id = Convert.ToInt32(txbId.Text);
                

                model.Excluir(dados);
                MessageBox.Show("Excluido com Sucesso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Excluir " + ex.Message);
            }
        }

        private void txbPesquisar_TextChanged(object sender, EventArgs e)
        {
           
            {
                Pessoas dado = new Pessoas();
                Pesquisar(dado);
                if (txbPesquisar.Text == "")                       // Listar caso o campo esteja vazio
                {
                    Listar();
                    return;
                }
                else 
                {
                    try
                    {
                        dado.PatrimonioTmd1 = txbPesquisar.Text;
                        gridEditarTmd.DataSource = model.PesquisarTmd(dado);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro com os dados" + ex.Message);

                    }
                }

            }
        }


        public void Pesquisar(Pessoas dado)
        {

            try
            {
                dado.PatrimonioTmd1 = txbPesquisar.Text;
                gridEditarTmd.DataSource = model.PesquisarTmd(dado);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro com os dados" + ex.Message);

            }
        }

        private void pbEditarTmd_Click(object sender, EventArgs e)
        {
           
        }

        private void pbEditarTmd_Click_1(object sender, EventArgs e)
        {
            OpenFileDialogEditarTmd.ShowDialog();
            if (OpenFileDialogEditarTmd.FileName != "")
            {
                this.Foto = OpenFileDialogEditarTmd.FileName;
                pbEditarTmd.Load(this.Foto);

                Bitmap bmp = new Bitmap(OpenFileDialogEditarTmd.FileName);
                Bitmap bmp2 = new Bitmap(bmp, pbEditarTmd.Size);
                pbEditarTmd.Image = bmp2;

                pbEditarTmd.Image.Save(Application.StartupPath.ToString() + "\\ImagensTmd\\" + txbPatrimonioTmd.Text + ".png", System.Drawing.Imaging.ImageFormat.Png);
                SrcEditarFotoTmd.Text = Application.StartupPath.ToString() + "\\ImagensTmd\\" + txbPatrimonioTmd.Text + ".png";


            }
        }

        private void gridEditarTmd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridEditarTmd_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Pegando os dados do grid e jogando nas texbox 
            // O valor contido em Cells[] corresponde as colunas das tabelas
            txbId.Text = gridEditarTmd.CurrentRow.Cells[0].Value.ToString();
            txbPatrimonioTmd.Text = gridEditarTmd.CurrentRow.Cells[1].Value.ToString();
            txbModeloTmd.Text = gridEditarTmd.CurrentRow.Cells[2].Value.ToString();
            txbSerialTmd.Text = gridEditarTmd.CurrentRow.Cells[3].Value.ToString();
            cmbLocal.Text = gridEditarTmd.CurrentRow.Cells[4].Value.ToString();
            txbPatrimonioTmdPm.Text = gridEditarTmd.CurrentRow.Cells[5].Value.ToString();
            txbObservacaoTmd.Text = gridEditarTmd.CurrentRow.Cells[6].Value.ToString();
            SrcEditarFotoTmd.Text = gridEditarTmd.CurrentRow.Cells[7].Value.ToString();

            if (SrcEditarFotoTmd.Text == "")
            {
                MessageBox.Show("Se possivel cadastre uma imagem para o produto !");
            }
            else
            {
                pbEditarTmd.Load(gridEditarTmd.CurrentRow.Cells[7].Value.ToString());
            }



        }

        
    }

}
