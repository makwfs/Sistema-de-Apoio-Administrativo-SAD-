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
    public partial class CadastroConcluido : Form
    {
        public CadastroConcluido()
        {
            InitializeComponent();
        }

        private void CadastroConcluido_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Close();
        }
    }
}
