namespace EtecNews
{
    partial class FormMostrarNoticia
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMostrarTitulo = new System.Windows.Forms.Label();
            this.lblMostrarDescricao = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.lblMostrarTitulo);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 119);
            this.panel1.TabIndex = 1;
            // 
            // lblMostrarTitulo
            // 
            this.lblMostrarTitulo.AutoSize = true;
            this.lblMostrarTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarTitulo.Location = new System.Drawing.Point(50, 44);
            this.lblMostrarTitulo.Name = "lblMostrarTitulo";
            this.lblMostrarTitulo.Size = new System.Drawing.Size(59, 26);
            this.lblMostrarTitulo.TabIndex = 0;
            this.lblMostrarTitulo.Text = "teste";
            // 
            // lblMostrarDescricao
            // 
            this.lblMostrarDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblMostrarDescricao.Enabled = false;
            this.lblMostrarDescricao.Location = new System.Drawing.Point(36, 175);
            this.lblMostrarDescricao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblMostrarDescricao.Multiline = true;
            this.lblMostrarDescricao.Name = "lblMostrarDescricao";
            this.lblMostrarDescricao.ReadOnly = true;
            this.lblMostrarDescricao.Size = new System.Drawing.Size(403, 325);
            this.lblMostrarDescricao.TabIndex = 2;
            // 
            // FormMostrarNoticia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 555);
            this.Controls.Add(this.lblMostrarDescricao);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMostrarNoticia";
            this.Text = "FormMostrarNoticia";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMostrarTitulo;
        public System.Windows.Forms.TextBox lblMostrarDescricao;
    }
}