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
            if (numPressureSolid.Value == 0)
            {
                if (numArea.Value == 0)
                {
                    MessageBox.Show("Area cannot be 0!", "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
                    return;
                }
                var result = $"{numForce.Value / numArea.Value}Pa";
                lblPressureSolidResult.Text = result;
                lblForceResult.Text = $"{numForce.Value}N";
                lblAreaResult.Text = $"{numArea.Value} square meters";
                lblResultSolid.Text = result;
            }
            else if(numForce.Value == 0)
            {
                var result = $"{numPressureSolid.Value * numArea.Value}N";
                lblPressureSolidResult.Text = $"{numPressureSolid.Value}Pa";
                lblForceResult.Text = result;
                lblAreaResult.Text = $"{numArea.Value} square meters";
                lblResultSolid.Text = result;
            }
            else if(numArea.Value == 0)
            {
                var result = $"{numForce.Value / numPressureSolid.Value} Square meters";
                lblPressureSolidResult.Text = $"{numPressureSolid.Value}Pa";
                lblForceResult.Text = $"{numForce.Value}N";
                lblAreaResult.Text = result;
                lblResultSolid.Text = result;
            }
            else if(numForce.Value / numArea.Value == numPressureSolid.Value)
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

        }
    }
}
