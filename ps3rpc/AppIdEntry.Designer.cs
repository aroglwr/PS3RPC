namespace ps3rpc
{
    partial class AppIdEntry
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
            appIdButton = new Button();
            appIdBox = new TextBox();
            appIdLabel = new Label();
            closeButton = new Button();
            appIdConfLabel = new Label();
            intervalConfLabel = new Label();
            refreshBox = new NumericUpDown();
            resetConf = new Button();
            notifLabel = new Label();
            notifBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)refreshBox).BeginInit();
            SuspendLayout();
            // 
            // appIdButton
            // 
            appIdButton.Location = new Point(148, 144);
            appIdButton.Name = "appIdButton";
            appIdButton.Size = new Size(75, 23);
            appIdButton.TabIndex = 0;
            appIdButton.Text = "Save";
            appIdButton.UseVisualStyleBackColor = true;
            appIdButton.Click += appIdButton_Click;
            // 
            // appIdBox
            // 
            appIdBox.Location = new Point(99, 36);
            appIdBox.Name = "appIdBox";
            appIdBox.PlaceholderText = "Enter ID";
            appIdBox.Size = new Size(205, 23);
            appIdBox.TabIndex = 1;
            appIdBox.TextChanged += appIdBox_TextChanged;
            // 
            // appIdLabel
            // 
            appIdLabel.Anchor = AnchorStyles.Top;
            appIdLabel.AutoSize = true;
            appIdLabel.Location = new Point(12, 9);
            appIdLabel.Name = "appIdLabel";
            appIdLabel.Size = new Size(55, 14);
            appIdLabel.TabIndex = 2;
            appIdLabel.Text = "Settings";
            appIdLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(229, 144);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 3;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // appIdConfLabel
            // 
            appIdConfLabel.AutoSize = true;
            appIdConfLabel.Location = new Point(12, 40);
            appIdConfLabel.Name = "appIdConfLabel";
            appIdConfLabel.Size = new Size(53, 14);
            appIdConfLabel.TabIndex = 4;
            appIdConfLabel.Text = "App ID:";
            // 
            // intervalConfLabel
            // 
            intervalConfLabel.AutoSize = true;
            intervalConfLabel.Location = new Point(12, 73);
            intervalConfLabel.Name = "intervalConfLabel";
            intervalConfLabel.Size = new Size(170, 14);
            intervalConfLabel.TabIndex = 5;
            intervalConfLabel.Text = "Refresh Interval (seconds):";
            // 
            // refreshBox
            // 
            refreshBox.Location = new Point(249, 69);
            refreshBox.Name = "refreshBox";
            refreshBox.Size = new Size(55, 23);
            refreshBox.TabIndex = 6;
            // 
            // resetConf
            // 
            resetConf.Location = new Point(12, 144);
            resetConf.Name = "resetConf";
            resetConf.Size = new Size(75, 23);
            resetConf.TabIndex = 7;
            resetConf.Text = "Reset";
            resetConf.UseVisualStyleBackColor = true;
            resetConf.Click += resetConf_Click;
            // 
            // notifLabel
            // 
            notifLabel.AutoSize = true;
            notifLabel.Location = new Point(12, 101);
            notifLabel.Name = "notifLabel";
            notifLabel.Size = new Size(145, 14);
            notifLabel.TabIndex = 8;
            notifLabel.Text = "Show PS3 Notification:";
            // 
            // notifBox
            // 
            notifBox.AutoSize = true;
            notifBox.Location = new Point(289, 101);
            notifBox.Name = "notifBox";
            notifBox.Size = new Size(15, 14);
            notifBox.TabIndex = 9;
            notifBox.UseVisualStyleBackColor = true;
            notifBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // AppIdEntry
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 179);
            Controls.Add(notifBox);
            Controls.Add(notifLabel);
            Controls.Add(resetConf);
            Controls.Add(refreshBox);
            Controls.Add(intervalConfLabel);
            Controls.Add(appIdConfLabel);
            Controls.Add(closeButton);
            Controls.Add(appIdLabel);
            Controls.Add(appIdBox);
            Controls.Add(appIdButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AppIdEntry";
            Text = "Configuration";
            ((System.ComponentModel.ISupportInitialize)refreshBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button appIdButton;
        private TextBox appIdBox;
        private Label appIdLabel;
        private Button closeButton;
        private Label appIdConfLabel;
        private Label intervalConfLabel;
        private NumericUpDown refreshBox;
        private Button resetConf;
        private Label notifLabel;
        private CheckBox notifBox;
    }
}