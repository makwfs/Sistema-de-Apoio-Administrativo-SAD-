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
    public partial class CadastrarMaterialBelico : Form
    {
        public CadastrarMaterialBelico()
        {
            InitializeComponent();
        }

        private void cmbTipoInformatica_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmbModelo.Items.Add("sdfsdf");
        }
    }


    // fazer classe e depois chamar ela no cmb

   

}
