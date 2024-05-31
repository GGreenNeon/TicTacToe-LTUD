namespace LTUD
{
    partial class DiffChoose
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
            EasyDiff = new Button();
            MidDiff = new Button();
            HardDiff = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(77, 50);
            label1.Name = "label1";
            label1.Size = new Size(644, 69);
            label1.TabIndex = 1;
            label1.Text = "Choose A Difficulty:";
            // 
            // EasyDiff
            // 
            EasyDiff.BackColor = Color.MediumSlateBlue;
            EasyDiff.Font = new Font("Nirmala UI", 18F, FontStyle.Bold);
            EasyDiff.ForeColor = Color.White;
            EasyDiff.Location = new Point(264, 164);
            EasyDiff.Name = "EasyDiff";
            EasyDiff.Size = new Size(269, 60);
            EasyDiff.TabIndex = 2;
            EasyDiff.Text = "Easy";
            EasyDiff.UseVisualStyleBackColor = false;
            EasyDiff.Click += EasyDiff_Click;
            // 
            // MidDiff
            // 
            MidDiff.BackColor = Color.MediumSlateBlue;
            MidDiff.Font = new Font("Nirmala UI", 18F, FontStyle.Bold);
            MidDiff.ForeColor = Color.White;
            MidDiff.Location = new Point(264, 243);
            MidDiff.Name = "MidDiff";
            MidDiff.Size = new Size(269, 60);
            MidDiff.TabIndex = 3;
            MidDiff.Text = "Medium";
            MidDiff.UseVisualStyleBackColor = false;
            MidDiff.Click += MidDiff_Click;
            // 
            // HardDiff
            // 
            HardDiff.BackColor = Color.MediumSlateBlue;
            HardDiff.Font = new Font("Nirmala UI", 18F, FontStyle.Bold);
            HardDiff.ForeColor = Color.White;
            HardDiff.Location = new Point(264, 322);
            HardDiff.Name = "HardDiff";
            HardDiff.Size = new Size(269, 60);
            HardDiff.TabIndex = 3;
            HardDiff.Text = "Hard";
            HardDiff.UseVisualStyleBackColor = false;
            HardDiff.Click += HardDiff_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(0, 410);
            button1.Name = "button1";
            button1.Size = new Size(112, 39);
            button1.TabIndex = 4;
            button1.Text = "Sign Out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            button2.Location = new Point(0, 366);
            button2.Name = "button2";
            button2.Size = new Size(112, 38);
            button2.TabIndex = 5;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // DiffChoose
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(HardDiff);
            Controls.Add(MidDiff);
            Controls.Add(EasyDiff);
            Controls.Add(label1);
            Name = "DiffChoose";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DiffChoose";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button EasyDiff;
        private Button MidDiff;
        private Button HardDiff;
        private Button button1;
        private Button button2;
    }
}