using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtecNews
{
    public partial class LayoutNoticia : UserControl
    {
        
        public LayoutNoticia()
        {
            InitializeComponent();            
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            int labelIndice = int.Parse(lblIndice.Text);

            FormMostrarNoticia formMostrar = new FormMostrarNoticia(labelIndice);
            formMostrar.Show();
        }
       
    }
}
