using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaMysql.Cache;
using System.Runtime.InteropServices;   // Biblioteca para arrastar tela

namespace SistemaMysql.View
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        //Arrastar janela
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnCadastrarInicial_Click(object sender, EventArgs e)
        {
            TelaInicial form = new TelaInicial();
            form.Show();
        }

        private void btnPesquisarInicial_Click(object sender, EventArgs e)
        {
            TelaConsultarInformatica form = new TelaConsultarInformatica();
            form.Show();


        }

        private void btnEditarInicial_Click(object sender, EventArgs e)
        {
            EditarInformatica form = new EditarInformatica();
            form.Show();

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo Sair ?", "                        ATENÇÃO !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void tmdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarInformatica form = new CadastrarInformatica();
            form.Show();
        }

        private void LoadUserData()
        {

          
            lbNome.Text = UserLoginCache.Nome;
            lbFunção.Text = UserLoginCache.Função;

        }
       
        

        private void tmdToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditarInformatica form = new EditarInformatica();
            form.Show();
        }

        private void pictureBox47bpmi_Click(object sender, EventArgs e)
        {

        }

        private void TelaInicial_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox47bpmi_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void viaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarVtr form = new CadastrarVtr();
            form.Show();
        }

        private void informáticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaConsultarInformatica form = new TelaConsultarInformatica();
            form.Show();
        }

        private void viaturaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EditarViatura form = new EditarViatura();
            form.Show();
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            LoadUserData();


            //Controle de Funções
            if (UserLoginCache.Função == UserFunção.P1)
            {
                AbaP2.Enabled = false;
                AbaP3.Enabled = false;
                AbaP4.Enabled = false;
                AbaGuarda.Enabled = false;
                AbaReservaArmas.Enabled = false;
                AbaTelematica.Enabled = false;
            }
            else if (UserLoginCache.Função == UserFunção.P2)
            {
                AbaP1.Enabled = false;
                AbaP3.Enabled = false;
                AbaP4.Enabled = false;
                AbaGuarda.Enabled = false;
                AbaReservaArmas.Enabled = false;
                AbaTelematica.Enabled = false;
            }
            else if (UserLoginCache.Função == UserFunção.P3)
            {
                AbaP1.Enabled = false;
                AbaP2.Enabled = false;
                AbaP4.Enabled = false;
                AbaGuarda.Enabled = false;
                AbaReservaArmas.Enabled = false;
                AbaTelematica.Enabled = false;
            }
            else if (UserLoginCache.Função == UserFunção.P4)
            {
                AbaP1.Enabled = false;
                AbaP3.Enabled = false;
                AbaP2.Enabled = false;
                AbaGuarda.Enabled = false;
                AbaReservaArmas.Enabled = false;
                AbaTelematica.Enabled = false;
            }
            else if (UserLoginCache.Função == UserFunção.GUARDA)
            {
                AbaP1.Enabled = false;
                AbaP3.Enabled = false;
                AbaP4.Enabled = false;
                AbaP2.Enabled = false;
                AbaReservaArmas.Enabled = false;
                AbaTelematica.Enabled = false;
            }
            else if (UserLoginCache.Função == UserFunção.RESERVADEARMAS)
            {
                AbaP1.Enabled = false;
                AbaP3.Enabled = false;
                AbaP4.Enabled = false;
                AbaGuarda.Enabled = false;
                AbaP2.Enabled = false;
                AbaTelematica.Enabled = false;
            }
            else if (UserLoginCache.Função == UserFunção.SF)
            {
                AbaP1.Enabled = false;
                AbaP2.Enabled = false;
                AbaP3.Enabled = false;
                AbaP4.Enabled = false;
                AbaGuarda.Enabled = false;
                AbaP2.Enabled = false;
                AbaTelematica.Enabled = false;
                AbaReservaArmas.Enabled = false;
            }

        }

        private void controleDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarUsuario form = new EditarUsuario();
            form.Show();
        }

        private void viaturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaConsultarVtr form = new TelaConsultarVtr();
            form.Show();
        }

        private void materialBélicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarMaterialBelico form = new CadastrarMaterialBelico();
            form.Show();
        }

        private void materialBélicoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditarMaterialBelico form = new EditarMaterialBelico();
            form.Show();
        }
    }
    }

