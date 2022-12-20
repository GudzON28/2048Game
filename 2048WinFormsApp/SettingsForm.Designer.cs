namespace _2048WinFormsApp
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.fieldSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.okButton = new System.Windows.Forms.Button();
            this.undoLimitCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.undoLimitNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.fieldSizeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.undoLimitNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Размер игрового поля";
            // 
            // fieldSizeNumericUpDown
            // 
            this.fieldSizeNumericUpDown.Location = new System.Drawing.Point(149, 12);
            this.fieldSizeNumericUpDown.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.fieldSizeNumericUpDown.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.fieldSizeNumericUpDown.Name = "fieldSizeNumericUpDown";
            this.fieldSizeNumericUpDown.ReadOnly = true;
            this.fieldSizeNumericUpDown.Size = new System.Drawing.Size(40, 23);
            this.fieldSizeNumericUpDown.TabIndex = 1;
            this.fieldSizeNumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(12, 127);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(228, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "&ОК";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // undoLimitCheckBox
            // 
            this.undoLimitCheckBox.AutoSize = true;
            this.undoLimitCheckBox.Location = new System.Drawing.Point(12, 54);
            this.undoLimitCheckBox.Name = "undoLimitCheckBox";
            this.undoLimitCheckBox.Size = new System.Drawing.Size(240, 19);
            this.undoLimitCheckBox.TabIndex = 3;
            this.undoLimitCheckBox.Text = "&Включить ограничение \"отмены хода\"";
            this.undoLimitCheckBox.UseVisualStyleBackColor = true;
            this.undoLimitCheckBox.CheckedChanged += new System.EventHandler(this.undoLimitCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "&Ограничение";
            // 
            // undoLimtNumericUpDown
            // 
            this.undoLimitNumericUpDown.Enabled = false;
            this.undoLimitNumericUpDown.Location = new System.Drawing.Point(149, 79);
            this.undoLimitNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.undoLimitNumericUpDown.Name = "undoLimtNumericUpDown";
            this.undoLimitNumericUpDown.ReadOnly = true;
            this.undoLimitNumericUpDown.Size = new System.Drawing.Size(40, 23);
            this.undoLimitNumericUpDown.TabIndex = 5;
            this.undoLimitNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 157);
            this.Controls.Add(this.undoLimitNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.undoLimitCheckBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.fieldSizeNumericUpDown);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра \"2048\". Настройки";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fieldSizeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.undoLimitNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private NumericUpDown fieldSizeNumericUpDown;
        private Button okButton;
        private CheckBox undoLimitCheckBox;
        private Label label2;
        private NumericUpDown undoLimitNumericUpDown;
    }
}