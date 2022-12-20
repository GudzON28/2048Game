namespace _2048WinFormsApp
{
    public partial class UserNameForm : Form
    {

        public string UserName
        {
            get { return userNameTextBox.Text.Trim(); }
        }

        public UserNameForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UserNameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (userNameTextBox.Text == string.Empty && DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Вы забыли ввести имя");
                e.Cancel = true;
            }
        }
    }
}
