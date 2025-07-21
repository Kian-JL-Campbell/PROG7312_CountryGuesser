namespace PROG7312_GuessingGame
{
    partial class Form1
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
            panel1 = new Panel();
            HintLabel = new Label();
            ContextLabel = new Label();
            GuessLabel = new Label();
            SubmissionBox = new TextBox();
            SubmissionButton = new Button();
            RoundLabel = new Label();
            ScoreLabel = new Label();
            StartButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(HintLabel);
            panel1.Controls.Add(ContextLabel);
            panel1.Controls.Add(GuessLabel);
            panel1.Controls.Add(SubmissionBox);
            panel1.Controls.Add(SubmissionButton);
            panel1.Location = new Point(12, 143);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 295);
            panel1.TabIndex = 0;
            // 
            // HintLabel
            // 
            HintLabel.Location = new Point(20, 74);
            HintLabel.Name = "HintLabel";
            HintLabel.Size = new Size(740, 23);
            HintLabel.TabIndex = 4;
            HintLabel.Text = "Starts With: ";
            HintLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ContextLabel
            // 
            ContextLabel.Location = new Point(20, 51);
            ContextLabel.Name = "ContextLabel";
            ContextLabel.Size = new Size(740, 23);
            ContextLabel.TabIndex = 3;
            ContextLabel.Text = "Region: Africa";
            ContextLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GuessLabel
            // 
            GuessLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GuessLabel.BackColor = SystemColors.GradientActiveCaption;
            GuessLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GuessLabel.Location = new Point(0, -3);
            GuessLabel.Name = "GuessLabel";
            GuessLabel.Size = new Size(776, 45);
            GuessLabel.TabIndex = 2;
            GuessLabel.Text = "Guess: Country";
            GuessLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SubmissionBox
            // 
            SubmissionBox.Location = new Point(20, 203);
            SubmissionBox.Name = "SubmissionBox";
            SubmissionBox.Size = new Size(168, 23);
            SubmissionBox.TabIndex = 1;
            // 
            // SubmissionButton
            // 
            SubmissionButton.Location = new Point(20, 232);
            SubmissionButton.Name = "SubmissionButton";
            SubmissionButton.Size = new Size(168, 50);
            SubmissionButton.TabIndex = 0;
            SubmissionButton.Text = "Submit";
            SubmissionButton.UseVisualStyleBackColor = true;
            SubmissionButton.Click += SubmissionButton_Click;
            // 
            // RoundLabel
            // 
            RoundLabel.AutoSize = true;
            RoundLabel.Location = new Point(12, 125);
            RoundLabel.Name = "RoundLabel";
            RoundLabel.Size = new Size(54, 15);
            RoundLabel.TabIndex = 2;
            RoundLabel.Text = "Round: 1";
            // 
            // ScoreLabel
            // 
            ScoreLabel.AutoSize = true;
            ScoreLabel.Location = new Point(734, 125);
            ScoreLabel.Name = "ScoreLabel";
            ScoreLabel.Size = new Size(48, 15);
            ScoreLabel.TabIndex = 3;
            ScoreLabel.Text = "Score: 0";
            // 
            // StartButton
            // 
            StartButton.BackColor = SystemColors.Info;
            StartButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StartButton.Location = new Point(318, 39);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(168, 50);
            StartButton.TabIndex = 5;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Click += StartButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(StartButton);
            Controls.Add(ScoreLabel);
            Controls.Add(RoundLabel);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox SubmissionBox;
        private Button SubmissionButton;
        private Label RoundLabel;
        private Label ContextLabel;
        private Label GuessLabel;
        private Label HintLabel;
        private Label ScoreLabel;
        private Button StartButton;
    }
}
