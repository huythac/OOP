namespace ProjectOOP
{
    public partial class formSplash : Form
    {
        public formSplash()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnStartNow_Click(object sender, EventArgs e)
        {
            new formSignIn().Show();
            this.Hide();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            new formSignUp().Show();
            this.Hide();
        }

        private void formSplash_Load(object sender, EventArgs e)
        {

        }
    }
}
