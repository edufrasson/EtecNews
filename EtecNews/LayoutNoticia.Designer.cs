namespace EtecNews
{
    partial class LayoutNoticia
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTituloNoticia = new System.Windows.Forms.Label();
            this.btnAcessar = new System.Windows.Forms.Button();
            this.lblIndice = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.lblTituloNoticia);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 84);
            this.panel1.TabIndex = 0;
            // 
            // lblTituloNoticia
            // 
            this.lblTituloNoticia.AutoSize = true;
            this.lblTituloNoticia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloNoticia.Location = new System.Drawing.Point(16, 30);
            this.lblTituloNoticia.Name = "lblTituloNoticia";
            this.lblTituloNoticia.Size = new System.Drawing.Size(60, 24);
            this.lblTituloNoticia.TabIndex = 0;
            this.lblTituloNoticia.Text = "label1";
            this.lblTituloNoticia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAcessar
            // 
            this.btnAcessar.BackColor = System.Drawing.Color.Silver;
            this.btnAcessar.FlatAppearance.BorderSize = 0;
            this.btnAcessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcessar.Location = new System.Drawing.Point(30, 102);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(200, 47);
            this.btnAcessar.TabIndex = 1;
            this.btnAcessar.Text = "Acessar Noticia";
            this.btnAcessar.UseVisualStyleBackColor = false;
            this.btnAcessar.Click += new System.EventHandler(this.btnAcessar_Click);
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.lblIndice.Location = new System.Drawing.Point(225, 107);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(0, 13);
            this.lblIndice.TabIndex = 2;
            this.lblIndice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblIndice.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.btnAcessar);
            this.panel3.Controls.Add(this.lblIndice);
            this.panel3.Location = new System.Drawing.Point(0, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(264, 174);
            this.panel3.TabIndex = 3;
            // 
            // LayoutNoticia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "LayoutNoticia";
            this.Size = new System.Drawing.Size(315, 273);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAcessar;
        public System.Windows.Forms.Label lblIndice;
        public System.Windows.Forms.Label lblTituloNoticia;
        public System.Windows.Forms.Panel panel3;
    }
}
