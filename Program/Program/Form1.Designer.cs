namespace ComboBox_kontrola
{
    partial class Form1
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
            this.cmbBox = new System.Windows.Forms.ComboBox();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbBox
            // 
            this.cmbBox.FormattingEnabled = true;
            this.cmbBox.Items.AddRange(new object[] {
            "IT menadzment",
            "aplikativno programiranje",
            "internet programiranje",
            "informacioni sistemi"});
            this.cmbBox.Location = new System.Drawing.Point(12, 74);
            this.cmbBox.Name = "cmbBox";
            this.cmbBox.Size = new System.Drawing.Size(288, 21);
            this.cmbBox.TabIndex = 0;
            this.cmbBox.SelectedIndexChanged += new System.EventHandler(this.cmbBox_SelectedIndexChanged);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(12, 135);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(288, 20);
            this.txtBox.TabIndex = 1;
            this.txtBox.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // txtBox1
            // 
            this.txtBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox1.Enabled = false;
            this.txtBox1.Location = new System.Drawing.Point(12, 26);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.ReadOnly = true;
            this.txtBox1.Size = new System.Drawing.Size(288, 13);
            this.txtBox1.TabIndex = 0;
            this.txtBox1.Text = "Odaberite jedan od punudjenih obrazovnih profila";
            this.txtBox1.TextChanged += new System.EventHandler(this.txtBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 188);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.cmbBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBox;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.TextBox txtBox1;
    }
}

