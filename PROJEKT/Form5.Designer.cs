namespace PROJEKT
{
    partial class Form5
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
            this.textBox1datumu = new System.Windows.Forms.TextBox();
            this.textBox2udomitelj = new System.Windows.Forms.TextBox();
            this.textBox3kontakt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Udomi = new System.Windows.Forms.Button();
            this.Nasezivotinje = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1datumu
            // 
            this.textBox1datumu.Location = new System.Drawing.Point(211, 37);
            this.textBox1datumu.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1datumu.Name = "textBox1datumu";
            this.textBox1datumu.Size = new System.Drawing.Size(132, 22);
            this.textBox1datumu.TabIndex = 0;
            // 
            // textBox2udomitelj
            // 
            this.textBox2udomitelj.Location = new System.Drawing.Point(211, 79);
            this.textBox2udomitelj.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2udomitelj.Name = "textBox2udomitelj";
            this.textBox2udomitelj.Size = new System.Drawing.Size(132, 22);
            this.textBox2udomitelj.TabIndex = 1;
            this.textBox2udomitelj.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3kontakt
            // 
            this.textBox3kontakt.Location = new System.Drawing.Point(211, 134);
            this.textBox3kontakt.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3kontakt.Name = "textBox3kontakt";
            this.textBox3kontakt.Size = new System.Drawing.Size(132, 22);
            this.textBox3kontakt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datum udomljavanja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Udomitelj:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kontakt:";
            // 
            // Udomi
            // 
            this.Udomi.Location = new System.Drawing.Point(132, 206);
            this.Udomi.Margin = new System.Windows.Forms.Padding(4);
            this.Udomi.Name = "Udomi";
            this.Udomi.Size = new System.Drawing.Size(100, 28);
            this.Udomi.TabIndex = 6;
            this.Udomi.Text = "Udomi";
            this.Udomi.UseVisualStyleBackColor = true;
            this.Udomi.Click += new System.EventHandler(this.Udomi_Click);
            // 
            // Nasezivotinje
            // 
            this.Nasezivotinje.FormattingEnabled = true;
            this.Nasezivotinje.ItemHeight = 16;
            this.Nasezivotinje.Location = new System.Drawing.Point(407, 79);
            this.Nasezivotinje.Margin = new System.Windows.Forms.Padding(4);
            this.Nasezivotinje.Name = "Nasezivotinje";
            this.Nasezivotinje.Size = new System.Drawing.Size(284, 276);
            this.Nasezivotinje.TabIndex = 7;
            this.Nasezivotinje.DoubleClick += new System.EventHandler(this.Nasezivotinje_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dupli klik na životinju koju želite udomiti:";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Nasezivotinje);
            this.Controls.Add(this.Udomi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3kontakt);
            this.Controls.Add(this.textBox2udomitelj);
            this.Controls.Add(this.textBox1datumu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1datumu;
        private System.Windows.Forms.TextBox textBox2udomitelj;
        private System.Windows.Forms.TextBox textBox3kontakt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Udomi;
        private System.Windows.Forms.ListBox Nasezivotinje;
        private System.Windows.Forms.Label label4;
    }
}