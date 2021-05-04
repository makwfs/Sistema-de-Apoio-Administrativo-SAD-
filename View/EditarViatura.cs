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
using System.Runtime.InteropServices;   // Biblioteca para arrastar tela

namespace SistemaMysql.View
{
    public partial class EditarViatura : Form
    {

        Model.Model model = new Model.Model();
        public string Foto = "";
        public EditarViatura()
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

        private void EditarViatura_Load(object sender, EventArgs e)
        {
            Listar();
        }
        public void Listar()
        {
            try
            {
                grid.DataSource = model.ListarVtr(); // alimentar o grid com a tabela vtr

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro com os dados" + ex.Message);

            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pessoas dado = new Pessoas();
            EditarVtr(dado);
            Listar();
        }

        public void EditarVtr(Pessoas dados)
        {
            try
            {
                dados.Id = Convert.ToInt32(txbId.Text);
                dados.Patrimonio = txbPatrimonio.Text;
                dados.Modelo = txbModelo.Text;
                dados.prefixo = txbPrefixo.Text;
                dados.Local = cmbLocal.Text;
                dados.placa = txbPlaca.Text;
                dados.Observacao = txbObservacao.Text;
                dados.SrcEditarFoto = SrcFoto.Text;



                model.EditarVtr(dados);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar  EEEE" + ex.Message);
            }
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pegando os dados do grid e jogando nas texbox 
            // O valor contido em Cells[] corresponde as colunas das tabelas
            txbId.Text = grid.CurrentRow.Cells[0].Value.ToString();
            txbPatrimonio.Text = grid.CurrentRow.Cells[1].Value.ToString();
            txbModelo.Text = grid.CurrentRow.Cells[2].Value.ToString();
            cmbLocal.Text = grid.CurrentRow.Cells[3].Value.ToString();
            txbObservacao.Text = grid.CurrentRow.Cells[4].Value.ToString();
            SrcFoto.Text = grid.CurrentRow.Cells[5].Value.ToString();
            txbPlaca.Text = grid.CurrentRow.Cells[6].Value.ToString();
            txbPrefixo.Text = grid.CurrentRow.Cells[7].Value.ToString();


         


            if (SrcFoto.Text == "")
            {
                MessageBox.Show("Se possivel cadastre uma imagem para o produto !");
            }
            else
            {
               pbEditar.Load(grid.CurrentRow.Cells[5].Value.ToString());
            }
        }

        private void pbEditar_Click(object sender, EventArgs e)
        {
            OpenFileDialogEditarVtr.ShowDialog();
            if (OpenFileDialogEditarVtr.FileName != "")
            {
                this.Foto = OpenFileDialogEditarVtr.FileName;
                pbEditar.Load(this.Foto);


                Bitmap bmp = new Bitmap(OpenFileDialogEditarVtr.FileName);
                Bitmap bmp2 = new Bitmap(bmp, pbEditar.Size);
                pbEditar.Image = bmp2;

                pbEditar.Image.Save(Application.StartupPath.ToString() + "\\ImagensVtr\\" + txbPatrimonio.Text + ".png", System.Drawing.Imaging.ImageFormat.Png);
                SrcFoto.Text = Application.StartupPath.ToString() + "\\ImagensVtr\\" + txbPatrimonio.Text + ".png";


            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbPatrimonio.Text = "";
            txbModelo.Text = "";
            cmbLocal.Text = "";
            txbObservacao.Text = "";
            SrcFoto.Text = "";
            txbPlaca.Text = "";
            txbPrefixo.Text = "";
            txbId.Text = "";
           
        }

        private void txbPesquisar_TextChanged(object sender, EventArgs e)
        {
            Pessoas dado = new Pessoas();
            Pesquisar(dado);
            if (txbPesquisar.Text == "")                       // Listar caso o campo esteja vazio
            {
                Listar();
                return;
            }
        }

        public void Pesquisar(Pessoas dado)
        {

            try
            {
                dado.Placa = txbPesquisar.Text;
                grid.DataSource = model.PesquisarVtr(dado);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro com os dados" + ex.Message);

            }
        }

        public void ExcluirVtr(Pessoas dados)
        {
            try
            {
                dados.Patrimonio = txbPatrimonio.Text;


                model.ExcluirVtr(dados);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Excluir " + ex.Message);
            }
        }

        public void ExcluirTodos(Pessoas dados)
        {
            try
            {
                dados.Patrimonio = txbPatrimonio.Text;


                model.ExcluirTodos(dados);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Excluir " + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Pessoas dado = new Pessoas();
            if (txbId.Text == "")
            {
                MessageBox.Show("Selecione um registro na tabela para Excluir!" );
                return;
            }

            else if (MessageBox.Show("Deseja realmente Exluir?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)  // DialogResult.No -> Caso o botão escolhido seja o 2 ele entra no return e não faz nada
            {
                return;
            }

            ExcluirVtr(dado);
            ExcluirTodos(dado);
            ListarVtr();
        }

        public void ListarVtr()
        {
            try
            {
                grid.DataSource = model.ListarVtr(); // alimentar o grid com a tabela todos

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro com os dados" + ex.Message);

            }
        }

        private void EditarViatura_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label14_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
