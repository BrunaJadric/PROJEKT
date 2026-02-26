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
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            this.Udomi.Text = "button1";
            this.Udomi.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(309, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(214, 225);
            this.listBox1.TabIndex = 7;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Udomi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3kontakt);
            this.Controls.Add(this.textBox2udomitelj);
            this.Controls.Add(this.textBox1datumu);
            this.Name = "Form5";
            this.Text = "Form5";
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
        private System.Windows.Forms.ListBox listBox1;
    }
}