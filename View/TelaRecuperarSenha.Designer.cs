namespace SistemaMysql.View
{
    partial class TelaRecuperarSenha
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
            this.txtRecuperarEmail = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRecuperarEmail
            // 
            this.txtRecuperarEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtRecuperarEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRecuperarEmail.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecuperarEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtRecuperarEmail.Location = new System.Drawing.Point(241, 295);
            this.txtRecuperarEmail.Name = "txtRecuperarEmail";
            this.txtRecuperarEmail.Size = new System.Drawing.Size(376, 22);
            this.txtRecuperarEmail.TabIndex = 3;
            this.txtRecuperarEmail.Text = "DIGITE SEU EMAIL:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastrar.Location = new System.Drawing.Point(241, 343);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(376, 40);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(212, 46);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(35, 13);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "label1";
            // 
            // TelaRecuperarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtRecuperarEmail);
            this.Name = "TelaRecuperarSenha";
            this.Text = "TelaRecuperarSenha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRecuperarEmail;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblResultado;
    }
}