namespace WindowsFormsApp3
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.register_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.register_button = new System.Windows.Forms.Button();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // register_label
            // 
            this.register_label.AutoSize = true;
            this.register_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.register_label.Location = new System.Drawing.Point(50, 9);
            this.register_label.Name = "register_label";
            this.register_label.Size = new System.Drawing.Size(309, 55);
            this.register_label.TabIndex = 0;
            this.register_label.Text = "Регистрация";
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.username_label.Location = new System.Drawing.Point(12, 230);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(169, 20);
            this.username_label.TabIndex = 1;
            this.username_label.Text = "Потребителско име: ";
            this.username_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.password_label.Location = new System.Drawing.Point(106, 280);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(75, 20);
            this.password_label.TabIndex = 2;
            this.password_label.Text = "Парола: ";
            this.password_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.email_label.Location = new System.Drawing.Point(120, 180);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(61, 20);
            this.email_label.TabIndex = 3;
            this.email_label.Text = "E-mail: ";
            this.email_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.name_label.Location = new System.Drawing.Point(133, 130);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(48, 20);
            this.name_label.TabIndex = 4;
            this.name_label.Text = "Име: ";
            this.name_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // register_button
            // 
            this.register_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.register_button.Location = new System.Drawing.Point(110, 345);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(190, 45);
            this.register_button.TabIndex = 5;
            this.register_button.Text = "Регистрирай се";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // name_textbox
            // 
            this.name_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.name_textbox.Location = new System.Drawing.Point(187, 130);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(172, 26);
            this.name_textbox.TabIndex = 6;
            // 
            // email_textbox
            // 
            this.email_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.email_textbox.Location = new System.Drawing.Point(187, 180);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(172, 26);
            this.email_textbox.TabIndex = 7;
            // 
            // username_textbox
            // 
            this.username_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.username_textbox.Location = new System.Drawing.Point(187, 232);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(172, 26);
            this.username_textbox.TabIndex = 8;
            // 
            // password_textbox
            // 
            this.password_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.password_textbox.Location = new System.Drawing.Point(187, 280);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '•';
            this.password_textbox.Size = new System.Drawing.Size(172, 26);
            this.password_textbox.TabIndex = 9;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 402);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.register_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.Text = "Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label register_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.TextBox password_textbox;
    }
}