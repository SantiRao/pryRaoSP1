using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int intentos = 0;
            if (txtUsuario.Text == "Adm" && txtContraseña.Text == "@1a" && cboModulo.Text != "SIST")
            {
                this.Hide();
                frmSistema f = new frmSistema();
                f.Text = txtUsuario.Text;
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show ("Usuario o contraseña incorrectos para el modulo elegido. Por favor, intentelo de nuevo");
                intentos ++;
                if (intentos == 3)
                {
                    this.Close();
                }
            }
            if (txtUsuario.Text == "John" && txtContraseña.Text == "*2b" && cboModulo.Text == "SIST")
            {
                this.Hide();
                frmSistema f = new frmSistema();
                f.Text = txtUsuario.Text;
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos para el modulo elegido. Por favor, intentelo de nuevo");
                intentos++;
                if (intentos == 3)
                {
                    this.Close();
                }
            }
            if (txtUsuario.Text == "Ceci" && txtContraseña.Text == "*@3c" && cboModulo.Text == "VTA")
            {
                this.Hide();
                frmSistema f = new frmSistema();
                f.Text = txtUsuario.Text;
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos para el modulo elegido. Por favor, intentelo de nuevo");
                intentos++;
                if (intentos == 3)
                {
                    this.Close();
                }
            }
            if (txtUsuario.Text == "Ceci" && txtContraseña.Text == "*@3c" && cboModulo.Text == "ADM")
            {
                this.Hide();
                frmSistema f = new frmSistema();
                f.Text = txtUsuario.Text;
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos para el modulo elegido. Por favor, intentelo de nuevo");
                intentos++;
                if (intentos == 3)
                {
                    this.Close();
                }
            }
            if (txtUsuario.Text == "God" && txtContraseña.Text == "*@#4d" && cboModulo.Text != "")
            {
                this.Hide();
                frmSistema f = new frmSistema();
                f.Text = txtUsuario.Text;
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos para el modulo elegido. Por favor, intentelo de nuevo");
                intentos++;
                if (intentos == 3)
                {
                    this.Close();
                }
            }

        }
    }
}
