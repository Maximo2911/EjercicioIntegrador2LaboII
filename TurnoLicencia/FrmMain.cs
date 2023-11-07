namespace TurnoLicencia
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnBienvenido_Click(object sender, EventArgs e)
        {
            FrmTurno frmLogin = new FrmTurno();
            frmLogin.ShowDialog(); //ó frmLogin.Visible = True;
        }
    }
}