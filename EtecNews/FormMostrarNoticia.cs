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
    public partial class FormMostrarNoticia : Form
    {
        public int indiceNoticia;
        public FormMostrarNoticia(int indice)
        {
            InitializeComponent();

            this.indiceNoticia = indice;
            Console.WriteLine(this.indiceNoticia);

            Noticia NoticiaApresentada = ListaNoticias[indiceNoticia];

            lblMostrarTitulo.Text = NoticiaApresentada.Titulo;
            lblMostrarDescricao.Text = NoticiaApresentada.Descricao;
        }

     
    }
}
