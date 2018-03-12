namespace WindowsFormsApp3
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.serialports_combo = new System.Windows.Forms.ComboBox();
            this.register_device_label = new System.Windows.Forms.Label();
            this.serialports_label = new System.Windows.Forms.Label();
            this.device_name_label = new System.Windows.Forms.Label();
            this.device_name_textbox = new System.Windows.Forms.TextBox();
            this.ssid_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.ssid_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.password_checkbox = new System.Windows.Forms.CheckBox();
            this.register_device_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serialports_combo
            // 
            this.serialports_combo.AllowDrop = true;
            this.serialports_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.serialports_combo.FormattingEnabled = true;
            this.serialports_combo.Location = new System.Drawing.Point(193, 87);
            this.serialports_combo.Name = "serialports_combo";
            this.serialports_combo.Size = new System.Drawing.Size(171, 28);
            this.serialports_combo.TabIndex = 0;
            // 
            // register_device_label
            // 
            this.register_device_label.AutoSize = true;
            this.register_device_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.register_device_label.Location = new System.Drawing.Point(44, 9);
            this.register_device_label.Name = "register_device_label";
            this.register_device_label.Size = new System.Drawing.Size(320, 31);
            this.register_device_label.TabIndex = 2;
            this.register_device_label.Text = "Регистрирай устройство";
            // 
            // serialports_label
            // 
            this.serialports_label.AutoSize = true;
            this.serialports_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.serialports_label.Location = new System.Drawing.Point(78, 95);
            this.serialports_label.Name = "serialports_label";
            this.serialports_label.Size = new System.Drawing.Size(109, 20);
            this.serialports_label.TabIndex = 11;
            this.serialports_label.Text = "Сериен порт:";
            this.serialports_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // device_name_label
            // 
            this.device_name_label.AutoSize = true;
            this.device_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.device_name_label.Location = new System.Drawing.Point(27, 129);
            this.device_name_label.Name = "device_name_label";
            this.device_name_label.Size = new System.Drawing.Size(160, 20);
            this.device_name_label.TabIndex = 12;
            this.device_name_label.Text = "Име на устройство: ";
            this.device_name_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // device_name_textbox
            // 
            this.device_name_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.device_name_textbox.Location = new System.Drawing.Point(193, 123);
            this.device_name_textbox.Name = "device_name_textbox";
            this.device_name_textbox.Size = new System.Drawing.Size(172, 26);
            this.device_name_textbox.TabIndex = 14;
            // 
            // ssid_label
            // 
            this.ssid_label.AutoSize = true;
            this.ssid_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ssid_label.Location = new System.Drawing.Point(-3, 161);
            this.ssid_label.Name = "ssid_label";
            this.ssid_label.Size = new System.Drawing.Size(190, 20);
            this.ssid_label.TabIndex = 15;
            this.ssid_label.Text = "SSID (Име на мрежата):";
            this.ssid_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.password_label.Location = new System.Drawing.Point(19, 195);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(168, 20);
            this.password_label.TabIndex = 17;
            this.password_label.Text = "Парола на мрежата: ";
            this.password_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ssid_textbox
            // 
            this.ssid_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ssid_textbox.Location = new System.Drawing.Point(193, 158);
            this.ssid_textbox.Name = "ssid_textbox";
            this.ssid_textbox.Size = new System.Drawing.Size(172, 26);
            this.ssid_textbox.TabIndex = 18;
            // 
            // password_textbox
            // 
            this.password_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.password_textbox.Location = new System.Drawing.Point(193, 195);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '•';
            this.password_textbox.Size = new System.Drawing.Size(172, 26);
            this.password_textbox.TabIndex = 19;
            // 
            // password_checkbox
            // 
            this.password_checkbox.AutoSize = true;
            this.password_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.password_checkbox.Location = new System.Drawing.Point(193, 227);
            this.password_checkbox.Name = "password_checkbox";
            this.password_checkbox.Size = new System.Drawing.Size(180, 24);
            this.password_checkbox.TabIndex = 20;
            this.password_checkbox.Text = "Не скривай знаците";
            this.password_checkbox.UseVisualStyleBackColor = true;
            this.password_checkbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // register_device_button
            // 
            this.register_device_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.register_device_button.Location = new System.Drawing.Point(110, 269);
            this.register_device_button.Name = "register_device_button";
            this.register_device_button.Size = new System.Drawing.Size(190, 45);
            this.register_device_button.TabIndex = 21;
            this.register_device_button.Text = "Регистрирай";
            this.register_device_button.UseVisualStyleBackColor = true;
            this.register_device_button.Click += new System.EventHandler(this.register_device_button_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 339);
            this.Controls.Add(this.register_device_button);
            this.Controls.Add(this.password_checkbox);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.ssid_textbox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.ssid_label);
            this.Controls.Add(this.device_name_textbox);
            this.Controls.Add(this.device_name_label);
            this.Controls.Add(this.serialports_label);
            this.Controls.Add(this.register_device_label);
            this.Controls.Add(this.serialports_combo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Hello";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox serialports_combo;
        private System.Windows.Forms.Label register_device_label;
        private System.Windows.Forms.Label serialports_label;
        private System.Windows.Forms.Label device_name_label;
        private System.Windows.Forms.TextBox device_name_textbox;
        private System.Windows.Forms.Label ssid_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox ssid_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.CheckBox password_checkbox;
        private System.Windows.Forms.Button register_device_button;
    }
}