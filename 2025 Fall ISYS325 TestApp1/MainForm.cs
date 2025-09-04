namespace _2025_Fall_ISYS325_TestApp1
{
    public partial class MainForm : Form
    {
        private const string HELLO_MSG = "Hello World";

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnPushMe_Click(object sender, EventArgs e)
        {
            lblHelloWorld.ForeColor = Color.Red;
            lblHelloWorld.Text = HELLO_MSG;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
