namespace SistemaMysql.View
{
    partial class CadastrarComputador
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
            this.groupBoxTmd = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrarComputador = new System.Windows.Forms.Button();
            this.cmbLocalComputador = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbObservacaoComputador = new System.Windows.Forms.TextBox();
            this.txbPatrimônioComputadorPm = new System.Windows.Forms.TextBox();
            this.txbModeloComputador = new System.Windows.Forms.TextBox();
            this.txbSerialComputador = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbPatrimonioComputador = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbPc = new System.Windows.Forms.PictureBox();
            this.OpenFileDialogPc = new System.Windows.Forms.OpenFileDialog();
            this.SrcFotoPc = new System.Windows.Forms.TextBox();
            this.groupBoxTmd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTmd
            // 
            this.groupBoxTmd.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxTmd.Controls.Add(this.btnLimpar);
            this.groupBoxTmd.Controls.Add(this.btnCadastrarComputador);
            this.groupBoxTmd.Controls.Add(this.cmbLocalComputador);
            this.groupBoxTmd.Controls.Add(this.textBox2);
            this.groupBoxTmd.Controls.Add(this.label6);
            this.groupBoxTmd.Controls.Add(this.label5);
            this.groupBoxTmd.Controls.Add(this.txbObservacaoComputador);
            this.groupBoxTmd.Controls.Add(this.txbPatrimônioComputadorPm);
            this.groupBoxTmd.Controls.Add(this.txbModeloComputador);
            this.groupBoxTmd.Controls.Add(this.txbSerialComputador);
            this.groupBoxTmd.Controls.Add(this.label4);
            this.groupBoxTmd.Controls.Add(this.label8);
            this.groupBoxTmd.Controls.Add(this.label3);
            this.groupBoxTmd.Controls.Add(this.txbPatrimonioComputador);
            this.groupBoxTmd.Controls.Add(this.label7);
            this.groupBoxTmd.Controls.Add(this.label2);
            this.groupBoxTmd.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTmd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.groupBoxTmd.Location = new System.Drawing.Point(12, 48);
            this.groupBoxTmd.Name = "groupBoxTmd";
            this.groupBoxTmd.Size = new System.Drawing.Size(632, 325);
            this.groupBoxTmd.TabIndex = 6;
            this.groupBoxTmd.TabStop = false;
            this.groupBoxTmd.Text = "COMPUTADOR";
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(534, 85);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(90, 30);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.TabStop = false;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click_1);
            // 
            // btnCadastrarComputador
            // 
            this.btnCadastrarComputador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarComputador.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarComputador.Location = new System.Drawing.Point(534, 49);
            this.btnCadastrarComputador.Name = "btnCadastrarComputador";
            this.btnCadastrarComputador.Size = new System.Drawing.Size(90, 30);
            this.btnCadastrarComputador.TabIndex = 13;
            this.btnCadastrarComputador.TabStop = false;
            this.btnCadastrarComputador.Text = "Cadastrar";
            this.btnCadastrarComputador.UseVisualStyleBackColor = true;
            this.btnCadastrarComputador.Click += new System.EventHandler(this.btnCadastrarComputador_Click_1);
            // 
            // cmbLocalComputador
            // 
            this.cmbLocalComputador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocalComputador.FormattingEnabled = true;
            this.cmbLocalComputador.Items.AddRange(new object[] {
            "1ª CIA",
            "2ª CIA",
            "3ª CIA",
            "4ª CIA",
            "5ª CIA",
            "6ª CIA",
            "FORÇA TÁTICA",
            "EM",
            "TELEMÁTICA"});
            this.cmbLocalComputador.Location = new System.Drawing.Point(21, 145);
            this.cmbLocalComputador.Name = "cmbLocalComputador";
            this.cmbLocalComputador.Size = new System.Drawing.Size(482, 24);
            this.cmbLocalComputador.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(21, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(47, 25);
            this.textBox2.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Observação:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Local:";
            // 
            // txbObservacaoComputador
            // 
            this.txbObservacaoComputador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbObservacaoComputador.Location = new System.Drawing.Point(21, 202);
            this.txbObservacaoComputador.Multiline = true;
            this.txbObservacaoComputador.Name = "txbObservacaoComputador";
            this.txbObservacaoComputador.Size = new System.Drawing.Size(482, 103);
            this.txbObservacaoComputador.TabIndex = 6;
            // 
            // txbPatrimônioComputadorPm
            // 
            this.txbPatrimônioComputadorPm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPatrimônioComputadorPm.Location = new System.Drawing.Point(21, 101);
            this.txbPatrimônioComputadorPm.Name = "txbPatrimônioComputadorPm";
            this.txbPatrimônioComputadorPm.Size = new System.Drawing.Size(176, 22);
            this.txbPatrimônioComputadorPm.TabIndex = 3;
            // 
            // txbModeloComputador
            // 
            this.txbModeloComputador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbModeloComputador.Location = new System.Drawing.Point(203, 101);
            this.txbModeloComputador.Name = "txbModeloComputador";
            this.txbModeloComputador.Size = new System.Drawing.Size(300, 22);
            this.txbModeloComputador.TabIndex = 4;
            // 
            // txbSerialComputador
            // 
            this.txbSerialComputador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSerialComputador.Location = new System.Drawing.Point(265, 50);
            this.txbSerialComputador.Name = "txbSerialComputador";
            this.txbSerialComputador.Size = new System.Drawing.Size(238, 22);
            this.txbSerialComputador.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(262, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Serial:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Patrimônio PM:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modelo:";
            // 
            // txbPatrimonioComputador
            // 
            this.txbPatrimonioComputador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPatrimonioComputador.Location = new System.Drawing.Point(77, 50);
            this.txbPatrimonioComputador.Name = "txbPatrimonioComputador";
            this.txbPatrimonioComputador.Size = new System.Drawing.Size(182, 22);
            this.txbPatrimonioComputador.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patrimônio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(366, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "CADASTRAR COMPUTADOR:";
            // 
            // pbPc
            // 
            this.pbPc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPc.ErrorImage = global::SistemaMysql.Properties.Resources._47bpmi__1_3;
            this.pbPc.Image = global::SistemaMysql.Properties.Resources.Inserir_imagem;
            this.pbPc.Location = new System.Drawing.Point(661, 56);
            this.pbPc.Name = "pbPc";
            this.pbPc.Size = new System.Drawing.Size(263, 284);
            this.pbPc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPc.TabIndex = 19;
            this.pbPc.TabStop = false;
            this.pbPc.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // OpenFileDialogPc
            // 
            this.OpenFileDialogPc.FileName = "openFileDialog1";
            // 
            // SrcFotoPc
            // 
            this.SrcFotoPc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SrcFotoPc.Location = new System.Drawing.Point(661, 351);
            this.SrcFotoPc.Name = "SrcFotoPc";
            this.SrcFotoPc.Size = new System.Drawing.Size(263, 22);
            this.SrcFotoPc.TabIndex = 17;
            // 
            // CadastrarComputador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(962, 401);
            this.Controls.Add(this.SrcFotoPc);
            this.Controls.Add(this.pbPc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxTmd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CadastrarComputador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Computador";
            this.Load += new System.EventHandler(this.CadastrarComputador_Load);
            this.groupBoxTmd.ResumeLayout(false);
            this.groupBoxTmd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTmd;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrarComputador;
        private System.Windows.Forms.ComboBox cmbLocalComputador;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbObservacaoComputador;
        private System.Windows.Forms.TextBox txbPatrimônioComputadorPm;
        private System.Windows.Forms.TextBox txbModeloComputador;
        private System.Windows.Forms.TextBox txbSerialComputador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbPatrimonioComputador;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbPc;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogPc;
        private System.Windows.Forms.TextBox SrcFotoPc;
    }
}