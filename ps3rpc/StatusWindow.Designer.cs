namespace ps3rpc
{
    partial class StatusWindow
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusWindow));
            nameLabel = new Label();
            GameCover = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timerLabel = new Label();
            refreshButton = new Button();
            elapsedLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)GameCover).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(28, 265);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(123, 42);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Assassin's Creed III\r\nUbisoft\r\nPSN";
            // 
            // GameCover
            // 
            GameCover.BorderStyle = BorderStyle.Fixed3D;
            GameCover.ImageLocation = "https://images.igdb.com/igdb/image/upload/t_720p/co1xii.jpg";
            GameCover.Location = new Point(76, 21);
            GameCover.Name = "GameCover";
            GameCover.Size = new Size(180, 240);
            GameCover.SizeMode = PictureBoxSizeMode.StretchImage;
            GameCover.TabIndex = 1;
            GameCover.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.Location = new Point(28, 307);
            timerLabel.Margin = new Padding(0);
            timerLabel.Name = "timerLabel";
            timerLabel.RightToLeft = RightToLeft.No;
            timerLabel.Size = new Size(65, 14);
            timerLabel.TabIndex = 2;
            timerLabel.Text = "00:00:00";
            timerLabel.TextAlign = ContentAlignment.MiddleCenter;
            timerLabel.Click += timerLabel_Click_1;
            // 
            // refreshButton
            // 
            refreshButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            refreshButton.Location = new Point(262, 286);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(62, 38);
            refreshButton.TabIndex = 3;
            refreshButton.Text = "Manual Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // elapsedLabel
            // 
            elapsedLabel.AutoSize = true;
            elapsedLabel.Location = new Point(90, 307);
            elapsedLabel.Name = "elapsedLabel";
            elapsedLabel.Size = new Size(53, 14);
            elapsedLabel.TabIndex = 4;
            elapsedLabel.Text = "elapsed";
            // 
            // StatusWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 336);
            Controls.Add(elapsedLabel);
            Controls.Add(refreshButton);
            Controls.Add(timerLabel);
            Controls.Add(GameCover);
            Controls.Add(nameLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "StatusWindow";
            Text = "PS3RPC";
            FormClosed += StatusWindow_FormClosed;
            Load += StatusWindow_Load;
            ((System.ComponentModel.ISupportInitialize)GameCover).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private PictureBox GameCover;
        private System.Windows.Forms.Timer timer1;
        private Label timerLabel;
        private Button refreshButton;
        private Label elapsedLabel;
    }
}