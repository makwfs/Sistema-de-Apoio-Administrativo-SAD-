using SistemaMysql.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SistemaMysql;
using SistemaMysql.Model;
using SistemaMysql.Entidades;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;   // Biblioteca para arrastar tela

namespace SistemaMysql.View
{
    public partial class ControleAcessoCadastro : Form
    {
        
        Model.Model model = new Model.Model();
        public string Foto = "";
        String imgLoc = "";
        MySqlCommand sql;
        Conexao con = new Conexao();
        public ControleAcessoCadastro()
        {
            InitializeComponent();
        }



        //Arrastar janela
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        

        public void CadastroControleAcesso(Pessoas dados)     // capturando dados dos textbox
        {


            try
            {
                dados.NomeControleAcesso = NOME.Text;
                dados.REControleAcesso1 = TXBRE.Text;
                dados.POSTOGRADControleAcesso1 = CBPOSTOGRAD.Text;
                dados.TXBRGControleAcesso1 = TXBRG.Text;
                dados.UNIDADEControleAcesso1 = UNIDADE.Text;
                dados.CIAControleAcesso1 = CBCIA.Text;
                dados.SECAOControleAcesso1 = CBSECAO.Text;
                dados.NCARTAOontroleAcesso1 = NCARTAO.Text;
                dados.VENCIMENTOControleAcesso1 = DATAVENCIMENTO.Text;
                dados.MARCAControleAcesso1 = TXBMARCA.Text;
                dados.MODELOControleAcesso1 = MODELOVEICULO.Text;
                dados.EMPLACAMENTOControleAcesso1 = EMPLACAMENTO.Text;
                dados.CIDADEControleAcesso1 = CIDADE.Text;
                dados.CORControleAcesso1 = COR.Text;
                


                model.CadastroControleAcesso(dados);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar " + ex.Message);
            }
        }

        private void DATA_TextChanged(object sender, EventArgs e)
        {
            string Date = DateTime.Now.ToString("dd-MM-yyyy");
            Console.WriteLine("The Current Date Without Time is {0}.", Date);
            //DATA.Text == Date;
        }

        

        private void DATAATUAL_Click(object sender, EventArgs e)
        {

        }

        private void HORAATUAL_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NOME.Text = "";
            TXBRE.Text = "";
            CBPOSTOGRAD.Text = "";
            TXBRG.Text = "";
            UNIDADE.Text = "";
            CBCIA.Text = "";
            CBSECAO.Text = "";
            NCARTAO.Text = "";
            DATAVENCIMENTO.Text = "";
            TXBMARCA.Text = "";
            MODELOVEICULO.Text = "";
            EMPLACAMENTO.Text = "";
            CIDADE.Text = "";
            COR.Text = "";
            PCFOTO.Image = SistemaMysql.Properties.Resources.police;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
       
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ControleAcessoCadastro_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ControleAcessoBtnFoto_Click(object sender, EventArgs e)
        {
            // Carregando imagem na tela

            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files(*.jpg)|*.jpg|GIF Files(*.gif)|*.gif|All Files(*.*)|*.*";
                dlg.Title = "Select Employee Picture";
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    PCFOTO.ImageLocation = imgLoc;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
            
            
            
            /* if(OpenFileDialogFoto.ShowDialog() == DialogResult.OK)  // Dar prosseguimento apenas se o usuário escolher uma foto
            {
                this.Foto = OpenFileDialogFoto.FileName;
                CADASTROFOTO.Load(this.Foto);





                Bitmap bmp = new Bitmap(OpenFileDialogFoto.FileName);
                Bitmap bmp2 = new Bitmap(bmp, CADASTROFOTO.Size);

                CADASTROFOTO.Image = bmp2;
                CADASTROFOTO.Image.Save(Application.StartupPath.ToString() + "\\FotosCadastro\\" + NOME.Text + ".png", System.Drawing.Imaging.ImageFormat.Png);
            }            
            else
            {                
                return;
            }  */          

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ControleAcessoBtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {

                byte[] img = null;
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                con.Conectar();
                sql = new MySqlCommand("INSERT INTO cadastroguarda ( NOME, RE, POSTO, RG, UNIDADE, CIA, SEÇÃO, CARTÃO, VENCIMENTO, MARCA, MODELO, EMPLACAMENTO, CIDADE, COR, FOTO)" +
                    " values ( @NOME, @RE, @POSTO, @RG, @UNIDADE, @CIA, @SEÇÃO, @CARTÃO, @VENCIMENTO, @MARCA, @MODELO, @EMPLACAMENTO, @CIDADE, @COR, @FOTO )", con.con);  // inclusão de dados no BD pessoa

                sql.Parameters.AddWithValue("@NOME", NOME.Text);
                sql.Parameters.AddWithValue("@RE", TXBRE.Text);
                sql.Parameters.AddWithValue("@POSTO", CBPOSTOGRAD.Text);
                sql.Parameters.AddWithValue("@RG", TXBRG.Text);
                sql.Parameters.AddWithValue("@UNIDADE", UNIDADE.Text);
                sql.Parameters.AddWithValue("@CIA", CBCIA.Text);
                sql.Parameters.AddWithValue("@SEÇÃO", CBSECAO.Text);
                sql.Parameters.AddWithValue("@CARTÃO", NCARTAO.Text );
                sql.Parameters.AddWithValue("@VENCIMENTO", DATAVENCIMENTO.Text);
                sql.Parameters.AddWithValue("@MARCA", TXBMARCA.Text);
                sql.Parameters.AddWithValue("@MODELO", MODELOVEICULO.Text);
                sql.Parameters.AddWithValue("@EMPLACAMENTO", EMPLACAMENTO.Text);
                sql.Parameters.AddWithValue("@CIDADE", CIDADE.Text);
                sql.Parameters.AddWithValue("@COR", COR.Text);
                sql.Parameters.AddWithValue("@FOTO", img );
                sql.ExecuteNonQuery();


                //Insert na tabela de Status usando o LAST_INSERT_ID
                sql = new MySqlCommand("INSERT INTO status ( NOME, RE, RG, STATUS, fk_id_ES)  values (@NOME, @RE, @RG, @STATUS, LAST_INSERT_ID())", con.con);
                sql.Parameters.AddWithValue("@NOME", NOME.Text);
                sql.Parameters.AddWithValue("@RE", TXBRE.Text);
                sql.Parameters.AddWithValue("@RG", TXBRG.Text);
                sql.Parameters.AddWithValue("@STATUS", " DESCANSANDO ");
                sql.ExecuteNonQuery();
                con.FecharConexao();                                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar" + ex);
                //MessageBox.Show("O número de patrimônio inserido já esta cadastrado! Verifique o numéro e tente novamente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.FecharConexao();
            }            
            CadastroConcluido form = new CadastroConcluido();
            form.Show();
            ReloadForm();
        }

        public void ReloadForm()
        {
            //STATUS.ResetText();
            RE.Text = "";
            RG.Text = "";
            NCARTAO.Text = "";
            PREFIXO.Text = "";
            ID.Text = "";
            NOME.Text = "";
            TXBRE.Text = "";
            CBPOSTOGRAD.Text = "";
            TXBRG.Text = "";
            UNIDADE.Text = "";
            CBCIA.Text = "";
            CBSECAO.Text = "";
            NCARTAO.Text = "";
            DATAVENCIMENTO.Text = "";
            TXBMARCA.Text = "";
            MODELOVEICULO.Text = "";
            EMPLACAMENTO.Text = "";
            CIDADE.Text = "";
            COR.Text = "";            
            PCFOTO.Image = SistemaMysql.Properties.Resources.police;

        }
    }        
    
}
