namespace _2048WinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultsCurrentUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.canceMovelButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.undoStepLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.statisticToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "&Файл";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.restartToolStripMenuItem.Text = "&Перезапуск игры";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.exitToolStripMenuItem.Text = "&Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statisticToolStripMenuItem
            // 
            this.statisticToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestResultToolStripMenuItem,
            this.resultsCurrentUserToolStripMenuItem,
            this.allResultsToolStripMenuItem});
            this.statisticToolStripMenuItem.Name = "statisticToolStripMenuItem";
            this.statisticToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.statisticToolStripMenuItem.Text = "&Статистика";
            // 
            // bestResultToolStripMenuItem
            // 
            this.bestResultToolStripMenuItem.Name = "bestResultToolStripMenuItem";
            this.bestResultToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.bestResultToolStripMenuItem.Text = "&Лучший результат";
            this.bestResultToolStripMenuItem.Click += new System.EventHandler(this.bestResultToolStripMenuItem_Click);
            // 
            // resultsCurrentUserToolStripMenuItem
            // 
            this.resultsCurrentUserToolStripMenuItem.Name = "resultsCurrentUserToolStripMenuItem";
            this.resultsCurrentUserToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.resultsCurrentUserToolStripMenuItem.Text = "&Результы текущего пользователя";
            this.resultsCurrentUserToolStripMenuItem.Click += new System.EventHandler(this.resultsCurrentUserToolStripMenuItem_Click);
            // 
            // allResultsToolStripMenuItem
            // 
            this.allResultsToolStripMenuItem.Name = "allResultsToolStripMenuItem";
            this.allResultsToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.allResultsToolStripMenuItem.Text = "&Все результаты";
            this.allResultsToolStripMenuItem.Click += new System.EventHandler(this.allResultsToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.settingsToolStripMenuItem.Text = "&Настройки";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rulesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.helpToolStripMenuItem.Text = "&Справка";
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.rulesToolStripMenuItem.Text = "&Правила игры";
            this.rulesToolStripMenuItem.Click += new System.EventHandler(this.rulesToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Счёт:";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(54, 24);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(13, 15);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "0";
            // 
            // userNameLabel
            // 
            this.userNameLabel.Location = new System.Drawing.Point(100, 24);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(122, 15);
            this.userNameLabel.TabIndex = 3;
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // canceMovelButton
            // 
            this.canceMovelButton.AutoSize = true;
            this.canceMovelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.canceMovelButton.Enabled = false;
            this.canceMovelButton.Location = new System.Drawing.Point(0, 331);
            this.canceMovelButton.Name = "canceMovelButton";
            this.canceMovelButton.Size = new System.Drawing.Size(284, 30);
            this.canceMovelButton.TabIndex = 5;
            this.canceMovelButton.Text = "&Отмена хода";
            this.canceMovelButton.UseVisualStyleBackColor = true;
            this.canceMovelButton.Click += new System.EventHandler(this.cancelMoveButton_Click);
            this.canceMovelButton.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MainForm_PreviewKeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ходов для отмены:";
            // 
            // undoStepLabel
            // 
            this.undoStepLabel.AutoSize = true;
            this.undoStepLabel.Location = new System.Drawing.Point(207, 24);
            this.undoStepLabel.Name = "undoStepLabel";
            this.undoStepLabel.Size = new System.Drawing.Size(13, 15);
            this.undoStepLabel.TabIndex = 7;
            this.undoStepLabel.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.undoStepLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.canceMovelButton);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра \"2048\"";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MainForm_PreviewKeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem restartToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem rulesToolStripMenuItem;
        private Label label1;
        private Label scoreLabel;
        private Label userNameLabel;
        private ToolStripMenuItem statisticToolStripMenuItem;
        private ToolStripMenuItem bestResultToolStripMenuItem;
        private ToolStripMenuItem resultsCurrentUserToolStripMenuItem;
        private ToolStripMenuItem allResultsToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private Button canceMovelButton;
        private Label label2;
        private Label undoStepLabel;
    }
}