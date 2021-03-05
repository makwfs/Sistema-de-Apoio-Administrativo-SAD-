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
using SistemaMysql.Model;
using System.Runtime.InteropServices;   // Biblioteca para arrastar tela

namespace SistemaMysql.View
{
    public partial class EditarUsuario : Form
    {
        Model.Model model = new Model.Model();

        public EditarUsuario()
        {
            InitializeComponent();
        }

        //Arrastar janela
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void gridEditarTmd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pegando os dados do grid e jogando nas texbox 
            // O valor contido em Cells[] corresponde as colunas das tabelas
            txbId.Text = grid.CurrentRow.Cells[0].Value.ToString();
            txbRE.Text = grid.CurrentRow.Cells[1].Value.ToString();
            txbNome.Text = grid.CurrentRow.Cells[2].Value.ToString();
            txbEmail.Text = grid.CurrentRow.Cells[4].Value.ToString();
            cmbFunção.Text = grid.CurrentRow.Cells[5].Value.ToString();
            txbSenha.Text = grid.CurrentRow.Cells[3].Value.ToString();



        }

        public void ListarUsuario()
        {
            try
            {
                grid.DataSource = model.ListarUsuario(); // alimentar o grid com a tabela tmd

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro com os dados" + ex.Message);

            }
        }

        private void groupBoxTmd_Enter(object sender, EventArgs e)
        {

        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            ListarUsuario();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void EditarUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void ExcluirUsuario(Pessoas dado)
        {
            try
            {
                dado.Id = Convert.ToInt32(txbId.Text);


                model.ExcluirUsuario(dado);

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
                MessageBox.Show("Selecione um registro na tabela para Excluir!");
                return;
            }

            else if (MessageBox.Show("Deseja realmente Exluir?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)  // DialogResult.No -> Caso o botão escolhido seja o 2 ele entra no return e não faz nada
            {
                return;
            }
            else
            {
                ExcluirUsuario(dado);
                ListarUsuario();
            }
        }

        public void EditarUser(User dado)
        {


            try
            {
                dado.Id = Convert.ToInt32(txbId.Text);
                dado.RE = txbRE.Text;
                dado.Nome = txbNome.Text;
                dado.EMAIL = txbEmail.Text;
                dado.Função = cmbFunção.Text;
                dado.Senha = txbSenha.Text;



                model.EditarUsuario(dado);
                MessageBox.Show("Salvo com Sucesso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar " + ex.Message);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            User dado = new User();

            EditarUser(dado);
            ListarUsuario();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            User dado = new User();
           
           // PesquisarUsuario(dado);
            if (txbPesquisar.Text == "")                       // Listar caso o campo esteja vazio
            {
                ListarUsuario();
                return;
            }
            else
            {
                try
                {
                    dado.RE = txbPesquisar.Text;
                    grid.DataSource = model.PesquisarUsuario(dado);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro com os dados" + ex.Message);

                }
            }
        }

        
        /*public void PesquisarUsuario(User dado)
        {

            try
            {
                dado.RE = txbPesquisar.Text;
                grid.DataSource = model.PesquisarUsuario(dado);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro com os dados" + ex.Message);

            }
        }*/
    }
}
