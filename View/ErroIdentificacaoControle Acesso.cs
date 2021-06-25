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
    public partial class ErroControle_Acesso : Form
    {
        public ErroControle_Acesso()
        {
            InitializeComponent();
        }

        private void ErroControle_Acesso_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Close();
        }

        private void ErroControle_Acesso_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void ErroControle_Acesso_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void ErroControle_Acesso_MouseClick(object sender, MouseEventArgs e)
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
