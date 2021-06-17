using System;
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
    public partial class TelaConsultarInformatica : Form
    {
        Model.Model model = new Model.Model();
        public string Foto = "";

        public TelaConsultarInformatica()
        {
            InitializeComponent();
        }

        //Arrastar janela
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void TelaConsultar_Load(object sender, EventArgs e)  // carregar o grid com os dados do BD assim que abrir a tela
        {
           ListarTodos();
        }

        public void Listar()
        {
            try
            {
                grid.DataSource = model.Listar(); // alimentar o grid 
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro com os dados" + ex.Message);
             
            }
        }

        public void ListarTmd()
        {
            try
            {
                grid.DataSource = model.ListarTmd(); // alimentar o grid 

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro com os dados" + ex.Message);

            }
        }

        public void ListarPc()
        {
            try
            {
                grid.DataSource = model.ListarPc(); // alimentar o grid 

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro com os dados" + ex.Message);

            }
        }

        public void ListarImpressora()
        {
            try
            {
                grid.DataSource = model.ListarImpressora(); // alimentar o grid 

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro com os dados" + ex.Message);

            }
        }

        public void ListarrRadio()
        {
            try
            {
                grid.DataSource = model.ListarRadio(); // alimentar o grid 

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro com os dados" + ex.Message);

            }
        }

        public void ListarTodos()
        {
            try
            {
                grid.DataSource = model.ListarTodos(); // alimentar o grid 

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro com os dados" + ex.Message);

            }
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
            else if (cmbTipo.Text == "TMD")
            {
                try
                {
                    dado.PatrimonioInfo = txbPesquisar.Text;
                    grid.DataSource = model.PesquisarTmd(dado);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro com os dados" + ex.Message);

                }
            }
            else if (cmbTipo.Text == "COMPUTADOR")
            {
                try
                {
                    dado.PatrimonioInfo = txbPesquisar.Text;
                    grid.DataSource = model.PesquisarPc(dado);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro com os dados" + ex.Message);

                }
            }
            else if (cmbTipo.Text == "RÁDIO")
            {
                try
                {
                    dado.PatrimonioInfo = txbPesquisar.Text;
                    grid.DataSource = model.PesquisarRadio(dado);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro com os dados" + ex.Message);

                }
            }
            else if (cmbTipo.Text == "IMPRESSORA")
            {
                try
                {
                    dado.PatrimonioInfo = txbPesquisar.Text;
                    grid.DataSource = model.PesquisarImpressora(dado);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro com os dados" + ex.Message);

                }
            }

        }

        public void Pesquisar(Pessoas dado)
        {
            
            try
            {
                dado.PatrimonioInfo = txbPesquisar.Text;
                grid.DataSource = model.PesquisarTmd(dado); 

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro com os dados" + ex.Message);

            }
        }

       

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {




            if (cmbTipo.Text== "TMD")
            {

                ListarTmd();

            }
            else if (cmbTipo.Text == "COMPUTADOR")
            {
                ListarPc();
            }
            else if (cmbTipo.Text == "TODOS")
            {
                ListarTodos();
               
            }
            else if (cmbTipo.Text == "IMPRESSORA")
            {
                ListarImpressora();
            }
            else if (cmbTipo.Text =="RÁDIO")
            {
                ListarrRadio();
            }
            
        }

       

        
     

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Pegando os dados do grid e jogando nas texbox 
            // O valor contido em Cells[] corresponde as colunas das tabelas
            txbId.Text = grid.CurrentRow.Cells[0].Value.ToString();
            txbPatrimonio.Text = grid.CurrentRow.Cells[1].Value.ToString();
            txbModelo.Text = grid.CurrentRow.Cells[2].Value.ToString();
            txbSerial.Text = grid.CurrentRow.Cells[3].Value.ToString();
            cmbLocal.Text = grid.CurrentRow.Cells[4].Value.ToString();
            txbPatrimonioPm.Text = grid.CurrentRow.Cells[5].Value.ToString();
            txbObservacaoTmd.Text = grid.CurrentRow.Cells[6].Value.ToString();
            SrcConsultar.Text = grid.CurrentRow.Cells[7].Value.ToString();


                       

            if (SrcConsultar.Text == "")
            {
                MessageBox.Show("Material sem Imagem, Favor cadastrar atraves da aba editar !");
            }
            else
            {
                pbConsultar.Load(grid.CurrentRow.Cells[7].Value.ToString());
            }
            


        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TelaConsultar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pbConsultar_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
