namespace SistemaMysql.View
{
    partial class EditarInformatica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarInformatica));
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.groupBoxTmd = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbEditarTipo = new System.Windows.Forms.ComboBox();
            this.txbPesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLocal = new System.Windows.Forms.ComboBox();
            this.txbId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbObservacaoTmd = new System.Windows.Forms.TextBox();
            this.txbPatrimonioPm = new System.Windows.Forms.TextBox();
            this.txbModelo = new System.Windows.Forms.TextBox();
            this.txbSerial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbPatrimonio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OpenFileDialogEditarTmd = new System.Windows.Forms.OpenFileDialog();
            this.SrcFoto = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.gridEditarTmd = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbEditar = new System.Windows.Forms.PictureBox();
            this.groupBoxTmd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEditarTmd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).BeginInit();
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
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(629, 164);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 30);
            this.btnExcluir.TabIndex = 29;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click_1);
            // 
            // groupBoxTmd
            // 
            this.groupBoxTmd.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxTmd.Controls.Add(this.label9);
            this.groupBoxTmd.Controls.Add(this.cmbEditarTipo);
            this.groupBoxTmd.Controls.Add(this.txbPesquisar);
            this.groupBoxTmd.Controls.Add(this.label1);
            this.groupBoxTmd.Controls.Add(this.cmbLocal);
            this.groupBoxTmd.Controls.Add(this.btnExcluir);
            this.groupBoxTmd.Controls.Add(this.txbId);
            this.groupBoxTmd.Controls.Add(this.btnSalvar);
            this.groupBoxTmd.Controls.Add(this.label6);
            this.groupBoxTmd.Controls.Add(this.label5);
            this.groupBoxTmd.Controls.Add(this.txbObservacaoTmd);
            this.groupBoxTmd.Controls.Add(this.btnLimpar);
            this.groupBoxTmd.Controls.Add(this.txbPatrimonioPm);
            this.groupBoxTmd.Controls.Add(this.txbModelo);
            this.groupBoxTmd.Controls.Add(this.txbSerial);
            this.groupBoxTmd.Controls.Add(this.label4);
            this.groupBoxTmd.Controls.Add(this.label8);
            this.groupBoxTmd.Controls.Add(this.label3);
            this.groupBoxTmd.Controls.Add(this.txbPatrimonio);
            this.groupBoxTmd.Controls.Add(this.label7);
            this.groupBoxTmd.Controls.Add(this.label2);
            this.groupBoxTmd.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTmd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(136)))), ((int)(((byte)(253)))));
            this.groupBoxTmd.Location = new System.Drawing.Point(31, 69);
            this.groupBoxTmd.Name = "groupBoxTmd";
            this.groupBoxTmd.Size = new System.Drawing.Size(743, 445);
            this.groupBoxTmd.TabIndex = 30;
            this.groupBoxTmd.TabStop = false;
            this.groupBoxTmd.Text = "EDITAR";
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
            // cmbEditarTipo
            // 
            this.cmbEditarTipo.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEditarTipo.FormattingEnabled = true;
            this.cmbEditarTipo.Items.AddRange(new object[] {
            "IMPRESSORA",
            "COMPUTADOR",
            "RÁDIO",
            "TMD",
            "TODOS"});
            this.cmbEditarTipo.Location = new System.Drawing.Point(269, 96);
            this.cmbEditarTipo.Name = "cmbEditarTipo";
            this.cmbEditarTipo.Size = new System.Drawing.Size(238, 25);
            this.cmbEditarTipo.TabIndex = 32;
            this.cmbEditarTipo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.cmbLocal.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cmbLocal.Size = new System.Drawing.Size(300, 25);
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
            this.txbObservacaoTmd.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbObservacaoTmd.Location = new System.Drawing.Point(25, 248);
            this.txbObservacaoTmd.Multiline = true;
            this.txbObservacaoTmd.Name = "txbObservacaoTmd";
            this.txbObservacaoTmd.Size = new System.Drawing.Size(694, 171);
            this.txbObservacaoTmd.TabIndex = 6;
            // 
            // txbPatrimonioPm
            // 
            this.txbPatrimonioPm.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPatrimonioPm.Location = new System.Drawing.Point(25, 191);
            this.txbPatrimonioPm.Name = "txbPatrimonioPm";
            this.txbPatrimonioPm.Size = new System.Drawing.Size(171, 25);
            this.txbPatrimonioPm.TabIndex = 3;
            // 
            // txbModelo
            // 
            this.txbModelo.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbModelo.Location = new System.Drawing.Point(207, 147);
            this.txbModelo.Name = "txbModelo";
            this.txbModelo.Size = new System.Drawing.Size(300, 25);
            this.txbModelo.TabIndex = 4;
            // 
            // txbSerial
            // 
            this.txbSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSerial.Location = new System.Drawing.Point(25, 147);
            this.txbSerial.Name = "txbSerial";
            this.txbSerial.Size = new System.Drawing.Size(171, 22);
            this.txbSerial.TabIndex = 2;
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
            // txbPatrimonio
            // 
            this.txbPatrimonio.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPatrimonio.Location = new System.Drawing.Point(81, 96);
            this.txbPatrimonio.Name = "txbPatrimonio";
            this.txbPatrimonio.Size = new System.Drawing.Size(182, 25);
            this.txbPatrimonio.TabIndex = 1;
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
            // OpenFileDialogEditarTmd
            // 
            this.OpenFileDialogEditarTmd.FileName = "openFileDialog1";
            // 
            // SrcFoto
            // 
            this.SrcFoto.Enabled = false;
            this.SrcFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SrcFoto.Location = new System.Drawing.Point(780, 492);
            this.SrcFoto.Name = "SrcFoto";
            this.SrcFoto.Size = new System.Drawing.Size(263, 22);
            this.SrcFoto.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(357, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(362, 30);
            this.label14.TabIndex = 26;
            this.label14.Text = "EDITAR MATERIAL DE INFORMÁTICA:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            this.label14.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label14_MouseDown);
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
            this.gridEditarTmd.Location = new System.Drawing.Point(30, 535);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1053, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1032, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 50);
            this.panel1.TabIndex = 37;
            // 
            // pbEditar
            // 
            this.pbEditar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbEditar.ErrorImage = global::SistemaMysql.Properties.Resources._47bpmi__1_3;
            this.pbEditar.Image = global::SistemaMysql.Properties.Resources.Inserir_imagem;
            this.pbEditar.Location = new System.Drawing.Point(780, 80);
            this.pbEditar.Name = "pbEditar";
            this.pbEditar.Size = new System.Drawing.Size(263, 407);
            this.pbEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEditar.TabIndex = 38;
            this.pbEditar.TabStop = false;
            this.pbEditar.Click += new System.EventHandler(this.pbEditar_Click);
            // 
            // EditarInformatica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1080, 815);
            this.Controls.Add(this.pbEditar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridEditarTmd);
            this.Controls.Add(this.SrcFoto);
            this.Controls.Add(this.groupBoxTmd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarInformatica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDITAR TMD";
            this.Load += new System.EventHandler(this.Editar_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EditarInformatica_MouseDown);
            this.groupBoxTmd.ResumeLayout(false);
            this.groupBoxTmd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEditarTmd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox groupBoxTmd;
        private System.Windows.Forms.ComboBox cmbLocal;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbObservacaoTmd;
        private System.Windows.Forms.TextBox txbPatrimonioPm;
        private System.Windows.Forms.TextBox txbModelo;
        private System.Windows.Forms.TextBox txbSerial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbPatrimonio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogEditarTmd;
        private System.Windows.Forms.TextBox SrcFoto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView gridEditarTmd;
        private System.Windows.Forms.ComboBox cmbEditarTipo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbEditar;
    }
}