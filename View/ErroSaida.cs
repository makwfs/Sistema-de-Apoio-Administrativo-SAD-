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
    public partial class ErroSaida : Form
    {
        public ErroSaida()
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

        private void ErroSaida_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Close();
        }
    }
}
