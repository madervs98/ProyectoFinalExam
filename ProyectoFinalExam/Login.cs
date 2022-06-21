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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tb_LogUser.Text == "Madervs" && tb_LogPass.Text == "260798")
            {
                MessageBox.Show("Se ha iniciado sesión.");
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña no coincide.");
            }

           
        }
    }
}
