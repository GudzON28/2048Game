namespace _2048WinFormsApp
{
    public partial class SettingsForm : Form
    {
        private List<Settings> setting = new List<Settings>();
        public List<Settings> AllSettings
        {
            get
            {
                return setting;
            }
        }

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            var allSettings = Game.GetSettings();

            foreach (var setting in allSettings)
            {
                if (setting.Name == "fieldSize")
                {
                    fieldSizeNumericUpDown.Value = Convert.ToInt32(setting.Value);
                }

                if (setting.Name == "undoLimitChecked")
                {
                    undoLimitCheckBox.Checked = Convert.ToBoolean(setting.Value);
                }

                if (setting.Name == "undoMaximumStep")
                {
                    undoLimitNumericUpDown.Value = Convert.ToInt32(setting.Value);
                }
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            setting.Add(new Settings("fieldSize", fieldSizeNumericUpDown.Value.ToString()));
            setting.Add(new Settings("undoLimitChecked", undoLimitCheckBox.Checked.ToString()));
            setting.Add(new Settings("undoMaximumStep", undoLimitNumericUpDown.Value.ToString()));

            Close();
        }

        private void undoLimitCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (undoLimitCheckBox.Checked)
            {
                undoLimitNumericUpDown.Enabled = true;
            }
            else
            {
                undoLimitNumericUpDown.Enabled = false;
            }
        }
    }
}
