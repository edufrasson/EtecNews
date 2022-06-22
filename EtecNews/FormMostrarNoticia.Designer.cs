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
            this.lblMostrarDescricao = new System.Windows.Forms.RichTextBox();
            this.btnVoltarIndex = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.lblMostrarTitulo);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 119);
            this.panel1.TabIndex = 1;
            // 
            // lblMostrarTitulo
            // 
            this.lblMostrarTitulo.AutoEllipsis = true;
            this.lblMostrarTitulo.AutoSize = true;
            this.lblMostrarTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarTitulo.Location = new System.Drawing.Point(3, 38);
            this.lblMostrarTitulo.Name = "lblMostrarTitulo";
            this.lblMostrarTitulo.Size = new System.Drawing.Size(93, 39);
            this.lblMostrarTitulo.TabIndex = 0;
            this.lblMostrarTitulo.Text = "teste";
            this.lblMostrarTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMostrarDescricao
            // 
            this.lblMostrarDescricao.BackColor = System.Drawing.Color.White;
            this.lblMostrarDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblMostrarDescricao.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarDescricao.Location = new System.Drawing.Point(10, 135);
            this.lblMostrarDescricao.Name = "lblMostrarDescricao";
            this.lblMostrarDescricao.ReadOnly = true;
            this.lblMostrarDescricao.Size = new System.Drawing.Size(454, 408);
            this.lblMostrarDescricao.TabIndex = 4;
            this.lblMostrarDescricao.Text = "";
            // 
            // btnVoltarIndex
            // 
            this.btnVoltarIndex.BackColor = System.Drawing.Color.Gray;
            this.btnVoltarIndex.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarIndex.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVoltarIndex.Location = new System.Drawing.Point(15, 568);
            this.btnVoltarIndex.Name = "btnVoltarIndex";
            this.btnVoltarIndex.Size = new System.Drawing.Size(81, 30);
            this.btnVoltarIndex.TabIndex = 7;
            this.btnVoltarIndex.Text = "Voltar";
            this.btnVoltarIndex.UseVisualStyleBackColor = false;
            this.btnVoltarIndex.Click += new System.EventHandler(this.btnVoltarIndex_Click);
            // 
            // FormMostrarNoticia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(476, 610);
            this.Controls.Add(this.btnVoltarIndex);
            this.Controls.Add(this.lblMostrarDescricao);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMostrarNoticia";
            this.Text = "FormMostrarNoticia";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMostrarTitulo;
        private System.Windows.Forms.RichTextBox lblMostrarDescricao;
        private System.Windows.Forms.Button btnVoltarIndex;
    }
}