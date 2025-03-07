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
        }

        private void PressureFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
