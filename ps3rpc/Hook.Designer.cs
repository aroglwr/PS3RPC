namespace ps3rpc
{
    partial class Hook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hook));
            attachButton = new Button();
            ipBox = new TextBox();
            ipLabel = new Label();
            infoButton = new Button();
            cfgButton = new Button();
            SuspendLayout();
            // 
            // attachButton
            // 
            attachButton.Location = new Point(230, 88);
            attachButton.Name = "attachButton";
            attachButton.Size = new Size(58, 25);
            attachButton.TabIndex = 0;
            attachButton.Text = "Attach";
            attachButton.UseVisualStyleBackColor = true;
            attachButton.Click += attachButton_Click;
            // 
            // ipBox
            // 
            ipBox.Location = new Point(124, 89);
            ipBox.Name = "ipBox";
            ipBox.PlaceholderText = "192.168.1.0";
            ipBox.Size = new Size(100, 23);
            ipBox.TabIndex = 2;
            ipBox.Text = "192.168.1.221";
            ipBox.TextChanged += ipBox_TextChanged;
            // 
            // ipLabel
            // 
            ipLabel.AutoSize = true;
            ipLabel.Location = new Point(124, 70);
            ipLabel.Name = "ipLabel";
            ipLabel.Size = new Size(76, 14);
            ipLabel.TabIndex = 3;
            ipLabel.Text = "IP Address:";
            // 
            // infoButton
            // 
            infoButton.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            infoButton.Location = new Point(353, 169);
            infoButton.Name = "infoButton";
            infoButton.Size = new Size(48, 22);
            infoButton.TabIndex = 4;
            infoButton.Text = "About";
            infoButton.UseVisualStyleBackColor = true;
            infoButton.Click += infoButton_Click;
            // 
            // cfgButton
            // 
            cfgButton.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            cfgButton.Location = new Point(353, 144);
            cfgButton.Name = "cfgButton";
            cfgButton.Size = new Size(48, 22);
            cfgButton.TabIndex = 5;
            cfgButton.Text = "Config";
            cfgButton.UseVisualStyleBackColor = true;
            cfgButton.Click += cfgButton_Click;
            // 
            // Hook
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 203);
            Controls.Add(cfgButton);
            Controls.Add(infoButton);
            Controls.Add(ipLabel);
            Controls.Add(ipBox);
            Controls.Add(attachButton);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Hook";
            Text = "PS3RPC";
            Load += Hook_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button attachButton;
        private TextBox ipBox;
        private Label ipLabel;
        private Button infoButton;
        private Button cfgButton;
    }
}
