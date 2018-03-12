namespace WindowsFormsApp3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.login_label = new System.Windows.Forms.Label();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.password_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_label.Location = new System.Drawing.Point(128, 9);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(135, 55);
            this.login_label.TabIndex = 1;
            this.login_label.Text = "Вход";
            // 
            // password_textbox
            // 
            this.password_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.password_textbox.Location = new System.Drawing.Point(188, 196);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '•';
            this.password_textbox.Size = new System.Drawing.Size(172, 26);
            this.password_textbox.TabIndex = 14;
            // 
            // username_textbox
            // 
            this.username_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.username_textbox.Location = new System.Drawing.Point(188, 148);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(172, 26);
            this.username_textbox.TabIndex = 13;
            // 
            // login_button
            // 
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.login_button.Location = new System.Drawing.Point(111, 261);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(190, 45);
            this.login_button.TabIndex = 12;
            this.login_button.Text = "Влез";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.password_label.Location = new System.Drawing.Point(107, 196);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(75, 20);
            this.password_label.TabIndex = 11;
            this.password_label.Text = "Парола: ";
            this.password_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.username_label.Location = new System.Drawing.Point(13, 146);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(169, 20);
            this.username_label.TabIndex = 10;
            this.username_label.Text = "Потребителско име: ";
            this.username_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 402);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.login_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label username_label;
    }
}