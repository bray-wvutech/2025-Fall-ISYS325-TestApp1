using System.Linq.Expressions;

namespace _2025_Fall_ISYS325_TestApp1
{
    public partial class MainForm : Form
    {
        private const string HELLO_MSG = "Hello World";
        private const string CAR_MSG = "You clicked the car!";

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnPushMe_Click(object sender, EventArgs e)
        {
            lblHelloWorld.ForeColor = Color.Red;

            try
            {
                decimal test = decimal.Parse(txtTest.Text);
                string.Format("You are {0:C} years old", test);
                lblHelloWorld.Text = $"You are {test:C} years old";
            }
            catch
            {
                MessageBox.Show("There was an exception!");
            }
            finally
            {
                picChangedCar.Visible = !picChangedCar.Visible;
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "";


        
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picBlueCar_Click(object sender, EventArgs e)
        {
            lblHelloWorld.ForeColor = Color.Black;
            lblHelloWorld.Text = CAR_MSG;
        }
    }
}
