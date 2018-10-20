namespace TradeCompanyWF
{
    partial class LoginForm
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
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.pswrdTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.SignInButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginTextBox
            // 
            this.loginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginTextBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.loginTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.loginTextBox.Location = new System.Drawing.Point(209, 111);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(295, 32);
            this.loginTextBox.TabIndex = 0;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(47, 107);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(88, 40);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Login";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pswrdTextBox
            // 
            this.pswrdTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.pswrdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pswrdTextBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pswrdTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.pswrdTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pswrdTextBox.Location = new System.Drawing.Point(209, 165);
            this.pswrdTextBox.Name = "pswrdTextBox";
            this.pswrdTextBox.PasswordChar = '*';
            this.pswrdTextBox.Size = new System.Drawing.Size(295, 32);
            this.pswrdTextBox.TabIndex = 3;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.White;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(47, 161);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(137, 40);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignInButton
            // 
            this.SignInButton.BackColor = System.Drawing.Color.White;
            this.SignInButton.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignInButton.Location = new System.Drawing.Point(550, 111);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(199, 86);
            this.SignInButton.TabIndex = 5;
            this.SignInButton.Text = "Sign in";
            this.SignInButton.UseVisualStyleBackColor = false;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(778, 444);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.pswrdTextBox);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.loginTextBox);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "LoginForm";
            this.Text = "Trading company";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox pswrdTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button SignInButton;
    }
}

