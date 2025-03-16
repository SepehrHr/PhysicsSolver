namespace PhysicsSolver
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            InitializeComponent();
        }

        private void btnPresure_Click(object sender, EventArgs e)
        {
            var frmPressure = new PressureFrm();
            frmPressure.Icon = Icon;
            frmPressure.Show();
        }
    }
}
