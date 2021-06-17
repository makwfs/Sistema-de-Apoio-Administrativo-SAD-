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
    public partial class ControleAcesso : Form
    {
        public ControleAcesso()
        {
            InitializeComponent();
        }

        //Arrastar janela
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void button1_Click(object sender, EventArgs e)
        {
            ControleAcessoCadastro form = new ControleAcessoCadastro();
            form.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label16_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void RE_TextChanged(object sender, EventArgs e)
        {
            if (CBRE.Text != "")
            {

                ListarTmd();

            }
        }
        public void ListarTmd()
        {
            try
            {
               // grid.DataSource = model.ListarTmd(); // alimentar o grid 

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro com os dados" + ex.Message);

            }
        }

        private void RE_Enter(object sender, EventArgs e)
        {
            //PESQUISAR AO APERTAR ENTER
        }
    }
}

