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
    public partial class ConfirmarSaida : Form
    {
        public ConfirmarSaida()
        {
            InitializeComponent();
        }

        //FECHAR FORM AO APERTAR ESC
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                this.Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ConfirmarSaida_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Close();
        }
    }
}
