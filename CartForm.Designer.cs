using System.Windows.Forms;

namespace Cafe_Studio02
{
    partial class CartForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonCheckout = new System.Windows.Forms.Button();
            this.buttonUpdateQuantity = new System.Windows.Forms.Button();
            this.panelCustomization = new System.Windows.Forms.Panel();
            this.checkBoxSoyMilk = new System.Windows.Forms.CheckBox();
            this.buttonSaveCustomization = new System.Windows.Forms.Button();
            this.checkBoxNoSugar = new System.Windows.Forms.CheckBox();
            this.checkOatBoxMilk = new System.Windows.Forms.CheckBox();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelCustomization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(5, 79);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(433, 215);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Columns.Add("Item", 150, HorizontalAlignment.Left);
            this.listView1.Columns.Add("Price", 80, HorizontalAlignment.Right);
            this.listView1.Columns.Add("Quantity", 60, HorizontalAlignment.Right);
            this.listView1.Columns.Add("Total", 80, HorizontalAlignment.Right);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(39, 308);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 22);
            this.textBoxQuantity.TabIndex = 1;
            this.textBoxQuantity.TextChanged += new System.EventHandler(this.textBoxQuantity_TextChanged);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(394, 416);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(44, 16);
            this.labelTotal.TabIndex = 3;
            this.labelTotal.Text = "label1";
            this.labelTotal.Click += new System.EventHandler(this.labelTotal_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(265, 416);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Total Price:";
            // 
            // buttonCheckout
            // 
            this.buttonCheckout.Location = new System.Drawing.Point(513, 416);
            this.buttonCheckout.Name = "buttonCheckout";
            this.buttonCheckout.Size = new System.Drawing.Size(87, 23);
            this.buttonCheckout.TabIndex = 5;
            this.buttonCheckout.Text = "Checkout";
            this.buttonCheckout.UseVisualStyleBackColor = true;
            this.buttonCheckout.Click += new System.EventHandler(this.buttonCheckout_Click_1);
            // 
            // buttonUpdateQuantity
            // 
            this.buttonUpdateQuantity.Location = new System.Drawing.Point(12, 347);
            this.buttonUpdateQuantity.Name = "buttonUpdateQuantity";
            this.buttonUpdateQuantity.Size = new System.Drawing.Size(149, 34);
            this.buttonUpdateQuantity.TabIndex = 6;
            this.buttonUpdateQuantity.Text = "Update Quantity";
            this.buttonUpdateQuantity.UseVisualStyleBackColor = true;
            this.buttonUpdateQuantity.Click += new System.EventHandler(this.buttonUpdateQuantity_Click_1);
            // 
            // panelCustomization
            // 
            this.panelCustomization.Controls.Add(this.checkBoxSoyMilk);
            this.panelCustomization.Controls.Add(this.buttonSaveCustomization);
            this.panelCustomization.Controls.Add(this.checkBoxNoSugar);
            this.panelCustomization.Controls.Add(this.checkOatBoxMilk);
            this.panelCustomization.Controls.Add(this.comboBoxSize);
            this.panelCustomization.Location = new System.Drawing.Point(490, 38);
            this.panelCustomization.Name = "panelCustomization";
            this.panelCustomization.Size = new System.Drawing.Size(280, 325);
            this.panelCustomization.TabIndex = 7;
            // 
            // checkBoxSoyMilk
            // 
            this.checkBoxSoyMilk.AutoSize = true;
            this.checkBoxSoyMilk.Location = new System.Drawing.Point(107, 117);
            this.checkBoxSoyMilk.Name = "checkBoxSoyMilk";
            this.checkBoxSoyMilk.Size = new System.Drawing.Size(80, 20);
            this.checkBoxSoyMilk.TabIndex = 5;
            this.checkBoxSoyMilk.Text = "Soy Milk";
            this.checkBoxSoyMilk.UseVisualStyleBackColor = true;
            // 
            // buttonSaveCustomization
            // 
            this.buttonSaveCustomization.Location = new System.Drawing.Point(31, 269);
            this.buttonSaveCustomization.Name = "buttonSaveCustomization";
            this.buttonSaveCustomization.Size = new System.Drawing.Size(196, 23);
            this.buttonSaveCustomization.TabIndex = 4;
            this.buttonSaveCustomization.Text = "Save Customization";
            this.buttonSaveCustomization.UseVisualStyleBackColor = true;
            this.buttonSaveCustomization.Click += new System.EventHandler(this.buttonSaveCustomization_Click);
            // 
            // checkBoxNoSugar
            // 
            this.checkBoxNoSugar.AutoSize = true;
            this.checkBoxNoSugar.Location = new System.Drawing.Point(107, 143);
            this.checkBoxNoSugar.Name = "checkBoxNoSugar";
            this.checkBoxNoSugar.Size = new System.Drawing.Size(86, 20);
            this.checkBoxNoSugar.TabIndex = 3;
            this.checkBoxNoSugar.Text = "No Sugar";
            this.checkBoxNoSugar.UseVisualStyleBackColor = true;
            // 
            // checkOatBoxMilk
            // 
            this.checkOatBoxMilk.AutoSize = true;
            this.checkOatBoxMilk.Location = new System.Drawing.Point(107, 91);
            this.checkOatBoxMilk.Name = "checkOatBoxMilk";
            this.checkOatBoxMilk.Size = new System.Drawing.Size(77, 20);
            this.checkOatBoxMilk.TabIndex = 1;
            this.checkOatBoxMilk.Text = "Oat Milk";
            this.checkOatBoxMilk.UseVisualStyleBackColor = true;
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.comboBoxSize.Location = new System.Drawing.Point(107, 41);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(120, 24);
            this.comboBoxSize.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cafe_Studio02.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cafe_Studio02.Properties.Resources.c_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelCustomization);
            this.Controls.Add(this.buttonUpdateQuantity);
            this.Controls.Add(this.buttonCheckout);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.listView1);
            this.Name = "CartForm";
            this.Text = "CartForm";
            this.Load += new System.EventHandler(this.CartForm_Load);
            this.panelCustomization.ResumeLayout(false);
            this.panelCustomization.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBox1;
        private Button buttonCheckout;
        private Button buttonUpdateQuantity;
        private Panel panelCustomization;
        private CheckBox checkOatBoxMilk;
        private ComboBox comboBoxSize;
        private CheckBox checkBoxNoSugar;
        private Button buttonSaveCustomization;
        private CheckBox checkBoxSoyMilk;
        private PictureBox pictureBox1;
    }
}