namespace SimonVicentin
{
    partial class SimonForm
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
            components = new System.ComponentModel.Container();
            greenButton = new Button();
            redButton = new Button();
            yellowButton = new Button();
            blueButton = new Button();
            startButton = new Button();
            timer = new System.Windows.Forms.Timer(components);
            endGamePanel = new FlowLayoutPanel();
            endGameText = new Label();
            endGamePanel.SuspendLayout();
            SuspendLayout();
            // 
            // greenButton
            // 
            greenButton.BackColor = Color.ForestGreen;
            greenButton.CausesValidation = false;
            greenButton.Enabled = false;
            greenButton.Location = new Point(33, 27);
            greenButton.Name = "greenButton";
            greenButton.Size = new Size(128, 122);
            greenButton.TabIndex = 0;
            greenButton.UseVisualStyleBackColor = false;
            greenButton.Click += greenButton_Click;
            // 
            // redButton
            // 
            redButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            redButton.BackColor = Color.DarkRed;
            redButton.Enabled = false;
            redButton.Location = new Point(171, 27);
            redButton.Name = "redButton";
            redButton.Size = new Size(128, 122);
            redButton.TabIndex = 1;
            redButton.UseVisualStyleBackColor = false;
            redButton.Click += redButton_Click;
            // 
            // yellowButton
            // 
            yellowButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            yellowButton.BackColor = Color.DarkKhaki;
            yellowButton.Enabled = false;
            yellowButton.Location = new Point(33, 159);
            yellowButton.Name = "yellowButton";
            yellowButton.Size = new Size(128, 122);
            yellowButton.TabIndex = 2;
            yellowButton.UseVisualStyleBackColor = false;
            yellowButton.Click += yellowButton_Click;
            // 
            // blueButton
            // 
            blueButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            blueButton.BackColor = Color.SteelBlue;
            blueButton.Enabled = false;
            blueButton.Location = new Point(171, 159);
            blueButton.Name = "blueButton";
            blueButton.Size = new Size(128, 122);
            blueButton.TabIndex = 3;
            blueButton.UseVisualStyleBackColor = false;
            blueButton.Click += blueButton_Click;
            // 
            // startButton
            // 
            startButton.Anchor = AnchorStyles.Bottom;
            startButton.Location = new Point(129, 301);
            startButton.Name = "startButton";
            startButton.Size = new Size(75, 23);
            startButton.TabIndex = 4;
            startButton.Text = "Comenzar";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // timer
            // 
            timer.Interval = 500;
            timer.Tick += timer_Tick;
            // 
            // endGamePanel
            // 
            endGamePanel.Controls.Add(endGameText);
            endGamePanel.Location = new Point(12, 12);
            endGamePanel.Name = "endGamePanel";
            endGamePanel.Size = new Size(306, 30);
            endGamePanel.TabIndex = 5;
            endGamePanel.Visible = false;
            // 
            // endGameText
            // 
            endGameText.AutoSize = true;
            endGameText.Location = new Point(3, 0);
            endGameText.Name = "endGameText";
            endGameText.Size = new Size(0, 15);
            endGameText.TabIndex = 1;
            // 
            // SimonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 336);
            Controls.Add(endGamePanel);
            Controls.Add(startButton);
            Controls.Add(blueButton);
            Controls.Add(yellowButton);
            Controls.Add(redButton);
            Controls.Add(greenButton);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximumSize = new Size(355, 375);
            MinimumSize = new Size(355, 375);
            Name = "SimonForm";
            Text = "Simon";
            endGamePanel.ResumeLayout(false);
            endGamePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button greenButton;
        private Button redButton;
        private Button yellowButton;
        private Button blueButton;
        private Button startButton;
        private System.Windows.Forms.Timer timer;
        private FlowLayoutPanel endGamePanel;
        private Label endGameText;
    }
}
