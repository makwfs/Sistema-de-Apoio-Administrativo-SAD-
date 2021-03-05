
namespace SistemaMysql.View
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txtRE = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnAcessar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbErro = new System.Windows.Forms.Label();
            this.CadastreSe = new System.Windows.Forms.LinkLabel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(136)))), ((int)(((byte)(253)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 299);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaMysql.Properties.Resources.logo_Login;
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(764, 299);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.Enabled = false;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 493;
            this.lineShape3.X2 = 493;
            this.lineShape3.Y1 = 269;
            this.lineShape3.Y2 = 253;
            // 
            // lineShape2
            // 
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.SelectionColor = System.Drawing.Color.DimGray;
            this.lineShape2.X1 = 272;
            this.lineShape2.X2 = 743;
            this.lineShape2.Y1 = 148;
            this.lineShape2.Y2 = 148;
            // 
            // lineShape1
            // 
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.SelectionColor = System.Drawing.Color.DimGray;
            this.lineShape1.X1 = 272;
            this.lineShape1.X2 = 743;
            this.lineShape1.Y1 = 90;
            this.lineShape1.Y2 = 90;
            // 
            // txtRE
            // 
            this.txtRE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtRE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRE.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRE.ForeColor = System.Drawing.Color.DimGray;
            this.txtRE.Location = new System.Drawing.Point(273, 64);
            this.txtRE.Name = "txtRE";
            this.txtRE.Size = new System.Drawing.Size(472, 22);
            this.txtRE.TabIndex = 2;
            this.txtRE.Text = "RE";
            this.txtRE.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtRE.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtRE.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.DimGray;
            this.txtSenha.Location = new System.Drawing.Point(272, 122);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(472, 22);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.Text = "SENHA";
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // btnAcessar
            // 
            this.btnAcessar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAcessar.FlatAppearance.BorderSize = 0;
            this.btnAcessar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAcessar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcessar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAcessar.Location = new System.Drawing.Point(273, 204);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(470, 40);
            this.btnAcessar.TabIndex = 4;
            this.btnAcessar.Text = "ACESSAR";
            this.btnAcessar.UseVisualStyleBackColor = false;
            this.btnAcessar.Click += new System.EventHandler(this.btnAcessar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(136)))), ((int)(((byte)(253)))));
            this.label1.Location = new System.Drawing.Point(443, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "LOGIN";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(136)))), ((int)(((byte)(253)))));
            this.linkLabel1.Location = new System.Drawing.Point(501, 257);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(119, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Esqueceu sua senha ?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lbErro
            // 
            this.lbErro.AutoSize = true;
            this.lbErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErro.ForeColor = System.Drawing.Color.Red;
            this.lbErro.Location = new System.Drawing.Point(270, 157);
            this.lbErro.Name = "lbErro";
            this.lbErro.Size = new System.Drawing.Size(196, 17);
            this.lbErro.TabIndex = 9;
            this.lbErro.Text = "Usuário ou Senha incorretos !";
            this.lbErro.Visible = false;
            // 
            // CadastreSe
            // 
            this.CadastreSe.AutoSize = true;
            this.CadastreSe.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastreSe.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(136)))), ((int)(((byte)(253)))));
            this.CadastreSe.Location = new System.Drawing.Point(419, 257);
            this.CadastreSe.Name = "CadastreSe";
            this.CadastreSe.Size = new System.Drawing.Size(67, 13);
            this.CadastreSe.TabIndex = 5;
            this.CadastreSe.TabStop = true;
            this.CadastreSe.Text = "Cadastre-se";
            this.CadastreSe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(715, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(15, 15);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 8;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(737, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(15, 15);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFechar.TabIndex = 7;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(764, 299);
            this.Controls.Add(this.CadastreSe);
            this.Controls.Add(this.lbErro);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAcessar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtRE);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox txtRE;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnAcessar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.Label lbErro;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.LinkLabel CadastreSe;
        private System.Windows.Forms.PictureBox btnFechar;
    }
}