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

namespace SistemaMysql.View
{
    public partial class TelaConsultar : Form
    {
        PessoaModel model = new PessoaModel();
        public TelaConsultar()
        {
            InitializeComponent();
        }

        private void TelaConsultar_Load(object sender, EventArgs e)
        {
            Listar();
        }

        public void Listar()
        {
            try
            {
                grid.DataSource = model.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro com os dados" + ex.Message);
             
            }
        }
    }
}
