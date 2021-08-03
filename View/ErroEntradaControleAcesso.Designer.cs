
namespace SistemaMysql.View
{
    partial class ErroEntradaControleAcesso
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.SAÍDA = new System.Windows.Forms.Button();
            this.STATUS = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(612, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "O USUÁRIO JÁ SE ENCONTRA NO INTERIOR !";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(251, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "ATENÇÃO !";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(67, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(529, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "CADASTRE A SAÍDA PARA CONTINUAR";
            // 
            // btnEntrada
            // 
            this.btnEntrada.BackColor = System.Drawing.Color.SeaShell;
            this.btnEntrada.Location = new System.Drawing.Point(169, 332);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(153, 47);
            this.btnEntrada.TabIndex = 6;
            this.btnEntrada.Text = "SIM";
            this.btnEntrada.UseVisualStyleBackColor = false;
            this.btnEntrada.Visible = false;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // SAÍDA
            // 
            this.SAÍDA.BackColor = System.Drawing.Color.SeaShell;
            this.SAÍDA.Location = new System.Drawing.Point(340, 332);
            this.SAÍDA.Name = "SAÍDA";
            this.SAÍDA.Size = new System.Drawing.Size(153, 47);
            this.SAÍDA.TabIndex = 6;
            this.SAÍDA.Text = "NÃO";
            this.SAÍDA.UseVisualStyleBackColor = false;
            this.SAÍDA.Visible = false;
            this.SAÍDA.Click += new System.EventHandler(this.button1_Click);
            // 
            // STATUS
            // 
            this.STATUS.Location = new System.Drawing.Point(491, 38);
            this.STATUS.Name = "STATUS";
            this.STATUS.Size = new System.Drawing.Size(100, 20);
            this.STATUS.TabIndex = 7;
            this.STATUS.Visible = false;
            this.STATUS.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(491, 12);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 20);
            this.ID.TabIndex = 7;
            this.ID.Visible = false;
            this.ID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaMysql.Properties.Resources.police_line;
            this.pictureBox1.Location = new System.Drawing.Point(201, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ErroEntradaControleAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(685, 400);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.STATUS);
            this.Controls.Add(this.SAÍDA);
            this.Controls.Add(this.btnEntrada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ErroEntradaControleAcesso";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ErroEntradaControleAcesso";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ErroEntradaControleAcesso_FormClosed);
            this.Load += new System.EventHandler(this.ErroEntradaControleAcesso_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ErroEntradaControleAcesso_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button SAÍDA;
        private System.Windows.Forms.TextBox STATUS;
        private System.Windows.Forms.TextBox ID;
    }
}