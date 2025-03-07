namespace PhysicsSolver
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
        }

        private void btnPresure_Click(object sender, EventArgs e)
        {
            var frmPressure = new PressureFrm();
            frmPressure.Show();
        }
    }
}
