namespace LTUD
{
    partial class gameVsHuman
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
            button11 = new Button();
            button10 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            Announcement = new Label();
            P1Score = new Label();
            P2Score = new Label();
            SuspendLayout();
            // 
            // button11
            // 
            button11.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.Location = new Point(488, 342);
            button11.Name = "button11";
            button11.Size = new Size(213, 45);
            button11.TabIndex = 21;
            button11.Text = "BACK TO HOME SCREEN";
            button11.UseVisualStyleBackColor = true;
            button11.Click += GoBack;
            // 
            // button10
            // 
            button10.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            button10.Location = new Point(488, 276);
            button10.Name = "button10";
            button10.Size = new Size(213, 45);
            button10.TabIndex = 20;
            button10.Text = "PLAY AGAIN";
            button10.UseVisualStyleBackColor = true;
            button10.Click += Restart;
            // 
            // button7
            // 
            button7.Font = new Font("Comic Sans MS", 25.8000011F, FontStyle.Bold);
            button7.Location = new Point(36, 328);
            button7.Name = "button7";
            button7.Size = new Size(104, 104);
            button7.TabIndex = 17;
            button7.Tag = "play";
            button7.Text = "?";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Comic Sans MS", 25.8000011F, FontStyle.Bold);
            button8.Location = new Point(146, 328);
            button8.Name = "button8";
            button8.Size = new Size(104, 104);
            button8.TabIndex = 18;
            button8.Tag = "play";
            button8.Text = "?";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Comic Sans MS", 25.8000011F, FontStyle.Bold);
            button9.Location = new Point(256, 328);
            button9.Name = "button9";
            button9.Size = new Size(104, 104);
            button9.TabIndex = 19;
            button9.Tag = "play";
            button9.Text = "?";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Comic Sans MS", 25.8000011F, FontStyle.Bold);
            button4.Location = new Point(36, 218);
            button4.Name = "button4";
            button4.Size = new Size(104, 104);
            button4.TabIndex = 14;
            button4.Tag = "play";
            button4.Text = "?";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Comic Sans MS", 25.8000011F, FontStyle.Bold);
            button5.Location = new Point(146, 218);
            button5.Name = "button5";
            button5.Size = new Size(104, 104);
            button5.TabIndex = 15;
            button5.Tag = "play";
            button5.Text = "?";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Comic Sans MS", 25.8000011F, FontStyle.Bold);
            button6.Location = new Point(256, 218);
            button6.Name = "button6";
            button6.Size = new Size(104, 104);
            button6.TabIndex = 16;
            button6.Tag = "play";
            button6.Text = "?";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Comic Sans MS", 25.8000011F, FontStyle.Bold);
            button3.Location = new Point(256, 108);
            button3.Name = "button3";
            button3.Size = new Size(104, 104);
            button3.TabIndex = 13;
            button3.Tag = "play";
            button3.Text = "?";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Comic Sans MS", 25.8000011F, FontStyle.Bold);
            button2.Location = new Point(146, 108);
            button2.Name = "button2";
            button2.Size = new Size(104, 104);
            button2.TabIndex = 12;
            button2.Tag = "play";
            button2.Text = "?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 25.8000011F, FontStyle.Bold);
            button1.Location = new Point(36, 108);
            button1.Name = "button1";
            button1.Size = new Size(104, 104);
            button1.TabIndex = 11;
            button1.Tag = "play";
            button1.Text = "?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Announcement
            // 
            Announcement.AutoSize = true;
            Announcement.BackColor = Color.Transparent;
            Announcement.Font = new Font("Georgia", 36F, FontStyle.Bold);
            Announcement.Location = new Point(146, 9);
            Announcement.Name = "Announcement";
            Announcement.Size = new Size(524, 69);
            Announcement.TabIndex = 22;
            Announcement.Tag = "";
            Announcement.Text = "Player 1's Move!";
            // 
            // P1Score
            // 
            P1Score.AutoSize = true;
            P1Score.BackColor = Color.DodgerBlue;
            P1Score.Font = new Font("Georgia", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            P1Score.Location = new Point(411, 145);
            P1Score.Name = "P1Score";
            P1Score.Size = new Size(372, 43);
            P1Score.TabIndex = 23;
            P1Score.Text = "Player 1's Score - 0";
            // 
            // P2Score
            // 
            P2Score.AutoSize = true;
            P2Score.BackColor = Color.DodgerBlue;
            P2Score.Font = new Font("Georgia", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            P2Score.Location = new Point(408, 199);
            P2Score.Name = "P2Score";
            P2Score.Size = new Size(377, 43);
            P2Score.TabIndex = 24;
            P2Score.Text = "Player 2's Score - 0";
            // 
            // gameVsHuman
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(P2Score);
            Controls.Add(P1Score);
            Controls.Add(Announcement);
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
            Name = "gameVsHuman";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "gameVsHuman";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button11;
        private Button button10;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label Announcement;
        private Label P1Score;
        private Label P2Score;
    }
}