using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercedesVersion1.Forms;

namespace MercedesVersion1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button1QuienSom_Click(object sender, EventArgs e)
        {
            FormQuienesSomos form = new FormQuienesSomos();
            form.Show();

            
        }

        private void button2Ingresar_Click(object sender, EventArgs e)
        {
            FormIngresar form = new FormIngresar();
            form.Show();
        }
    }
}
