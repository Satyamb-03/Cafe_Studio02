namespace Cafe_Studio02
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
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.contact = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Label();
            this.name1txt = new System.Windows.Forms.TextBox();
            this.confirmtxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.contacttxt = new System.Windows.Forms.TextBox();
            this.mailtxt = new System.Windows.Forms.TextBox();
            this.agetxt = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(98, 61);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(73, 22);
            this.name.TabIndex = 1;
            this.name.Text = "Name";
            this.name.Click += new System.EventHandler(this.label2_Click);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(57, 237);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(101, 29);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            this.password.Click += new System.EventHandler(this.label3_Click);
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(57, 208);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(114, 29);
            this.username.TabIndex = 3;
            this.username.Text = "Username";
            this.username.Click += new System.EventHandler(this.label4_Click);
            // 
            // address
            // 
            this.address.BackColor = System.Drawing.Color.Transparent;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(76, 179);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(95, 29);
            this.address.TabIndex = 4;
            this.address.Text = "Address";
            this.address.Click += new System.EventHandler(this.label5_Click);
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(98, 121);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(73, 29);
            this.email.TabIndex = 5;
            this.email.Text = "Email";
            this.email.Click += new System.EventHandler(this.label6_Click);
            // 
            // contact
            // 
            this.contact.BackColor = System.Drawing.Color.Transparent;
            this.contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.Location = new System.Drawing.Point(53, 150);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(118, 29);
            this.contact.TabIndex = 6;
            this.contact.Text = "Contact no.";
            this.contact.Click += new System.EventHandler(this.label7_Click);
            // 
            // age
            // 
            this.age.BackColor = System.Drawing.Color.Transparent;
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.Location = new System.Drawing.Point(98, 92);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(73, 29);
            this.age.TabIndex = 7;
            this.age.Text = "Age";
            this.age.Click += new System.EventHandler(this.label8_Click);
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.Transparent;
            this.confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.Location = new System.Drawing.Point(-4, 266);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(197, 29);
            this.confirm.TabIndex = 8;
            this.confirm.Text = "Confirm Password";
            this.confirm.Click += new System.EventHandler(this.label9_Click);
            // 
            // name1txt
            // 
            this.name1txt.Location = new System.Drawing.Point(177, 61);
            this.name1txt.Name = "name1txt";
            this.name1txt.Size = new System.Drawing.Size(100, 20);
            this.name1txt.TabIndex = 9;
            this.name1txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // confirmtxt
            // 
            this.confirmtxt.Location = new System.Drawing.Point(177, 275);
            this.confirmtxt.Name = "confirmtxt";
            this.confirmtxt.Size = new System.Drawing.Size(100, 20);
            this.confirmtxt.TabIndex = 10;
            this.confirmtxt.TextChanged += new System.EventHandler(this.confirmtxt_TextChanged);
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(177, 246);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(100, 20);
            this.passwordtxt.TabIndex = 11;
            this.passwordtxt.TextChanged += new System.EventHandler(this.passwordtxt_TextChanged);
            // 
            // usernametxt
            // 
            this.usernametxt.Location = new System.Drawing.Point(177, 215);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(100, 20);
            this.usernametxt.TabIndex = 12;
            this.usernametxt.TextChanged += new System.EventHandler(this.usernametxt_TextChanged);
            // 
            // addresstxt
            // 
            this.addresstxt.Location = new System.Drawing.Point(177, 179);
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(100, 20);
            this.addresstxt.TabIndex = 13;
            this.addresstxt.TextChanged += new System.EventHandler(this.addresstxt_TextChanged);
            // 
            // contacttxt
            // 
            this.contacttxt.Location = new System.Drawing.Point(177, 150);
            this.contacttxt.Name = "contacttxt";
            this.contacttxt.Size = new System.Drawing.Size(100, 20);
            this.contacttxt.TabIndex = 14;
            this.contacttxt.TextChanged += new System.EventHandler(this.contacttxt_TextChanged);
            // 
            // mailtxt
            // 
            this.mailtxt.Location = new System.Drawing.Point(177, 118);
            this.mailtxt.Name = "mailtxt";
            this.mailtxt.Size = new System.Drawing.Size(100, 20);
            this.mailtxt.TabIndex = 15;
            this.mailtxt.TextChanged += new System.EventHandler(this.mailtxt_TextChanged);
            // 
            // agetxt
            // 
            this.agetxt.Location = new System.Drawing.Point(177, 92);
            this.agetxt.Name = "agetxt";
            this.agetxt.Size = new System.Drawing.Size(100, 20);
            this.agetxt.TabIndex = 16;
            this.agetxt.TextChanged += new System.EventHandler(this.agetxt_TextChanged);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.Black;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.Color.White;
            this.registerButton.Location = new System.Drawing.Point(164, 327);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 17;
            this.registerButton.Text = "Confirm";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cafe_Studio02.Properties.Resources.c_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(517, 450);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.agetxt);
            this.Controls.Add(this.mailtxt);
            this.Controls.Add(this.contacttxt);
            this.Controls.Add(this.addresstxt);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.confirmtxt);
            this.Controls.Add(this.name1txt);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.age);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.email);
            this.Controls.Add(this.address);
            this.Controls.Add(this.username);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label contact;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label confirm;
        private System.Windows.Forms.TextBox name1txt;
        private System.Windows.Forms.TextBox confirmtxt;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.TextBox contacttxt;
        private System.Windows.Forms.TextBox mailtxt;
        private System.Windows.Forms.TextBox agetxt;
        private System.Windows.Forms.Button registerButton;
    }
}