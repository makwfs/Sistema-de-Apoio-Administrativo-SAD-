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
    }

    
}
