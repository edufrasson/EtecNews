using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EtecNews.ListaNoticia;

namespace EtecNews
{
    public partial class FormIndex : Form
    {
        public FormIndex()
        {
            InitializeComponent();
        }

        public void AdicionarNoticias()
        {
            FlowLayoutPanel.Controls.Clear();
            int i = 0;

            foreach (Noticia noticia in ListaNoticias)
            {
                LayoutNoticia layout = new LayoutNoticia();

                layout.lblTituloNoticia.Text = noticia.Titulo;
                layout.lblIndice.Text = i.ToString();
                layout.panel3.BackColor = Color.White;

                FlowLayoutPanel.Controls.Add(layout);

                i++;
            }
        }


        private void linkCadastrarNoticia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           /* this.Hide();*/

            FormCadastrarNoticia formNoticia = new FormCadastrarNoticia(this);

            formNoticia.Show();
                     
        }
    }
}
