using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PhysicsSolver
{
    public partial class PressureFrm : Form
    {
        public PressureFrm()
        {
            InitializeComponent();
        }

        private void CalculateSolids_Click(object sender, EventArgs e)
        {
            decimal pressure = cmbPressureUnitSolid.SelectedIndex == 0 ? numPressureSolid.Value : numPressureSolid.Value * 101300;
            decimal area = cmbAreaUnit.SelectedIndex == 0 ? numArea.Value : numArea.Value / 10000;
            decimal force = numForce.Value;
            if (pressure == 0)
            {
                rd1Solid.Visible = true; rd1Solid.Text = "SI Unit";
                rd2Solid.Visible = true; rd2Solid.Text = "atm";
                rd3Solid.Visible = true; rd3Solid.Text = "cmHg";
                if (area == 0)
                {
                    MessageBox.Show("Area cannot be 0!", "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
                    return;
                }
                var result = force / area;
                string resultStr;

                if (rd2Solid.Checked) resultStr = String.Format("{0:0.00}", result / 101300) + "atm";
                else if (rd3Solid.Checked) resultStr = String.Format("{0:0.00}", result / 133) + "cmHg";
                else resultStr = String.Format("{0:0.00}", result) + "Pa";

                lblPressureSolidResult.Text = resultStr;
                lblForceResult.Text = $"{force}N";
                lblAreaResult.Text = $"{area}m²";
                lblResultSolid.Text = resultStr;
            }
            else if (force == 0)
            {
                rd1Solid.Visible = false;
                rd2Solid.Visible = false;
                rd3Solid.Visible = false;
                var result = $"{pressure * area}N";
                lblPressureSolidResult.Text = $"{pressure}Pa";
                lblForceResult.Text = result;
                lblAreaResult.Text = $"{area}m²";
                lblResultSolid.Text = result;
            }
            else if (area == 0)
            {
                rd1Solid.Visible = true; rd1Solid.Text = "m²";
                rd2Solid.Visible = true; rd2Solid.Text = "cm²";
                rd3Solid.Visible = false;
                var result = force / pressure;
                string resultStr;

                if (rd1Solid.Checked) resultStr = String.Format("{0:0.00}", result) + "m²";
                else resultStr = String.Format("{0:0.00}", result * 10000) + "cm²";

                lblPressureSolidResult.Text = $"{pressure}Pa";
                lblForceResult.Text = $"{force}N";
                lblAreaResult.Text = resultStr;
                lblResultSolid.Text = resultStr;
            }
            else if (force / area == pressure)
            {
                MessageBox.Show("The equation is valid.", "Valid", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The eqaution is not valid.", "Not valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PressureFrm_Load(object sender, EventArgs e)
        {
            cmbForceUnit.SelectedIndex = 0;
            cmbAreaUnit.SelectedIndex = 0;
            cmbPressureUnitSolid.SelectedIndex = 0;
            cmbRhoUnit.SelectedIndex = 0;
            cmbGUnit.SelectedIndex = 0;
            cmbHeightUnit.SelectedIndex = 0;
            cmbPressureUnitFliud.SelectedIndex = 0;
        }

        private void btnCalculateFliuds_Click(object sender, EventArgs e)
        {
            decimal rho = cmbRhoUnit.SelectedIndex == 0 ? numRho.Value : numRho.Value * 1000;
            decimal g = numG.Value;
            decimal height = cmbHeightUnit.SelectedIndex == 0 ? numHeight.Value : numHeight.Value / 100;
            decimal pressure = cmbPressureUnitFliud.SelectedIndex == 0 ? numPressureFliud.Value : numPressureFliud.Value * 101300;

            if (pressure == 0)
            {
                rd1Fliud.Visible = true; rd1Fliud.Text = "SI Unit";
                rd2Fliud.Visible = true; rd2Fliud.Text = "atm";
                rd3Fliud.Visible = true; rd3Fliud.Text = "cmHg";

                var result = rho * g * height;
                string resultStr;

                if (rd2Fliud.Checked) resultStr = String.Format("{0:0.00}", result / 101300) + "atm";
                else if (rd3Fliud.Checked) resultStr = String.Format("{0:0.00}", result / 133) + "cmHg";
                else resultStr = String.Format("{0:0.00}", result) + "Pa";

                lblRho.Text = rho + "Kg/m³";
                lblG.Text = g + "m/s²";
                lblHeight.Text = height + "m";
                lblPressureFliuds.Text = result + "Pa";

                lblResultFliuds.Text = resultStr;
            }
            else if (rho == 0)
            {
                if (pressure == 0)
                {
                    MessageBox.Show("Pressure cannot be 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                rd1Fliud.Visible = true; rd1Fliud.Text = "Kg/m³";
                rd2Fliud.Visible = true; rd2Fliud.Text = "g/cm²";
                rd3Fliud.Visible = false;

                var result = pressure / g / height;
                string resultStr;

                if (rd2Fliud.Checked) resultStr = String.Format("{0:0.00}", result / 1000) + "g/cm²";
                else resultStr = String.Format("{0:0.00}", result) + "Kg/m³";

                lblRho.Text = result + "Kg/m³";
                lblG.Text = g + "m/s²";
                lblHeight.Text = height + "m";
                lblPressureFliuds.Text = pressure + "Pa";
                lblResultFliuds.Text = resultStr;
            }
            else if (g == 0)
            {
                if (pressure == 0)
                {
                    MessageBox.Show("Pressure cannot be 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                rd1Fliud.Visible = false;
                rd2Fliud.Visible = false;
                rd3Fliud.Visible = false;

                var result = pressure / rho / height;
                string resultStr = String.Format("{0:0.00}", result) + "m/s²";

                lblRho.Text = rho + "Kg/m³";
                lblG.Text = resultStr;
                lblHeight.Text = height + "m";
                lblPressureFliuds.Text = pressure + "Pa";
                lblResultFliuds.Text = resultStr;
            }
            else if (height == 0)
            {
                if (pressure == 0)
                {
                    MessageBox.Show("Pressure cannot be 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                rd1Fliud.Visible = true; rd1Fliud.Text = "m";
                rd2Fliud.Visible = true; rd2Fliud.Text = "cm";
                rd3Fliud.Visible = false;

                var result = pressure / rho / g;
                string resultStr;

                if (rd2Fliud.Checked) resultStr = String.Format("{0:0.00}", result * 100) + "cm";
                else resultStr = String.Format("{0:0.00}", result) + "m";

                lblRho.Text = rho + "Kg/m³";
                lblG.Text = g + "m/s²";
                lblHeight.Text = result + "m";
                lblPressureFliuds.Text = pressure + "Pa";
                lblResultFliuds.Text = resultStr;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            string result = Regex.Replace(lblResultSolid.Text, "[a-zA-Z/²³]", "");
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

        private void button2_Click(object sender, EventArgs e)
        {
            string result = Regex.Replace(lblResultFliuds.Text, "[a-zA-Z/²³]", "");
            try
            {
                Clipboard.SetText(result);
                MessageBox.Show("Copied!", "Done", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Error copying the result to clipboard.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
