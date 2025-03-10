using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario_Machote
{
    public partial class WelcomeForm: Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Abrir el formulario principal (Form1)
            Form1 formPrincipal = new Form1();
            formPrincipal.Show(); // Muestra el formulario principal
            this.Hide(); // Oculta el formulario de bienvenida
        }
    }
}
