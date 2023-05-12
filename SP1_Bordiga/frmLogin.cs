using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP1_Bordiga
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
        int intentos = 0;

        private TextBox GetTxtUsuario()
        {
            return txtUsuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if ((txtUsuario.Text == "Adm" &&
                  txtContraseña.Text == "@1a" &&
                  (lstModulo.Text == "ADM" || lstModulo.Text == "COM" || lstModulo.Text == "VTA")) ||
                  (txtUsuario.Text == "John" &&
                   txtContraseña.Text == "*2b" &&
                   lstModulo.Text == "SIST") ||
                   (txtUsuario.Text == "Ceci" &&
                   txtContraseña.Text == "*@3c" &&
                   (lstModulo.Text == "ADM" || lstModulo.Text == "VTA")) ||
                  (txtUsuario.Text == "God" &&
                   txtContraseña.Text == "*@#4d" &&
                   (lstModulo.Text == "ADM" || lstModulo.Text == "COM" || lstModulo.Text == "VTA" || lstModulo.Text == "SIST")))
            { 
                this.Hide();
                frmInicio f = new frmInicio();
                f.Text = txtUsuario.Text;
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Datos incorrectos. Acceso Denegado.");
                intentos++;
                if (intentos == 3) 
                {
                    this.Close();
                }
            }



        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstModulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}

