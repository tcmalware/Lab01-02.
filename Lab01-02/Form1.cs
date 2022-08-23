using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_02
{
    public partial class formulario : Form
    {
        public formulario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblmantenimiento_Click(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            string dni = textdni.Text;
            string nombre = textname.Text;
            string apellido = textapellido.Text;
            string direccion = textdireccion.Text;
            string telefono = texttelefono.Text;
            string email = textemail.Text;
            string fecha = dtpfecha.Text;
            dgvUsuarios.Rows.Add("U10023", dni, nombre, apellido, direccion, telefono, email, fecha);
        }
    }
}
