// Form1.Designer.cs
namespace GameStoreProject
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.CheckBox checkBoxCaptcha;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonGoToLogin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.checkBoxCaptcha = new System.Windows.Forms.CheckBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonGoToLogin = new System.Windows.Forms.Button();
            this.userrole = new System.Windows.Forms.Label();
            this.userroleselectioncombobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(180, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(154, 40);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Register";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(30, 70);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(63, 24);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.labelEmail.ForeColor = System.Drawing.Color.White;
            this.labelEmail.Location = new System.Drawing.Point(30, 130);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(61, 24);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.labelPassword.ForeColor = System.Drawing.Color.White;
            this.labelPassword.Location = new System.Drawing.Point(30, 190);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(103, 24);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.labelConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.labelConfirmPassword.Location = new System.Drawing.Point(30, 250);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(184, 24);
            this.labelConfirmPassword.TabIndex = 4;
            this.labelConfirmPassword.Text = "Confirm Password";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Arial", 10F);
            this.textBoxName.Location = new System.Drawing.Point(200, 70);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(250, 27);
            this.textBoxName.TabIndex = 5;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Arial", 10F);
            this.textBoxEmail.Location = new System.Drawing.Point(200, 130);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(250, 27);
            this.textBoxEmail.TabIndex = 6;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Arial", 10F);
            this.textBoxPassword.Location = new System.Drawing.Point(200, 190);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(250, 27);
            this.textBoxPassword.TabIndex = 7;
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Font = new System.Drawing.Font("Arial", 10F);
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(200, 250);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.PasswordChar = '*';
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(250, 27);
            this.textBoxConfirmPassword.TabIndex = 8;
            // 
            // checkBoxCaptcha
            // 
            this.checkBoxCaptcha.AutoSize = true;
            this.checkBoxCaptcha.Font = new System.Drawing.Font("Arial", 10F);
            this.checkBoxCaptcha.ForeColor = System.Drawing.Color.White;
            this.checkBoxCaptcha.Location = new System.Drawing.Point(200, 329);
            this.checkBoxCaptcha.Name = "checkBoxCaptcha";
            this.checkBoxCaptcha.Size = new System.Drawing.Size(146, 23);
            this.checkBoxCaptcha.TabIndex = 9;
            this.checkBoxCaptcha.Text = "I am not a robot";
            this.checkBoxCaptcha.UseVisualStyleBackColor = true;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(50)))));
            this.buttonSubmit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.buttonSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonSubmit.Location = new System.Drawing.Point(200, 358);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(150, 35);
            this.buttonSubmit.TabIndex = 10;
            this.buttonSubmit.Text = "Create Account";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonGoToLogin
            // 
            this.buttonGoToLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonGoToLogin.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.buttonGoToLogin.ForeColor = System.Drawing.Color.White;
            this.buttonGoToLogin.Location = new System.Drawing.Point(403, 358);
            this.buttonGoToLogin.Name = "buttonGoToLogin";
            this.buttonGoToLogin.Size = new System.Drawing.Size(80, 35);
            this.buttonGoToLogin.TabIndex = 11;
            this.buttonGoToLogin.Text = "Login";
            this.buttonGoToLogin.UseVisualStyleBackColor = false;
            this.buttonGoToLogin.Click += new System.EventHandler(this.buttonGoToLogin_Click);
            // 
            // userrole
            // 
            this.userrole.AutoSize = true;
            this.userrole.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userrole.Location = new System.Drawing.Point(30, 295);
            this.userrole.Name = "userrole";
            this.userrole.Size = new System.Drawing.Size(52, 24);
            this.userrole.TabIndex = 12;
            this.userrole.Text = "Role";
            // 
            // userroleselectioncombobox
            // 
            this.userroleselectioncombobox.FormattingEnabled = true;
            this.userroleselectioncombobox.Location = new System.Drawing.Point(200, 295);
            this.userroleselectioncombobox.Name = "userroleselectioncombobox";
            this.userroleselectioncombobox.Size = new System.Drawing.Size(250, 24);
            this.userroleselectioncombobox.TabIndex = 13;
            this.userroleselectioncombobox.SelectedIndexChanged += new System.EventHandler(this.userroleselectioncombobox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(554, 420);
            this.Controls.Add(this.userroleselectioncombobox);
            this.Controls.Add(this.userrole);
            this.Controls.Add(this.buttonGoToLogin);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.checkBoxCaptcha);
            this.Controls.Add(this.textBoxConfirmPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelConfirmPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelTitle);
            this.ForeColor = System.Drawing.Color.Snow;
            this.MinimumSize = new System.Drawing.Size(520, 420);
            this.Name = "Form1";
            this.Text = "Register - Game Store";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label userrole;
        private System.Windows.Forms.ComboBox userroleselectioncombobox;
    }
}