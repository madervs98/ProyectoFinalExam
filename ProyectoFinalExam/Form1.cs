﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
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
    }
}