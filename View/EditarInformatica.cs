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
    public partial class EditarInformatica : Form
    {
        Model.Model model = new Model.Model();
        public string Foto = "";
        
        Conexao con = new Conexao();

        public EditarInformatica()
        {
            InitializeComponent();
        }

        //Arrastar janela
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


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
                gridEditarTmd.DataSource = model.Listar(); // alimentar o grid com a tabela tmd

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
                gridEditarTmd.DataSource = model.ListarPc(); // alimentar o grid com a tabela pc

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
                gridEditarTmd.DataSource = model.ListarImpressora(); // alimentar o grid com a tabela pc

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro com os dados" + ex.Message);

            }
        }

        public void ListarRadio()
        {
            try
            {
                gridEditarTmd.DataSource = model.ListarRadio(); // alimentar o grid com a tabela pc

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
                gridEditarTmd.DataSource = model.ListarTodos(); // alimentar o grid com a tabela todos

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro com os dados" + ex.Message);

            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Pessoas dado = new Pessoas();

            if (txbId.Text == "")
            {
                MessageBox.Show("Selecione um registro na tabela para prosseguir com a edição!");
                return;
            }
            else if (cmbEditarTipo.Text == "COMPUTADOR")
            {
                EditarDadosPc(dado);
                ListarPc();
            }
            else if (cmbEditarTipo.Text =="IMPRESSORA")
            {
                EditarDadosImpressora(dado);
                ListarImpressora();
            }
            else if (cmbEditarTipo.Text == "RÁDIO")
            {
                EditarDadosRadio(dado);
                ListarRadio();
            }
            else
            {
                EditarDadosTmd(dado);
                Listar();
            }
            
        }

        public void EditarDadosTmd(Pessoas dados)
        {
            try
            {
                dados.Id = Convert.ToInt32(txbId.Text);
                dados.Patrimonio = txbPatrimonio.Text;
                dados.Modelo = txbModelo.Text;
                dados.Serial = txbSerial.Text;
                dados.Local = cmbLocal.Text;
                dados.PatrimonioPM = txbPatrimonioPm.Text;
                dados.Observacao = txbObservacaoTmd.Text;
                dados.SrcEditarFoto = SrcFoto.Text;



                model.EditarDadosTmd(dados);
                MessageBox.Show("Salvo com Sucesso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar  EEEE" + ex.Message);
            }
        }

        public void EditarDadosImpressora(Pessoas dados)
        {
            try
            {
                dados.Id = Convert.ToInt32(txbId.Text);
                dados.Patrimonio = txbPatrimonio.Text;
                dados.Modelo = txbModelo.Text;
                dados.Serial = txbSerial.Text;
                dados.Local = cmbLocal.Text;
                dados.PatrimonioPM = txbPatrimonioPm.Text;
                dados.Observacao = txbObservacaoTmd.Text;
                dados.SrcEditarFoto = SrcFoto.Text;



                model.EditarDadosImpressora(dados);
                MessageBox.Show("Salvo com Sucesso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar  EEEE" + ex.Message);
            }
        }

        public void EditarDadosPc(Pessoas dados)
        {
            try
            {
                dados.Id = Convert.ToInt32(txbId.Text);
                dados.Patrimonio = txbPatrimonio.Text;
                dados.Modelo = txbModelo.Text;
                dados.Serial = txbSerial.Text;
                dados.Local = cmbLocal.Text;
                dados.PatrimonioPM = txbPatrimonioPm.Text;
                dados.Observacao = txbObservacaoTmd.Text;
                dados.SrcEditarFoto = SrcFoto.Text;



                model.EditarDadosPc(dados);
                MessageBox.Show("Salvo com Sucesso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar" + ex.Message);
            }
        }

        public void EditarDadosRadio(Pessoas dados)
        {
            try
            {
                dados.Id = Convert.ToInt32(txbId.Text);
                dados.Patrimonio = txbPatrimonio.Text;
                dados.Modelo = txbModelo.Text;
                dados.Serial = txbSerial.Text;
                dados.Local = cmbLocal.Text;
                dados.PatrimonioPM = txbPatrimonioPm.Text;
                dados.Observacao = txbObservacaoTmd.Text;
                dados.SrcEditarFoto = SrcFoto.Text;



                model.EditarDadosRadio(dados);
                MessageBox.Show("Salvo com Sucesso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar" + ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbSerial.Text = "";
            txbPatrimonio.Text = "";
            txbObservacaoTmd.Text = "";
            txbModelo.Text = "";
            cmbLocal.Text = "";
            txbPatrimonioPm.Text = "";
            txbId.Text = "";
        }

       

        public void ExcluirTmd(Pessoas dados) 
        {
            try
            {
                dados.Patrimonio = txbPatrimonio.Text;


                model.ExcluirTmd(dados);
               
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Excluir " + ex.Message);
            }
        }

        public void ExcluirPc(Pessoas dados)
        {
            try
            {
                dados.Patrimonio = txbPatrimonio.Text;


                model.ExcluirPc(dados);
                MessageBox.Show("Excluido com Sucesso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Excluir " + ex.Message);
            }
        }

        public void ExcluirRadio(Pessoas dados)
        {
            try
            {
                dados.Patrimonio = txbPatrimonio.Text;


                model.ExcluirRadio(dados);
              
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
                else if(cmbEditarTipo.Text == "TMD")
                {
                    try
                    {
                        dado.PatrimonioInfo = txbPesquisar.Text;
                        gridEditarTmd.DataSource = model.PesquisarTmd(dado);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro com os dados" + ex.Message);

                    }
                }
                else if (cmbEditarTipo.Text == "COMPUTADOR")
                {
                    try
                    {
                        dado.PatrimonioInfo = txbPesquisar.Text;
                        gridEditarTmd.DataSource = model.PesquisarPc(dado);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro com os dados" + ex.Message);

                    }
                }
                else if (cmbEditarTipo.Text == "RÁDIO")
                {
                    try
                    {
                        dado.PatrimonioInfo = txbPesquisar.Text;
                        gridEditarTmd.DataSource = model.PesquisarRadio(dado);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro com os dados" + ex.Message);

                    }
                }
                else
                {
                    try
                    {
                        dado.PatrimonioInfo = txbPesquisar.Text;
                        gridEditarTmd.DataSource = model.PesquisarImpressora(dado);

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
                dado.PatrimonioInfo = txbPesquisar.Text;
                gridEditarTmd.DataSource = model.PesquisarTmd(dado);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro com os dados" + ex.Message);

            }
        }
        public void PesquisarPc(Pessoas dado)
        {

            try
            {
                dado.PatrimonioInfo = txbPesquisar.Text;
                gridEditarTmd.DataSource = model.PesquisarPc(dado);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro com os dados" + ex.Message);

            }
        }


        private void pbEditarTmd_Click_1(object sender, EventArgs e)
        {
            OpenFileDialogEditarTmd.ShowDialog();
            if (OpenFileDialogEditarTmd.FileName != "")
            {
                this.Foto = OpenFileDialogEditarTmd.FileName;
                pbEditar.Load(this.Foto);
                

                Bitmap bmp = new Bitmap(OpenFileDialogEditarTmd.FileName);
                Bitmap bmp2 = new Bitmap(bmp, pbEditar.Size);
                pbEditar.Image = bmp2;

                pbEditar.Image.Save(Application.StartupPath.ToString() + "\\ImagensTmd\\" + txbPatrimonio.Text + ".png", System.Drawing.Imaging.ImageFormat.Png);
                SrcFoto.Text = Application.StartupPath.ToString() + "\\ImagensTmd\\" + txbPatrimonio.Text + ".png";


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
            txbPatrimonio.Text = gridEditarTmd.CurrentRow.Cells[1].Value.ToString();
            txbModelo.Text = gridEditarTmd.CurrentRow.Cells[2].Value.ToString();
            txbSerial.Text = gridEditarTmd.CurrentRow.Cells[3].Value.ToString();
            cmbLocal.Text = gridEditarTmd.CurrentRow.Cells[4].Value.ToString();
            txbPatrimonioPm.Text = gridEditarTmd.CurrentRow.Cells[5].Value.ToString();
            txbObservacaoTmd.Text = gridEditarTmd.CurrentRow.Cells[6].Value.ToString();
            SrcFoto.Text = gridEditarTmd.CurrentRow.Cells[7].Value.ToString();

            if (SrcFoto.Text == "")
            {
                MessageBox.Show("Se possivel cadastre uma imagem para o produto !");
            }
            else
            {
                pbEditar.Load(gridEditarTmd.CurrentRow.Cells[7].Value.ToString());
            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEditarTipo.Text == "COMPUTADOR")
            {
                ListarPc();
            }
            else if (cmbEditarTipo.Text =="TODOS")
            {
                ListarTodos();
            }
            else if(cmbEditarTipo.Text == "IMPRESSORA")
            {
                ListarImpressora();
            }
            else if (cmbEditarTipo.Text =="RÁDIO")
            {
                ListarRadio();
            }
            else
            {
                Listar();
            }
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {

            Pessoas dado = new Pessoas();
            if (txbId.Text == "")
            {
                MessageBox.Show("Selecione um registro na tabela para Excluir!");
                return;
            }

            else if (MessageBox.Show("Deseja realmente Exluir?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)  // DialogResult.No -> Caso o botão escolhido seja o 2 ele entra no return e não faz nada
            {
                return;
            }
            
            if (cmbEditarTipo.Text == "TMD")
            {
                ExcluirTmd(dado);
                ExcluirTodos(dado);
                Listar();
            }
            else if (cmbEditarTipo.Text == "COMPUTADOR")
            {
                ExcluirPc(dado);
                ExcluirTodos(dado);
                ListarPc();
            }
            else if (cmbEditarTipo.Text == "TODOS")
            {
                ExcluirTodos(dado);
                ListarTodos();
            }
            else if (cmbEditarTipo.Text == "RÁDIO")
            {
                ExcluirTodos(dado);
                ExcluirRadio(dado);
                ListarRadio();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void EditarInformatica_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label14_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void pbEditar_Click(object sender, EventArgs e)
        {

        }
    }

}
