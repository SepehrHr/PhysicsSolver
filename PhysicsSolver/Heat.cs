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
    public partial class Heat : Form
    {
        public Heat()
        {
            InitializeComponent();
        }

        private void btnCalculateFliuds_Click(object sender, EventArgs e)
        {
            decimal mass = cmbMassUnit.SelectedIndex == 0 ? numMass.Value : numMass.Value / 1000;
            decimal c = numC.Value;
            decimal deltaT = cmbTUnit.SelectedIndex < 2 ? numT.Value : numT.Value * (decimal)1.8;
            decimal q = cmbQUnit.SelectedIndex == 0 ? numQ.Value : numQ.Value * 1000;

            if (q == 0)
            {
                rd1.Visible = true; rd1.Text = "J (SI Unit)";
                rd2.Visible = true; rd2.Text = "KJ";

                var result = mass * c * deltaT;
                string resultStr;

                if (rd2.Checked) resultStr = String.Format("{0:0.00}", result / 1000) + "KJ";
                else resultStr = String.Format("{0:0.00}", result) + "J";

                lblMass.Text = mass + "Kg";
                lblC.Text = c + "J/Kg∙K";
                lblDeltaT.Text = deltaT + "°C";
                lblQ.Text = result + "J";

                lblResult.Text = resultStr;
            }
            else if (mass == 0)
            {
                if (q == 0)
                {
                    MessageBox.Show("Q (Heat) cannot be 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                rd1.Visible = true; rd1.Text = "Kg";
                rd2.Visible = true; rd2.Text = "g";

                var result = q / (c * deltaT);
                string resultStr;

                if (rd2.Checked) resultStr = String.Format("{0:0.00}", result * 1000) + "g";
                else resultStr = String.Format("{0:0.00}", result) + "Kg";

                lblMass.Text = result + "Kg";
                lblC.Text = c + "J/Kg∙K";
                lblDeltaT.Text = deltaT + "°C";
                lblQ.Text = q + "J";
                lblResult.Text = resultStr;
            }
            else if (c == 0)
            {
                if (q == 0)
                {
                    MessageBox.Show("Q (Heat) cannot be 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                rd1.Visible = false;
                rd2.Visible = false;

                var result = q / (mass * deltaT);
                string resultStr = String.Format("{0:0.00}", result) + "J/Kg∙K";

                lblMass.Text = mass + "Kg";
                lblC.Text = resultStr;
                lblDeltaT.Text = deltaT + "°C";
                lblQ.Text = q + "J";
                lblResult.Text = resultStr;
            }
            else if (deltaT == 0)
            {
                if (q == 0)
                {
                    MessageBox.Show("Q (Heat) cannot be 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                rd1.Visible = true; rd1.Text = "°C";
                rd2.Visible = true; rd2.Text = "°F";

                var result = q / (mass * c);
                string resultStr;

                if (rd2.Checked) resultStr = String.Format("{0:0.00}", result * (decimal)1.8) + "°F";
                else resultStr = String.Format("{0:0.00}", result) + "°C";

                lblMass.Text = mass + "Kg";
                lblC.Text = c + "J/Kg∙K";
                lblDeltaT.Text = result + "°C";
                lblQ.Text = q + "J";
                lblResult.Text = resultStr;
            }
        }

        private void Heat_Load(object sender, EventArgs e)
        {
            cmbMassUnit.SelectedIndex = 0;
            cmbCUnit.SelectedIndex = 0;
            cmbTUnit.SelectedIndex = 0;
            cmbQUnit.SelectedIndex = 0;
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
