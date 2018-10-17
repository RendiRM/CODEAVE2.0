namespace Login.UserControls
{
    partial class UC_AddEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_SName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ContactNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(27, 65);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(145, 20);
            this.txt_Name.TabIndex = 2;
            this.txt_Name.TextChanged += new System.EventHandler(this.txt_Name_TextChanged);
            // 
            // txt_SName
            // 
            this.txt_SName.Location = new System.Drawing.Point(27, 123);
            this.txt_SName.Name = "txt_SName";
            this.txt_SName.Size = new System.Drawing.Size(145, 20);
            this.txt_SName.TabIndex = 4;
            this.txt_SName.TextChanged += new System.EventHandler(this.txt_SName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Surname";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Position";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(367, 65);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(145, 20);
            this.txt_Email.TabIndex = 11;
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_ContactNumber
            // 
            this.txt_ContactNumber.Location = new System.Drawing.Point(27, 241);
            this.txt_ContactNumber.Name = "txt_ContactNumber";
            this.txt_ContactNumber.Size = new System.Drawing.Size(145, 20);
            this.txt_ContactNumber.TabIndex = 9;
            this.txt_ContactNumber.TextChanged += new System.EventHandler(this.txt_ContactNumber_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Contact Number";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(367, 123);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(145, 20);
            this.txt_Password.TabIndex = 13;
            this.txt_Password.TextChanged += new System.EventHandler(this.txt_Password_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(364, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Password";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_ConfirmPassword
            // 
            this.txt_ConfirmPassword.Location = new System.Drawing.Point(367, 178);
            this.txt_ConfirmPassword.Name = "txt_ConfirmPassword";
            this.txt_ConfirmPassword.PasswordChar = '*';
            this.txt_ConfirmPassword.Size = new System.Drawing.Size(145, 20);
            this.txt_ConfirmPassword.TabIndex = 15;
            this.txt_ConfirmPassword.TextChanged += new System.EventHandler(this.txt_ConfirmPassword_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(364, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Confirm Password";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Location = new System.Drawing.Point(26, 178);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(146, 21);
            this.comboBoxPosition.TabIndex = 16;
            this.comboBoxPosition.SelectedIndexChanged += new System.EventHandler(this.comboBoxPosition_SelectedIndexChanged);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_Confirm.Location = new System.Drawing.Point(436, 280);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirm.TabIndex = 17;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = false;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // UC_AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.comboBoxPosition);
            this.Controls.Add(this.txt_ConfirmPassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_ContactNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_SName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_AddEmployee";
            this.Size = new System.Drawing.Size(680, 360);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_SName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ContactNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ConfirmPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.Button btn_Confirm;
    }
}
