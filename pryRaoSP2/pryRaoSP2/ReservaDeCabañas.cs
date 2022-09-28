using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRaoSP2
{
    public partial class frmReservaCabañas : Form
    {
        private const float TIPOA = 20;
        private const float TIPOB = 34;
        const float COCINA = 1;
        const float HELADERA = 1.5f;
        const float TELEVISOR = 2;
        const float PORPERSONA = 1;
        public frmReservaCabañas()
        {
            InitializeComponent();
        }
        private void frmReservaCabañas_Load(object sender, EventArgs e)
        {
            cboTipo.Items.Clear();
            cboTipo.Items.Add ("Tipo A");
            cboTipo.Items.Add ("Tipo B");
            cboTipo.SelectedIndex= 0;
            txtDias.Text = "1"; 
            chkCocina.Checked = false;
            chkHeladera.Checked = false;
            chkTelevisión.Checked = false;
            optEfectivo.Checked = true;
            txtNombre.Text = "";
            txtTelefonos.Text = "";
            cboTarjetas.Items.Clear();
            cboTarjetas.Items.Add("Card Red");
            cboTarjetas.Items.Add("Card Blue");
            cboTarjetas.Items.Add("Card Green");
        }
        private void txtDias_TextChanged(object sender, EventArgs e)
        {
            if (txtDias.Text != "" && txtDias.Text != "0" && txtNombre.Text != "" && txtTelefonos.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
            if (txtDias.Text != "")
            {
                mrcAdicionales.Enabled = true;
                mrcFormasdePago.Enabled = true;
            }
            else
            {
                mrcAdicionales.Enabled = false;
                mrcFormasdePago.Enabled = false;
            }
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int I = 0;
            cboPersonas.Items.Clear();
            if (cboTipo.SelectedIndex == 0)
            {
                cboPersonas.Enabled = true;
                for (I = 1; I <= 4; I++)
                    cboPersonas.Items.Add(I);
            }
            else if (cboTipo.SelectedIndex == 1)
            {
                for (I = 1; I <= 8; I++)
                    cboPersonas.Items.Add(I);
            }
            cboPersonas.SelectedIndex = 0;
        }

        private void cboPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPersonas.SelectedIndex != -1)
            {
                txtDias.Enabled = true;
            }
        }

        private void optEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            cboTarjetas.Enabled = false;
            cboTarjetas.SelectedIndex = -1;  
        }

        private void optTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            cboTarjetas.Enabled = true;
            cboTarjetas.SelectedIndex = 0;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtDias.Text != "" && txtDias.Text != "0" && txtNombre.Text != "" && txtTelefonos.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else 
            {
                btnAceptar.Enabled=false;
            }

        }
        private void txtTelefonos_TextChanged (object sender, EventArgs e)
        {
            if (txtDias.Text != "" && txtDias.Text != "0" && txtNombre.Text != "" && txtTelefonos.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            float PrecioBase;
            float Opcionales;
            float Recargo;
            int Dias;
            float Total;
                
            Dias = int.Parse(txtDias.Text);

            if (cboTipo.SelectedIndex == 0)
            {
                PrecioBase = TIPOA;
            }
            else
            {
                PrecioBase=TIPOB;
            }
            PrecioBase = PrecioBase + (PORPERSONA * int.Parse(cboPersonas.Text));

            Opcionales = 0;

            if (chkCocina.Checked == true)
            {
                Opcionales = Opcionales + COCINA;
            }
            if (chkTelevisión.Checked == true)
            {
                Opcionales = Opcionales + TELEVISOR;
            }
            if (chkCocina.Checked == true)
            {
                Opcionales = Opcionales + COCINA;
            }
            Total = (PrecioBase + Opcionales) * Dias;

            if (optTarjeta.Checked == true)
            {
                if (cboTarjetas.SelectedIndex == 0) 
                {
                    Recargo = Total * 10 / 100;
                }
                else
                {
                    Recargo = Total * 20 / 100;
                }
            }
            MessageBox.Show("El total es de " + Total.ToString(),"Importe de la reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }   
    }
}