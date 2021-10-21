using Datos.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPubs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridAutores.DataSource = AdmAuthor.Listar();
        }

        private void btnFiltrarCiudad_Click(object sender, EventArgs e)
        {
            string City = Convert.ToString(txtCity.Text);
            gridAutores.DataSource = AdmAuthor.Listar(City);
        }

        private void btnFiltrar2_Click(object sender, EventArgs e)
        {
            string City = Convert.ToString(txtCity.Text);
            string State = Convert.ToString(txtFiltrar2.Text);
            gridAutores.DataSource = AdmAuthor.Listar(City, State);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            gridAutores.DataSource = AdmAuthor.Listar();
        }
    }
}
