namespace PhysicsSolver
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            InitializeComponent();
        }

        private void btnPressure_Click(object sender, EventArgs e)
        {
            var frmPressure = new PressureFrm();
            frmPressure.Icon = Icon;
            frmPressure.Show();
        }

        private void btnDensity_Click(object sender, EventArgs e)
        {
            var frmDesity = new Density();
            frmDesity.Icon = Icon;
            frmDesity.Show();
        }

        private void btnKinetic_Click(object sender, EventArgs e)
        {
            var frmDesity = new KineticEnergy();
            frmDesity.Icon = Icon;
            frmDesity.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var frmWork = new Work();
            frmWork.Icon = Icon;
            frmWork.Show();
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            var frmU = new Gravitational();
            frmU.Icon = Icon;
            frmU.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frmHeat = new Heat();
            frmHeat.Icon = Icon;
            frmHeat.Show();
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            var frmPower = new Power();
            frmPower.Icon = Icon;
            frmPower.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            var frmAbout = new About();
            frmAbout.Icon = Icon;
            frmAbout.Show();
        }
    }
}
