namespace LTUD
{
    partial class gameVsBot
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            CScore = new Label();
            PScore = new Label();
            Announcement = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 25.8000011F, FontStyle.Bold);
            button1.Location = new Point(36, 97);
            button1.Name = "button1";
            button1.Size = new Size(104, 104);
            button1.TabIndex = 0;
            button1.Tag = "play";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Comic Sans MS", 25.8000011F, FontStyle.Bold);
            button2.Location = new Point(146, 97);
            button2.Name = "button2";
            button2.Size = new Size(104, 104);
            button2.TabIndex = 1;
            button2.Tag = "play";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Comic Sans MS", 25.8000011F, FontStyle.Bold);
            button3.Location = new Point(256, 97);
            button3.Name = "button3";
            button3.Size = new Size(104, 104);
            button3.TabIndex = 2;
            button3.Tag = "play";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Comic Sans MS", 25.8000011F, FontStyle.Bold);
            button4.Location = new Point(36, 207);
            button4.Name = "button4";
            button4.Size = new Size(104, 104);
            button4.TabIndex = 3;
            button4.Tag = "play";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Comic Sans MS", 25.8000011F, FontStyle.Bold);
            button5.Location = new Point(146, 207);
            button5.Name = "button5";
            button5.Size = new Size(104, 104);
            button5.TabIndex = 4;
            button5.Tag = "play";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Comic Sans MS", 25.8000011F, FontStyle.Bold);
            button6.Location = new Point(256, 207);
            button6.Name = "button6";
            button6.Size = new Size(104, 104);
            button6.TabIndex = 5;
            button6.Tag = "play";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Comic Sans MS", 25.8000011F, FontStyle.Bold);
            button7.Location = new Point(36, 317);
            button7.Name = "button7";
            button7.Size = new Size(104, 104);
            button7.TabIndex = 6;
            button7.Tag = "play";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Comic Sans MS", 25.8000011F, FontStyle.Bold);
            button8.Location = new Point(146, 317);
            button8.Name = "button8";
            button8.Size = new Size(104, 104);
            button8.TabIndex = 7;
            button8.Tag = "play";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Comic Sans MS", 25.8000011F, FontStyle.Bold);
            button9.Location = new Point(256, 317);
            button9.Name = "button9";
            button9.Size = new Size(104, 104);
            button9.TabIndex = 8;
            button9.Tag = "play";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            button10.Location = new Point(483, 251);
            button10.Name = "button10";
            button10.Size = new Size(213, 45);
            button10.TabIndex = 9;
            button10.Text = "PLAY AGAIN";
            button10.UseVisualStyleBackColor = true;
            button10.Click += Restart;
            // 
            // button11
            // 
            button11.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.Location = new Point(483, 317);
            button11.Name = "button11";
            button11.Size = new Size(213, 45);
            button11.TabIndex = 10;
            button11.Text = "BACK TO HOME SCREEN";
            button11.UseVisualStyleBackColor = true;
            button11.Click += GoBack;
            // 
            // CScore
            // 
            CScore.AutoSize = true;
            CScore.BackColor = Color.DodgerBlue;
            CScore.Font = new Font("Georgia", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CScore.Location = new Point(373, 158);
            CScore.Name = "CScore";
            CScore.Size = new Size(415, 43);
            CScore.TabIndex = 26;
            CScore.Tag = "play";
            CScore.Text = "Computer's Score - 0";
            // 
            // PScore
            // 
            PScore.AutoSize = true;
            PScore.BackColor = Color.DodgerBlue;
            PScore.Font = new Font("Georgia", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PScore.Location = new Point(408, 103);
            PScore.Name = "PScore";
            PScore.Size = new Size(345, 43);
            PScore.TabIndex = 25;
            PScore.Text = "Player's Score - 0";
            // 
            // Announcement
            // 
            Announcement.AutoSize = true;
            Announcement.BackColor = Color.Transparent;
            Announcement.Font = new Font("Comic Sans MS", 25.8000011F, FontStyle.Bold);
            Announcement.Location = new Point(289, 9);
            Announcement.Name = "Announcement";
            Announcement.Size = new Size(250, 60);
            Announcement.TabIndex = 27;
            Announcement.Tag = "";
            Announcement.Text = "Good Luck!";
            // 
            // gameVsBot
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(Announcement);
            Controls.Add(CScore);
            Controls.Add(PScore);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "gameVsBot";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "gameVsBot";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Label CScore;
        private Label PScore;
        private Label Announcement;
    }
}