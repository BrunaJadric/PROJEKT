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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1datumu
            // 
            this.textBox1datumu.Location = new System.Drawing.Point(158, 30);
            this.textBox1datumu.Name = "textBox1datumu";
            this.textBox1datumu.Size = new System.Drawing.Size(100, 20);
            this.textBox1datumu.TabIndex = 0;
            // 
            // textBox2udomitelj
            // 
            this.textBox2udomitelj.Location = new System.Drawing.Point(158, 64);
            this.textBox2udomitelj.Name = "textBox2udomitelj";
            this.textBox2udomitelj.Size = new System.Drawing.Size(100, 20);
            this.textBox2udomitelj.TabIndex = 1;
            this.textBox2udomitelj.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3kontakt
            // 
            this.textBox3kontakt.Location = new System.Drawing.Point(158, 109);
            this.textBox3kontakt.Name = "textBox3kontakt";
            this.textBox3kontakt.Size = new System.Drawing.Size(100, 20);
            this.textBox3kontakt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datum udomljavanja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Udomitelj:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kontakt:";
            // 
            // Udomi
            // 
            this.Udomi.Location = new System.Drawing.Point(99, 167);
            this.Udomi.Name = "Udomi";
            this.Udomi.Size = new System.Drawing.Size(75, 23);
            this.Udomi.TabIndex = 6;
            this.Udomi.Text = "Udomi";
            this.Udomi.UseVisualStyleBackColor = true;
            this.Udomi.Click += new System.EventHandler(this.Udomi_Click);
            // 
            // Nasezivotinje
            // 
            this.Nasezivotinje.FormattingEnabled = true;
            this.Nasezivotinje.Location = new System.Drawing.Point(305, 64);
            this.Nasezivotinje.Name = "Nasezivotinje";
            this.Nasezivotinje.Size = new System.Drawing.Size(214, 225);
            this.Nasezivotinje.TabIndex = 7;
            this.Nasezivotinje.DoubleClick += new System.EventHandler(this.Nasezivotinje_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dupli klik na životinju koju želite udomiti:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Izlaz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Nasezivotinje);
            this.Controls.Add(this.Udomi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3kontakt);
            this.Controls.Add(this.textBox2udomitelj);
            this.Controls.Add(this.textBox1datumu);
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
        private System.Windows.Forms.Button button1;
    }
}