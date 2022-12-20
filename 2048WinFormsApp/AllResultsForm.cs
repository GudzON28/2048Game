namespace _2048WinFormsApp
{
    public partial class AllResultsForm : Form
    {
        private bool isSpecifiedUserResults = false;
        private string userName;

        public AllResultsForm()
        {
            InitializeComponent();
        }
        public AllResultsForm(string name)
        {
            InitializeComponent();

            isSpecifiedUserResults = true;
            userName = name;
        }

        private void AllResultsForm_Load(object sender, EventArgs e)
        {
            var allResults = Game.GetUserResults();
            allResults = Game.SortingUsers(allResults);

            if (isSpecifiedUserResults)
            {
                foreach (var result in allResults)
                {
                    if (result.Name == userName)
                    {
                        resultsDataGridView.Rows.Add(result.Name, result.Score);
                    }
                }
            }
            else
            {
                foreach (var result in allResults)
                {
                    resultsDataGridView.Rows.Add(result.Name, result.Score);
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
