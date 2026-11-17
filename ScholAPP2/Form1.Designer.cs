namespace ScholAPP2
{
    partial class FormLogin
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnSumbitLogin = new Button();
            btnNavToRegister = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(271, 88);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(207, 33);
            txtUsername.TabIndex = 0;
            txtUsername.Text = "Username...";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(271, 127);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(207, 33);
            txtPassword.TabIndex = 1;
            txtPassword.Text = "Pasword...";
            // 
            // btnSumbitLogin
            // 
            btnSumbitLogin.Font = new Font("Snap ITC", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSumbitLogin.Location = new Point(271, 175);
            btnSumbitLogin.Name = "btnSumbitLogin";
            btnSumbitLogin.Size = new Size(207, 30);
            btnSumbitLogin.TabIndex = 2;
            btnSumbitLogin.Text = "Login";
            btnSumbitLogin.UseVisualStyleBackColor = true;
            btnSumbitLogin.Click += btnSumbitLogin_Click;
            // 
            // btnNavToRegister
            // 
            btnNavToRegister.Font = new Font("Snap ITC", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNavToRegister.Location = new Point(271, 220);
            btnNavToRegister.Name = "btnNavToRegister";
            btnNavToRegister.Size = new Size(207, 30);
            btnNavToRegister.TabIndex = 3;
            btnNavToRegister.Text = "To Regristasi";
            btnNavToRegister.UseVisualStyleBackColor = true;
            btnNavToRegister.Click += btnNavToRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(271, 30);
            label1.Name = "label1";
            label1.Size = new Size(188, 37);
            label1.TabIndex = 4;
            label1.Text = "From login";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnNavToRegister);
            Controls.Add(btnSumbitLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "FormLogin";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnSumbitLogin;
        private Button btnNavToRegister;
        private Label label1;
    }
}
