namespace PROJEKT
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
            this.unoszivotinje = new System.Windows.Forms.Button();
            this.pregled = new System.Windows.Forms.Button();
            this.filtriranje = new System.Windows.Forms.Button();
            this.udomljavanje = new System.Windows.Forms.Button();
            this.statistika = new System.Windows.Forms.Button();
            this.izlaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // unoszivotinje
            // 
            this.unoszivotinje.Location = new System.Drawing.Point(95, 61);
            this.unoszivotinje.Name = "unoszivotinje";
            this.unoszivotinje.Size = new System.Drawing.Size(75, 44);
            this.unoszivotinje.TabIndex = 0;
            this.unoszivotinje.Text = "Unos životinje";
            this.unoszivotinje.UseVisualStyleBackColor = true;
            this.unoszivotinje.Click += new System.EventHandler(this.unoszivotinje_Click);
            // 
            // pregled
            // 
            this.pregled.Location = new System.Drawing.Point(95, 125);
            this.pregled.Name = "pregled";
            this.pregled.Size = new System.Drawing.Size(75, 23);
            this.pregled.TabIndex = 1;
            this.pregled.Text = "Pregled";
            this.pregled.UseVisualStyleBackColor = true;
            this.pregled.Click += new System.EventHandler(this.pregled_Click);
            // 
            // filtriranje
            // 
            this.filtriranje.Location = new System.Drawing.Point(95, 174);
            this.filtriranje.Name = "filtriranje";
            this.filtriranje.Size = new System.Drawing.Size(75, 23);
            this.filtriranje.TabIndex = 2;
            this.filtriranje.Text = "Filtriranje";
            this.filtriranje.UseVisualStyleBackColor = true;
            this.filtriranje.Click += new System.EventHandler(this.filtriranje_Click);
            // 
            // udomljavanje
            // 
            this.udomljavanje.Location = new System.Drawing.Point(242, 72);
            this.udomljavanje.Name = "udomljavanje";
            this.udomljavanje.Size = new System.Drawing.Size(83, 23);
            this.udomljavanje.TabIndex = 3;
            this.udomljavanje.Text = "Udomljavanje";
            this.udomljavanje.UseVisualStyleBackColor = true;
            this.udomljavanje.Click += new System.EventHandler(this.udomljavanje_Click);
            // 
            // statistika
            // 
            this.statistika.Location = new System.Drawing.Point(242, 125);
            this.statistika.Name = "statistika";
            this.statistika.Size = new System.Drawing.Size(75, 23);
            this.statistika.TabIndex = 4;
            this.statistika.Text = "Statistika";
            this.statistika.UseVisualStyleBackColor = true;
            this.statistika.Click += new System.EventHandler(this.statistika_Click);
            // 
            // izlaz
            // 
            this.izlaz.Location = new System.Drawing.Point(242, 174);
            this.izlaz.Name = "izlaz";
            this.izlaz.Size = new System.Drawing.Size(75, 23);
            this.izlaz.TabIndex = 5;
            this.izlaz.Text = "Izlaz";
            this.izlaz.UseVisualStyleBackColor = true;
            this.izlaz.Click += new System.EventHandler(this.izlaz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.izlaz);
            this.Controls.Add(this.statistika);
            this.Controls.Add(this.udomljavanje);
            this.Controls.Add(this.filtriranje);
            this.Controls.Add(this.pregled);
            this.Controls.Add(this.unoszivotinje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button unoszivotinje;
        private System.Windows.Forms.Button pregled;
        private System.Windows.Forms.Button filtriranje;
        private System.Windows.Forms.Button udomljavanje;
        private System.Windows.Forms.Button statistika;
        private System.Windows.Forms.Button izlaz;
    }
}

