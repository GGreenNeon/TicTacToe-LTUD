namespace LTUD
{
    partial class FormRegister
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
            label1 = new Label();
            label2 = new Label();
            usernameTxt = new TextBox();
            PassTxt = new TextBox();
            label3 = new Label();
            CfPassTxt = new TextBox();
            label4 = new Label();
            ShowPass = new CheckBox();
            RegisterButton = new Button();
            label5 = new Label();
            LoginButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumSlateBlue;
            label1.Location = new Point(61, 49);
            label1.Name = "label1";
            label1.Size = new Size(194, 34);
            label1.TabIndex = 0;
            label1.Text = "Get Started";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(36, 118);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // usernameTxt
            // 
            usernameTxt.BackColor = Color.Gainsboro;
            usernameTxt.Location = new Point(36, 144);
            usernameTxt.Multiline = true;
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(242, 34);
            usernameTxt.TabIndex = 2;
            // 
            // PassTxt
            // 
            PassTxt.BackColor = Color.Gainsboro;
            PassTxt.Location = new Point(36, 223);
            PassTxt.Multiline = true;
            PassTxt.Name = "PassTxt";
            PassTxt.PasswordChar = '•';
            PassTxt.Size = new Size(242, 34);
            PassTxt.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(36, 197);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // CfPassTxt
            // 
            CfPassTxt.BackColor = Color.Gainsboro;
            CfPassTxt.Location = new Point(36, 304);
            CfPassTxt.Multiline = true;
            CfPassTxt.Name = "CfPassTxt";
            CfPassTxt.PasswordChar = '•';
            CfPassTxt.Size = new Size(242, 34);
            CfPassTxt.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(36, 278);
            label4.Name = "label4";
            label4.Size = new Size(155, 23);
            label4.TabIndex = 5;
            label4.Text = "Confirm Password";
            // 
            // ShowPass
            // 
            ShowPass.AutoSize = true;
            ShowPass.ForeColor = Color.Gray;
            ShowPass.Location = new Point(123, 344);
            ShowPass.Name = "ShowPass";
            ShowPass.Size = new Size(155, 27);
            ShowPass.TabIndex = 7;
            ShowPass.Text = "Show Password";
            ShowPass.UseVisualStyleBackColor = true;
            ShowPass.CheckedChanged += ShowPass_CheckedChanged;
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.MediumSlateBlue;
            RegisterButton.ForeColor = Color.White;
            RegisterButton.Location = new Point(36, 404);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(242, 35);
            RegisterButton.TabIndex = 8;
            RegisterButton.Text = "REGISTER";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(55, 452);
            label5.Name = "label5";
            label5.Size = new Size(212, 23);
            label5.TabIndex = 9;
            label5.Text = "Already have an account?";
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.MediumSlateBlue;
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(107, 481);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(98, 36);
            LoginButton.TabIndex = 11;
            LoginButton.Text = "LOGIN";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(320, 544);
            Controls.Add(LoginButton);
            Controls.Add(label5);
            Controls.Add(RegisterButton);
            Controls.Add(ShowPass);
            Controls.Add(CfPassTxt);
            Controls.Add(label4);
            Controls.Add(PassTxt);
            Controls.Add(label3);
            Controls.Add(usernameTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.Silver;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox usernameTxt;
        private TextBox PassTxt;
        private Label label3;
        private TextBox CfPassTxt;
        private Label label4;
        private CheckBox ShowPass;
        private Button RegisterButton;
        private Label label5;
        private Button LoginButton;
    }
}
