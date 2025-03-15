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
            decimal pressure = cmbPressureUnitSolid.SelectedIndex == 0 ? numPressureSolid.Value : numPressureSolid.Value * 100000;
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
        }
    }
}
