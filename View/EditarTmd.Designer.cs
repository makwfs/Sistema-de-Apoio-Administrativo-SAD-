namespace SistemaMysql.View
{
    partial class EditarTmd
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEcluir = new System.Windows.Forms.Button();
            this.groupBoxTmd = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txbPesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLocal = new System.Windows.Forms.ComboBox();
            this.txbId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbObservacaoTmd = new System.Windows.Forms.TextBox();
            this.txbPatrimonioTmdPm = new System.Windows.Forms.TextBox();
            this.txbModeloTmd = new System.Windows.Forms.TextBox();
            this.txbSerialTmd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbPatrimonioTmd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbEditarTmd = new System.Windows.Forms.PictureBox();
            this.OpenFileDialogEditarTmd = new System.Windows.Forms.OpenFileDialog();
            this.SrcEditarFotoTmd = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.gridEditarTmd = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxTmd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditarTmd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEditarTmd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Location = new System.Drawing.Point(629, 128);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(90, 30);
            this.btnLimpar.TabIndex = 24;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSalvar.Location = new System.Drawing.Point(629, 92);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 30);
            this.btnSalvar.TabIndex = 28;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEcluir
            // 
            this.btnEcluir.Enabled = false;
            this.btnEcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEcluir.Location = new System.Drawing.Point(629, 164);
            this.btnEcluir.Name = "btnEcluir";
            this.btnEcluir.Size = new System.Drawing.Size(90, 30);
            this.btnEcluir.TabIndex = 29;
            this.btnEcluir.Text = "Excluir";
            this.btnEcluir.UseVisualStyleBackColor = true;
            this.btnEcluir.Click += new System.EventHandler(this.btnEcluir_Click);
            // 
            // groupBoxTmd
            // 
            this.groupBoxTmd.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxTmd.Controls.Add(this.label9);
            this.groupBoxTmd.Controls.Add(this.comboBox1);
            this.groupBoxTmd.Controls.Add(this.txbPesquisar);
            this.groupBoxTmd.Controls.Add(this.label1);
            this.groupBoxTmd.Controls.Add(this.cmbLocal);
            this.groupBoxTmd.Controls.Add(this.btnEcluir);
            this.groupBoxTmd.Controls.Add(this.txbId);
            this.groupBoxTmd.Controls.Add(this.btnSalvar);
            this.groupBoxTmd.Controls.Add(this.label6);
            this.groupBoxTmd.Controls.Add(this.label5);
            this.groupBoxTmd.Controls.Add(this.txbObservacaoTmd);
            this.groupBoxTmd.Controls.Add(this.btnLimpar);
            this.groupBoxTmd.Controls.Add(this.txbPatrimonioTmdPm);
            this.groupBoxTmd.Controls.Add(this.txbModeloTmd);
            this.groupBoxTmd.Controls.Add(this.txbSerialTmd);
            this.groupBoxTmd.Controls.Add(this.label4);
            this.groupBoxTmd.Controls.Add(this.label8);
            this.groupBoxTmd.Controls.Add(this.label3);
            this.groupBoxTmd.Controls.Add(this.txbPatrimonioTmd);
            this.groupBoxTmd.Controls.Add(this.label7);
            this.groupBoxTmd.Controls.Add(this.label2);
            this.groupBoxTmd.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTmd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.groupBoxTmd.Location = new System.Drawing.Point(31, 45);
            this.groupBoxTmd.Name = "groupBoxTmd";
            this.groupBoxTmd.Size = new System.Drawing.Size(743, 445);
            this.groupBoxTmd.TabIndex = 30;
            this.groupBoxTmd.TabStop = false;
            this.groupBoxTmd.Text = "TMD";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "IMPRESSORA",
            "COMPUTADOR",
            "TMD"});
            this.comboBox1.Location = new System.Drawing.Point(269, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(238, 24);
            this.comboBox1.TabIndex = 32;
            // 
            // txbPesquisar
            // 
            this.txbPesquisar.Location = new System.Drawing.Point(269, 38);
            this.txbPesquisar.Name = "txbPesquisar";
            this.txbPesquisar.Size = new System.Drawing.Size(204, 25);
            this.txbPesquisar.TabIndex = 31;
            this.txbPesquisar.TextChanged += new System.EventHandler(this.txbPesquisar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(328, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Patrimônio:";
            // 
            // cmbLocal
            // 
            this.cmbLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocal.FormattingEnabled = true;
            this.cmbLocal.Items.AddRange(new object[] {
            "1ª CIA",
            "2ª CIA",
            "3ª CIA",
            "4ª CIA",
            "5ª CIA",
            "6ª CIA",
            "FORÇA TÁTICA",
            "EM",
            "TELEMÁTICA"});
            this.cmbLocal.Location = new System.Drawing.Point(207, 191);
            this.cmbLocal.Name = "cmbLocal";
            this.cmbLocal.Size = new System.Drawing.Size(300, 24);
            this.cmbLocal.TabIndex = 5;
            // 
            // txbId
            // 
            this.txbId.Enabled = false;
            this.txbId.Location = new System.Drawing.Point(25, 96);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(47, 25);
            this.txbId.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label6.Location = new System.Drawing.Point(22, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Observação:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label5.Location = new System.Drawing.Point(204, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Local:";
            // 
            // txbObservacaoTmd
            // 
            this.txbObservacaoTmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbObservacaoTmd.Location = new System.Drawing.Point(25, 248);
            this.txbObservacaoTmd.Multiline = true;
            this.txbObservacaoTmd.Name = "txbObservacaoTmd";
            this.txbObservacaoTmd.Size = new System.Drawing.Size(694, 171);
            this.txbObservacaoTmd.TabIndex = 6;
            // 
            // txbPatrimonioTmdPm
            // 
            this.txbPatrimonioTmdPm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPatrimonioTmdPm.Location = new System.Drawing.Point(25, 191);
            this.txbPatrimonioTmdPm.Name = "txbPatrimonioTmdPm";
            this.txbPatrimonioTmdPm.Size = new System.Drawing.Size(171, 22);
            this.txbPatrimonioTmdPm.TabIndex = 3;
            // 
            // txbModeloTmd
            // 
            this.txbModeloTmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbModeloTmd.Location = new System.Drawing.Point(207, 147);
            this.txbModeloTmd.Name = "txbModeloTmd";
            this.txbModeloTmd.Size = new System.Drawing.Size(300, 22);
            this.txbModeloTmd.TabIndex = 4;
            // 
            // txbSerialTmd
            // 
            this.txbSerialTmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSerialTmd.Location = new System.Drawing.Point(25, 147);
            this.txbSerialTmd.Name = "txbSerialTmd";
            this.txbSerialTmd.Size = new System.Drawing.Size(171, 22);
            this.txbSerialTmd.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(22, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Serial:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label8.Location = new System.Drawing.Point(22, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Patrimônio PM:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(204, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modelo:";
            // 
            // txbPatrimonioTmd
            // 
            this.txbPatrimonioTmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPatrimonioTmd.Location = new System.Drawing.Point(81, 96);
            this.txbPatrimonioTmd.Name = "txbPatrimonioTmd";
            this.txbPatrimonioTmd.Size = new System.Drawing.Size(182, 22);
            this.txbPatrimonioTmd.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label7.Location = new System.Drawing.Point(22, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(78, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patrimônio:";
            // 
            // pbEditarTmd
            // 
            this.pbEditarTmd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbEditarTmd.ErrorImage = global::SistemaMysql.Properties.Resources._47bpmi__1_3;
            this.pbEditarTmd.Image = global::SistemaMysql.Properties.Resources.Inserir_imagem;
            this.pbEditarTmd.Location = new System.Drawing.Point(780, 54);
            this.pbEditarTmd.Name = "pbEditarTmd";
            this.pbEditarTmd.Size = new System.Drawing.Size(263, 408);
            this.pbEditarTmd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEditarTmd.TabIndex = 32;
            this.pbEditarTmd.TabStop = false;
            this.pbEditarTmd.Click += new System.EventHandler(this.pbEditarTmd_Click_1);
            // 
            // OpenFileDialogEditarTmd
            // 
            this.OpenFileDialogEditarTmd.FileName = "openFileDialog1";
            // 
            // SrcEditarFotoTmd
            // 
            this.SrcEditarFotoTmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SrcEditarFotoTmd.Location = new System.Drawing.Point(780, 468);
            this.SrcEditarFotoTmd.Name = "SrcEditarFotoTmd";
            this.SrcEditarFotoTmd.Size = new System.Drawing.Size(263, 22);
            this.SrcEditarFotoTmd.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label14.Location = new System.Drawing.Point(348, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(342, 25);
            this.label14.TabIndex = 26;
            this.label14.Text = "EDITAR MATERIAL DE INFORMÁTICA:";
            // 
            // gridEditarTmd
            // 
            this.gridEditarTmd.AllowUserToAddRows = false;
            this.gridEditarTmd.AllowUserToDeleteRows = false;
            this.gridEditarTmd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridEditarTmd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(83)))));
            this.gridEditarTmd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridEditarTmd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridEditarTmd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridEditarTmd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridEditarTmd.ColumnHeadersHeight = 30;
            this.gridEditarTmd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridEditarTmd.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridEditarTmd.EnableHeadersVisualStyles = false;
            this.gridEditarTmd.GridColor = System.Drawing.Color.MidnightBlue;
            this.gridEditarTmd.Location = new System.Drawing.Point(31, 511);
            this.gridEditarTmd.Name = "gridEditarTmd";
            this.gridEditarTmd.ReadOnly = true;
            this.gridEditarTmd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridEditarTmd.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(94)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.gridEditarTmd.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridEditarTmd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEditarTmd.Size = new System.Drawing.Size(1012, 260);
            this.gridEditarTmd.TabIndex = 34;
            this.gridEditarTmd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEditarTmd_CellClick_1);
            this.gridEditarTmd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEditarTmd_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label9.Location = new System.Drawing.Point(266, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "Tipo:";
            // 
            // EditarTmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1080, 792);
            this.Controls.Add(this.gridEditarTmd);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.SrcEditarFotoTmd);
            this.Controls.Add(this.pbEditarTmd);
            this.Controls.Add(this.groupBoxTmd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditarTmd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDITAR TMD";
            this.Load += new System.EventHandler(this.Editar_Load);
            this.groupBoxTmd.ResumeLayout(false);
            this.groupBoxTmd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditarTmd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEditarTmd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEcluir;
        private System.Windows.Forms.GroupBox groupBoxTmd;
        private System.Windows.Forms.ComboBox cmbLocal;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbObservacaoTmd;
        private System.Windows.Forms.TextBox txbPatrimonioTmdPm;
        private System.Windows.Forms.TextBox txbModeloTmd;
        private System.Windows.Forms.TextBox txbSerialTmd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbPatrimonioTmd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbEditarTmd;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogEditarTmd;
        private System.Windows.Forms.TextBox SrcEditarFotoTmd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView gridEditarTmd;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
    }
}