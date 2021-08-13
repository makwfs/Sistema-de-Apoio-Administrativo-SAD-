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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           

            Pessoas dado = new Pessoas();
            PesquisarDATA(dado);
            if (cbDATA.Text == "")      // Listar caso o campo esteja vazio
            {

                ListarControleDATA(dado);
                return;
            }            
            else if (cmbTipo.Text != "")
            {
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

        private void cbDATA_KeyPress(object sender, KeyPressEventArgs e)
        {
            // MessageBox.Show(" Até Aqui OK!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //ListarControleDATA();
        }
    }

    
}
