using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhysicsSolver
{
    public partial class Density : Form
    {
        public Density()
        {
            InitializeComponent();
        }

        private void Density_Load(object sender, EventArgs e)
        {
            cmbMassUnit.SelectedIndex = 0;
            cmbVolumeUnit.SelectedIndex = 0;
            cmbRhoUnit.SelectedIndex = 0;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal mass = cmbMassUnit.SelectedIndex == 0 ? numMass.Value : numMass.Value / 1000;
            decimal volume; if (cmbVolumeUnit.SelectedIndex == 1) volume = numVolume.Value / 1000; else volume = numVolume.Value / 1000000;
            decimal rho = cmbRhoUnit.SelectedIndex < 2 ? numRho.Value : numRho.Value * 1000;
            if (rho == 0)
            {
                rd1Solid.Visible = true; rd1Solid.Text = "Kg/m³ (SI Unit)";
                rd2Solid.Visible = true; rd2Solid.Text = "g/L";
                rd3Solid.Visible = true; rd3Solid.Text = "g/cm³";
                if (volume == 0)
                {
                    MessageBox.Show("Area cannot be 0!", "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
                    return;
                }
                var result = mass / volume;
                string resultStr;

                if (rd2Solid.Checked) resultStr = String.Format("{0:0.00}", result) + "g/L";
                else if (rd3Solid.Checked) resultStr = String.Format("{0:0.00}", result / 1000) + "g/cm³";
                else resultStr = String.Format("{0:0.00}", result) + "kg/m³";

                lblRho.Text = resultStr;
                lblMass.Text = $"{rho}Kg";
                lblVolume.Text = $"{volume}m³";
                lblResult.Text = resultStr;
            }
            else if (mass == 0)
            {
                rd1Solid.Visible = true; rd1Solid.Text = "Kg";
                rd2Solid.Visible = true; rd2Solid.Text = "g";
                rd3Solid.Visible = false;

                var result = rho * volume;
                string resultStr;
                if (rd1Solid.Checked) resultStr = String.Format("{0:0.00}", result) + "Kg";
                else resultStr = String.Format("{0:0.00}", result * 1000) + "g";

                lblRho.Text = $"{rho}Kg/m³";
                lblMass.Text = resultStr;
                lblVolume.Text = $"{volume}m³";
                lblResult.Text = resultStr;
            }
            else if (volume == 0)
            {
                rd1Solid.Visible = true; rd1Solid.Text = "m³";
                rd2Solid.Visible = true; rd2Solid.Text = "cm³";
                rd3Solid.Visible = false;
                var result = mass / rho;
                string resultStr;

                if (rd1Solid.Checked) resultStr = String.Format("{0:0.00}", result) + "m³";
                else resultStr = String.Format("{0:0.00}", result * 1000000) + "cm³";

                lblRho.Text = $"{rho}Kg/m³";
                lblMass.Text = $"{rho}Kg";
                lblVolume.Text = resultStr;
                lblResult.Text = resultStr;
            }
            else if (rho / volume == mass)
            {
                MessageBox.Show("The equation is valid.", "Valid", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The eqaution is not valid.", "Not valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            string result = Regex.Replace(lblResult.Text, "[a-zA-Z/²³]", "");
            try
            {
                Clipboard.SetText(result);
                MessageBox.Show("Copied!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Error copying the result to clipboard.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
