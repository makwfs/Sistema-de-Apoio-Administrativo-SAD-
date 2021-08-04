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
                        //row.DefaultCellStyle.ForeColor = Color.Green;
                    }
                }

                /*foreach (DataGridViewRow row in grid.Rows)
                {
                    if (Convert.ToInt32(row.Cells[Index ou nome da coluna com o valor].Value) < 0)
                    {
                        // Se for negativo, fica vermelho
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
                
                    DateTime data1 = row.Cells[9].Value;
                    DateTime data2 = Convert.ToDateTime(DATAATUAL.Text); 

                 */


                //grid.Rows[12].Cells["VENCIMENTO"].Style.BackColor = Color.Red;
                //grid.CurrentRow.DefaultCellStyle.BackColor = Color.Yellow;
                // grid.CurrentRow.Cells[0].Style.BackColor = Color.Yellow;

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


        }      
       

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

            

        }

        private void cmbTipo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbTipo.Text == "ACESSO PESSOAS")
            {
                ListarControle();
            }
            if (cmbTipo.Text == "ACESSO VTR")
            {
                ListarControleVTR();
            }
            else if (cmbTipo.Text == "TODOS")
            {
                ListarControleVTR();
            }
        }
        
    }

    
}
