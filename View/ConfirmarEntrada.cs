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
    public partial class ConfirmarEntrada : Form
    {
        public ConfirmarEntrada()
        {
            InitializeComponent();
        }

        private void ConfirmarEntrada_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void ConfirmarEntrada_Load(object sender, EventArgs e)
        {
            
        }

        private void ConfirmarEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Close();
        }

        private void ConfirmarEntrada_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
