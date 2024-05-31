namespace LTUD
{
    partial class Login
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
            label5 = new Label();
            LoginButton = new Button();
            checkBox1 = new CheckBox();
            PasswordTxt = new TextBox();
            label3 = new Label();
            usernameTxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            RegisterButton = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(39, 439);
            label5.Name = "label5";
            label5.Size = new Size(240, 23);
            label5.TabIndex = 20;
            label5.Text = "Doesn't have an account yet?";
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.MediumSlateBlue;
            LoginButton.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(39, 377);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(242, 35);
            LoginButton.TabIndex = 19;
            LoginButton.Text = "LOGIN";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            checkBox1.ForeColor = Color.Gray;
            checkBox1.Location = new Point(131, 318);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(155, 27);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // PasswordTxt
            // 
            PasswordTxt.BackColor = Color.Gainsboro;
            PasswordTxt.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            PasswordTxt.Location = new Point(39, 268);
            PasswordTxt.Multiline = true;
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.PasswordChar = '•';
            PasswordTxt.Size = new Size(242, 34);
            PasswordTxt.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(39, 242);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 14;
            label3.Text = "Password";
            // 
            // usernameTxt
            // 
            usernameTxt.BackColor = Color.Gainsboro;
            usernameTxt.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            usernameTxt.Location = new Point(39, 189);
            usernameTxt.Multiline = true;
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(242, 34);
            usernameTxt.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(39, 163);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 12;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumSlateBlue;
            label1.Location = new Point(108, 83);
            label1.Name = "label1";
            label1.Size = new Size(116, 34);
            label1.TabIndex = 11;
            label1.Text = "Sign in";
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.MediumSlateBlue;
            RegisterButton.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            RegisterButton.ForeColor = Color.White;
            RegisterButton.Location = new Point(58, 465);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(199, 42);
            RegisterButton.TabIndex = 22;
            RegisterButton.Text = "Create a New Account";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(320, 544);
            Controls.Add(RegisterButton);
            Controls.Add(label5);
            Controls.Add(LoginButton);
            Controls.Add(checkBox1);
            Controls.Add(PasswordTxt);
            Controls.Add(label3);
            Controls.Add(usernameTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Silver;
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Button LoginButton;
        private CheckBox checkBox1;
        private TextBox PasswordTxt;
        private Label label3;
        private TextBox usernameTxt;
        private Label label2;
        private Label label1;
        private Button RegisterButton;
    }
}