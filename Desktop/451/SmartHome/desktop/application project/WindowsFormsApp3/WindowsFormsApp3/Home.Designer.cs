namespace WindowsFormsApp3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.heading_label = new System.Windows.Forms.Label();
            this.register_button = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // heading_label
            // 
            this.heading_label.AutoSize = true;
            this.heading_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.heading_label.ForeColor = System.Drawing.Color.DarkBlue;
            this.heading_label.Location = new System.Drawing.Point(12, 9);
            this.heading_label.Name = "heading_label";
            this.heading_label.Size = new System.Drawing.Size(390, 76);
            this.heading_label.TabIndex = 0;
            this.heading_label.Text = "SmartHome";
            // 
            // register_button
            // 
            this.register_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.register_button.Location = new System.Drawing.Point(121, 184);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(153, 58);
            this.register_button.TabIndex = 1;
            this.register_button.Text = "Регистрация";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // login_button
            // 
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.login_button.Location = new System.Drawing.Point(121, 276);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(153, 58);
            this.login_button.TabIndex = 2;
            this.login_button.Text = "Вход";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(404, 402);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.heading_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "SmartHome Setup";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label heading_label;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Button login_button;
    }
}

