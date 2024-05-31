namespace LTUD
{
    partial class Home
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
            label1 = new Label();
            Comp = new Button();
            twoPlayer = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(164, 75);
            label1.Name = "label1";
            label1.Size = new Size(449, 69);
            label1.TabIndex = 0;
            label1.Text = "TIC-TAC-TOE";
            // 
            // Comp
            // 
            Comp.BackColor = Color.MediumSlateBlue;
            Comp.Font = new Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Comp.ForeColor = Color.White;
            Comp.Location = new Point(226, 196);
            Comp.Name = "Comp";
            Comp.Size = new Size(274, 61);
            Comp.TabIndex = 1;
            Comp.Text = "Vs. Computer";
            Comp.UseVisualStyleBackColor = false;
            Comp.Click += Comp_Click;
            // 
            // twoPlayer
            // 
            twoPlayer.BackColor = Color.MediumSlateBlue;
            twoPlayer.Font = new Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            twoPlayer.ForeColor = Color.White;
            twoPlayer.Location = new Point(226, 294);
            twoPlayer.Name = "twoPlayer";
            twoPlayer.Size = new Size(274, 61);
            twoPlayer.TabIndex = 2;
            twoPlayer.Text = "Vs. Human";
            twoPlayer.UseVisualStyleBackColor = false;
            twoPlayer.Click += twoPlayer_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1, 409);
            button1.Name = "button1";
            button1.Size = new Size(112, 39);
            button1.TabIndex = 3;
            button1.Text = "Sign Out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(725, 450);
            Controls.Add(button1);
            Controls.Add(twoPlayer);
            Controls.Add(Comp);
            Controls.Add(label1);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tic-Tac-Toe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Comp;
        private Button twoPlayer;
        private Button button1;
    }
}