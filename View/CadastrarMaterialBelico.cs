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
            if (cmbTipo.Text == "ALGEMA")
            {
                cmbModelo.Items.Clear();
                cmbModelo.Text = "";
                string[] algema = new string[]
             {
                   "ALGEMA DE AÇO"

             };
             cmbModelo.Items.AddRange(algema);

            }
            else if (cmbTipo.Text == "ARMA")
            {
                cmbModelo.Items.Clear();
                cmbModelo.Text = "";
                string[] armas = new string[]
                {
                    "PISTOLA GLOCK G22 G5 .40",
                    "PISTOLA CAL .40 PT-640",
                    "PISTOLA .40 - 24/7 PRO",
                    "PISTOLA .40 24/7 PRO TACT"
                       
                };
                cmbModelo.Items.AddRange(armas);              
                                               
            }
            else if (cmbTipo.Text == "COLETE")
            {
                cmbModelo.Items.Clear();
                cmbModelo.Text = "";
                string[] colete = new string[]
                {
                    
                    "CBC"

                };
                cmbModelo.Items.AddRange(colete);
            }
        }

        private void cmbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {

            

        }

        private void CadastrarMaterialBelico_Load(object sender, EventArgs e)
        {

         

        }

       
    }


    // fazer classe e depois chamar ela no cmb

   

}
