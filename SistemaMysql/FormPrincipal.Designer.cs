namespace SistemaMysql
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPesquisarPrincipal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPesquisarPrincipal
            // 
            this.btnPesquisarPrincipal.Location = new System.Drawing.Point(541, 30);
            this.btnPesquisarPrincipal.Name = "btnPesquisarPrincipal";
            this.btnPesquisarPrincipal.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarPrincipal.TabIndex = 0;
            this.btnPesquisarPrincipal.Text = "Pesquisar";
            this.btnPesquisarPrincipal.UseVisualStyleBackColor = true;
            this.btnPesquisarPrincipal.Click += new System.EventHandler(this.btnPesquisarPrincipal_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.btnPesquisarPrincipal);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisarPrincipal;
    }
}

