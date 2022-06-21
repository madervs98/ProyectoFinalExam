using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalExam
{
    public partial class Registros : Form
    {
        public Registros()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios CrearUsuarios = new Usuarios();
            CrearUsuarios.MdiParent = this;
            CrearUsuarios.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes RegistroClientes = new Clientes();
            RegistroClientes.MdiParent = this;
            RegistroClientes.Show();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Productos RegistroProductos = new Productos();
            RegistroProductos.MdiParent = this;
            RegistroProductos.Show();
        }

        private void suplidoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Suplidores RegistroSuplidores = new Suplidores();
            RegistroSuplidores.MdiParent = this;
            RegistroSuplidores.Show();

        }
    }
}
