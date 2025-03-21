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
    }
}
