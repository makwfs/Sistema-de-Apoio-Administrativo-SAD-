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
    public partial class ControleAcessoPesquisar : Form
    {
        Model.Model model = new Model.Model();
       
        public ControleAcessoPesquisar()
        {
            InitializeComponent();
        }

        //Arrastar janela
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public void ListarControle()
        {
            try
            {
                grid.DataSource = model.ListarControle(); // alimentar o grid


                foreach (DataGridViewRow row in grid.Rows)
                {
                    string RowType = row.Cells[19].Value.ToString();
                    grid.Columns[19].Visible = false;

                    if (RowType == "VENCIDO")
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;                        
                    }
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro com os dados" + ex.Message);

            }
        }

       

        public void ListarControleVTR()
        {
            try
            {
                grid.DataSource = model.ListarControleVTR(); // alimentar o grid 

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro com os dados" + ex.Message);

            }
        }

        


        private void ControleAcessoPesquisar_Load(object sender, EventArgs e)
        {
            ListarControle();
            PREFIXO.Enabled = false;
            cbDATA.Text = DateTime.Now.ToString("dd/MM/yyyy");


        }      
       

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

            

        }

        private void cmbTipo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbTipo.Text == "ACESSO PESSOAS")
            {
                ListarControle();
                PREFIXO.Enabled = false;
            }
            if (cmbTipo.Text == "ACESSO VTR")
            {
                ListarControleVTR();                
                PREFIXO.Enabled = true;
            }
            else if (cmbTipo.Text == "TODOS")
            {
                ListarControleVTR();
            }
        }

        private void RE_TextChanged(object sender, EventArgs e)
        {
            Pessoas dado = new Pessoas();
            Pesquisar(dado);
            if (RE.Text == "")      // Listar caso o campo esteja vazio
            {
                ListarControle();
                return;
            }
            else if (cmbTipo.Text == "ACESSO PESSOA")
            {
                try
                {
                    dado.REControleAcesso1 = RE.Text;

                    /*grid.DataSource = model.PesquisarRE(dado);
                    


                    foreach (DataGridViewRow row in grid.Rows)
                    {
                        string RowType = row.Cells[19].Value.ToString();
                        grid.Columns[19].Visible = false;

                        if (RowType == "VENCIDO")
                        {
                            row.DefaultCellStyle.BackColor = Color.Red;
                        }
                    }*/

                    


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro com os dados" + ex.Message);

                }
            }
            else if (cmbTipo.Text == "ACESSO VTR")
            {
                try
                {
                    dado.REControleAcesso1 = RE.Text;
                    grid.DataSource = model.PesquisarRE(dado);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro com os dados" + ex.Message);

                }
            }
            else if(RE.Text != "")
            {
                
                RG.Enabled = false;
                PREFIXO.Enabled = false;
            }
            

        }

        private void RG_TextChanged(object sender, EventArgs e)
        {
            Pessoas dado = new Pessoas();
            PesquisarRG(dado);
            if (RG.Text == "")      // Listar caso o campo esteja vazio
            {
                ListarControle();
                return;
            }
            else if (cmbTipo.Text == "ACESSO PESSOA")
            {
                try
                {
                    dado.TXBRGControleAcesso1 = RG.Text;
                    grid.DataSource = model.PesquisarRG(dado);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro com os dados" + ex.Message);

                }
            }
            else if (cmbTipo.Text == "ACESSO VTR")
            {
                try
                {
                    dado.TXBRGControleAcesso1 = RG.Text;
                    grid.DataSource = model.PesquisarRG(dado);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro com os dados" + ex.Message);

                }
            }
            else if (RG.Text != "")
            {

                RE.Enabled = false;
                PREFIXO.Enabled = false;
            }
        }

        private void PREFIXO_TextChanged(object sender, EventArgs e)
        {
            Pessoas dado = new Pessoas();
            PesquisarPREFIXO(dado);
            if (PREFIXO.Text == "")      // Listar caso o campo esteja vazio
            {
                ListarControleVTR();
                return;
            }
            else if (cmbTipo.Text == "ACESSO PESSOA")
            {
                try
                {
                    PREFIXO.Enabled = true;
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro com os dados" + ex.Message);

                }
            }
            else if (cmbTipo.Text == "ACESSO VTR")
            {
                try
                {
                    dado.Prefixo = PREFIXO.Text;
                    grid.DataSource = model.PesquisarVTR(dado);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro com os dados" + ex.Message);

                }
            }
            else if (PREFIXO.Text != "")
            {
                RE.Enabled = false;
                RG.Enabled = false;
            }
        }

        public void Pesquisar(Pessoas dado)
        {

            try
            {
                dado.REControleAcesso1 = RE.Text;
                grid.DataSource = model.PesquisarRE(dado);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro com os dados" + ex.Message);

            }
        }

        public void PesquisarRG(Pessoas dado)
        {

            try
            {
                dado.TXBRGControleAcesso1 = RG.Text;
                grid.DataSource = model.PesquisarRG(dado);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro com os dados" + ex.Message);

            }
        }

        public void PesquisarPREFIXO(Pessoas dado)
        {

            try
            {
                dado.Prefixo = PREFIXO.Text;
                grid.DataSource = model.PesquisarVTR(dado);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro com os dados" + ex.Message);

            }
        }

        public void PesquisarDATA(Pessoas dado)
        {

            try
            {
                dado.DATA1 = cbDATA.Text;
                grid.DataSource = model.PesquisarDATA(dado);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro com os dados" + ex.Message);

            }
        }

        public void PesquisarDATAVTR(Pessoas dado)
        {

            try
            {
                dado.DATA1 = cbDATA.Text;
                grid.DataSource = model.PesquisarDATAVTR(dado);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro com os dados" + ex.Message);

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           

            Pessoas dado = new Pessoas();
            PesquisarDATA(dado);
            if (cmbTipo.Text == "ACESSO VTR")      
            {
                PesquisarDATAVTR(dado);
                try
                {
                    dado.Prefixo = cbDATA.Text;
                    grid.DataSource = model.PesquisarDATAVTR(dado);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro com os dados" + ex.Message);

                }
            }            
            else if (cmbTipo.Text == "ACESSO PESSOAS")
            {
                PesquisarDATA(dado);
                try
                {
                    
                    dado.Prefixo = cbDATA.Text;
                    grid.DataSource = model.PesquisarDATA(dado);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro com os dados" + ex.Message);

                }
            }
            
        }

        public void ListarControleDATA(Pessoas dado)
        {
            try
            {
                grid.DataSource = model.ListarControleDATA(dado); // alimentar o grid 

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro com os dados" + ex.Message);

            }
        }

        

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label16_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }

    
}
