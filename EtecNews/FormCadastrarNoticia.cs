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
    public partial class FormCadastrarNoticia : Form
    {
        FormIndex FormPrincipal;
        public FormCadastrarNoticia(FormIndex formIndex)
        {
            InitializeComponent();

            this.FormPrincipal = formIndex;
        }

        private void btnAddNoticia_Click(object sender, EventArgs e)
        {
            Noticia noticia = new Noticia();

            noticia.Descricao = txtDescricao.Text;
            noticia.Titulo = txtTitulo.Text;


            ListaNoticias.Add(noticia);
            FormPrincipal.AdicionarNoticias();

            this.Hide();
            FormPrincipal.Show();
        }
        
    }
   
}
