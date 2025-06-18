// Form2.Designer.cs
namespace GameStoreProject
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonGoToRegister;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonGoToRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(200, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(126, 46);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Login";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.labelEmail.ForeColor = System.Drawing.Color.White;
            this.labelEmail.Location = new System.Drawing.Point(40, 100);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(77, 29);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Email";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.labelPassword.ForeColor = System.Drawing.Color.White;
            this.labelPassword.Location = new System.Drawing.Point(40, 160);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(126, 29);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Arial", 10F);
            this.textBoxEmail.Location = new System.Drawing.Point(160, 100);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(250, 30);
            this.textBoxEmail.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Arial", 10F);
            this.textBoxPassword.Location = new System.Drawing.Point(160, 160);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(250, 30);
            this.textBoxPassword.TabIndex = 4;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonLogin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(160, 210);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(150, 35);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonGoToRegister
            // 
            this.buttonGoToRegister.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonGoToRegister.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.buttonGoToRegister.ForeColor = System.Drawing.Color.White;
            this.buttonGoToRegister.Location = new System.Drawing.Point(320, 210);
            this.buttonGoToRegister.Name = "buttonGoToRegister";
            this.buttonGoToRegister.Size = new System.Drawing.Size(90, 35);
            this.buttonGoToRegister.TabIndex = 6;
            this.buttonGoToRegister.Text = "Register";
            this.buttonGoToRegister.UseVisualStyleBackColor = false;
            this.buttonGoToRegister.Click += new System.EventHandler(this.buttonGoToRegister_Click);
            // 
            // Form2
            // 
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(520, 360);
            this.Controls.Add(this.buttonGoToRegister);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelTitle);
            this.MinimumSize = new System.Drawing.Size(520, 360);
            this.Name = "Form2";
            this.Text = "Login - Game Store";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}