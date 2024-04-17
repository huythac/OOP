namespace ProjectOOP
{
    public partial class formHome : Form
    {
        public formHome()
        {
            InitializeComponent();
        }

        private void formHome_Load(object sender, EventArgs e)
        {
            
        }

        private void btnStartNow_Click(object sender, EventArgs e)
        {
            Hide();
            new formFood().ShowDialog();
            Close();
        }
    }
}
