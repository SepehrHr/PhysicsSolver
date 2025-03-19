using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhysicsSolver
{
    public partial class KineticEnergy : Form
    {
        public KineticEnergy()
        {
            InitializeComponent();
        }

        private void KineticEnergy_Load(object sender, EventArgs e)
        {
            cmbMassUnit.SelectedIndex = 0;
            cmbVelocityUnit.SelectedIndex = 0;
            cmbKUnit.SelectedIndex = 0;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal mass = cmbMassUnit.SelectedIndex == 0 ? numMass.Value : numMass.Value / 1000;
            decimal velocity = cmbVelocityUnit.SelectedIndex == 0 ? numVelocity.Value : numVelocity.Value / (decimal)3.6;
            decimal k = cmbKUnit.SelectedIndex == 0 ? numK.Value : numK.Value * 1000;
            if (k == 0)
            {
                rd1Solid.Visible = true; rd1Solid.Text = "J";
                rd2Solid.Visible = true; rd2Solid.Text = "KJ";

                var result = (decimal)0.5 * mass * (velocity * velocity);
                string resultStr;

                if (rd2Solid.Checked) resultStr = String.Format("{0:0.00}", result / 1000) + "KJ";
                else resultStr = String.Format("{0:0.00}", result) + "J";

                lblK.Text = resultStr;
                lblMass.Text = $"{k}Kg";
                lblVelocity.Text = $"{velocity}m/s";
                lblResult.Text = resultStr;
            }
            else if (mass == 0)
            {
                rd1Solid.Visible = true; rd1Solid.Text = "Kg";
                rd2Solid.Visible = true; rd2Solid.Text = "g";

                var result = k / ((decimal)0.5 * velocity * velocity);
                string resultStr;
                if (rd1Solid.Checked) resultStr = String.Format("{0:0.00}", result) + "Kg";
                else resultStr = String.Format("{0:0.00}", result * 1000) + "g";

                lblK.Text = $"{k}J";
                lblMass.Text = resultStr;
                lblVelocity.Text = $"{velocity}m/s";
                lblResult.Text = resultStr;
            }
            else if (velocity == 0)
            {
                rd1Solid.Visible = true; rd1Solid.Text = "m³";
                rd2Solid.Visible = true; rd2Solid.Text = "cm³";
                var result = Math.Sqrt((double)k / (0.5 * (double)mass));
                string resultStr;

                if (rd1Solid.Checked) resultStr = String.Format("{0:0.00}", result) + "m/s";
                else resultStr = String.Format("{0:0.00}", result * 3.6) + "Km/h";

                lblK.Text = $"{k}J";
                lblMass.Text = $"{k}Kg";
                lblVelocity.Text = resultStr;
                lblResult.Text = resultStr;
            }
            else if (k == (decimal)0.5 * mass * velocity * velocity)
            {
                MessageBox.Show("The equation is valid.", "Valid", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The eqaution is not valid.", "Not valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
