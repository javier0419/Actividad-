using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaRepositorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            MostrarMensaje();
        }
        private void MostrarMensaje()
        {
            MessageBox.Show("Bienvenidos a la materia de Desarrollo De Sistemas", "Mensaje de Bienvenida", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
