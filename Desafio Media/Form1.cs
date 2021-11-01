using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_Media
{
    public partial class frmCalcularMedia : Form
    {
        public frmCalcularMedia()
        {
            InitializeComponent();
        }

        double Nota1, Nota2, Nota3, Media;

        
        private void btnCalcular_Click(object sender, EventArgs e)
        {

            Nota1 = Convert.ToDouble(txtNota1.Text);
            Nota2 = Convert.ToDouble(txtNota2.Text);
            Nota3 = Convert.ToDouble(txtNota3.Text);

            Media = (Nota1 + Nota2 + Nota3) / 3;
            lblMedia.Text = Media.ToString();
                       
            if (Media < 7)
            {
                lblSituacao.Text = ("REPROVADO" );
            } else
            {
                lblSituacao.Text = ("APROVADO" );
            }                       
        }

        
        
    }
}
