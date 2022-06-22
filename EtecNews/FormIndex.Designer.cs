namespace EtecNews
{
    partial class FormIndex
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkCadastrarNoticia = new System.Windows.Forms.LinkLabel();
            this.FlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.linkCadastrarNoticia);
            this.panel1.Location = new System.Drawing.Point(-8, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 523);
            this.panel1.TabIndex = 0;
            // 
            // linkCadastrarNoticia
            // 
            this.linkCadastrarNoticia.AutoSize = true;
            this.linkCadastrarNoticia.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkCadastrarNoticia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkCadastrarNoticia.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkCadastrarNoticia.LinkColor = System.Drawing.Color.Black;
            this.linkCadastrarNoticia.Location = new System.Drawing.Point(19, 74);
            this.linkCadastrarNoticia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkCadastrarNoticia.Name = "linkCadastrarNoticia";
            this.linkCadastrarNoticia.Size = new System.Drawing.Size(129, 19);
            this.linkCadastrarNoticia.TabIndex = 0;
            this.linkCadastrarNoticia.TabStop = true;
            this.linkCadastrarNoticia.Text = "Cadastrar Noticia";
            this.linkCadastrarNoticia.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCadastrarNoticia_LinkClicked);
            // 
            // FlowLayoutPanel
            // 
            this.FlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlowLayoutPanel.AutoScroll = true;
            this.FlowLayoutPanel.Location = new System.Drawing.Point(166, 2);
            this.FlowLayoutPanel.Margin = new System.Windows.Forms.Padding(15, 4, 2, 4);
            this.FlowLayoutPanel.Name = "FlowLayoutPanel";
            this.FlowLayoutPanel.Padding = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.FlowLayoutPanel.Size = new System.Drawing.Size(688, 513);
            this.FlowLayoutPanel.TabIndex = 1;
            // 
            // FormIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(854, 508);
            this.Controls.Add(this.FlowLayoutPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "FormIndex";
            this.Text = "ETEC NEWS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkCadastrarNoticia;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel;
    }
}

