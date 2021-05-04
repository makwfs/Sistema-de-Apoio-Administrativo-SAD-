using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMysql.View
{
    public partial class EditarMaterialBelico : Form
    {

        Model.Model model = new Model.Model();
        public string Foto = "";
        public EditarMaterialBelico()
        {
            InitializeComponent();
        }

        private void gridEditarTmd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pegando os dados do grid e jogando nas texbox 
            // O valor contido em Cells[] corresponde as colunas das tabelas
            txbId.Text = gridEditarTmd.CurrentRow.Cells[0].Value.ToString();
            txbPatrimonio.Text = gridEditarTmd.CurrentRow.Cells[1].Value.ToString();
            cmbTipo.Text = gridEditarTmd.CurrentRow.Cells[4].Value.ToString();
            cmbModelo.Text = gridEditarTmd.CurrentRow.Cells[2].Value.ToString();
            txbSerial.Text = gridEditarTmd.CurrentRow.Cells[3].Value.ToString();
            
            txbPatrimonioPm.Text = gridEditarTmd.CurrentRow.Cells[5].Value.ToString();
            txbObservacao.Text = gridEditarTmd.CurrentRow.Cells[6].Value.ToString();
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
    }
}
