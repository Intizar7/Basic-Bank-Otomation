namespace WindowsFormsApplication1
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
            this.txtDairesel = new System.Windows.Forms.TextBox();
            this.txtOncelik = new System.Windows.Forms.TextBox();
            this.txtTers = new System.Windows.Forms.TextBox();
            this.txtDaireselOrt = new System.Windows.Forms.Label();
            this.txtOncelikOrt = new System.Windows.Forms.Label();
            this.txtTersOrt = new System.Windows.Forms.Label();
            this.txtKazanc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDairesel
            // 
            this.txtDairesel.Location = new System.Drawing.Point(30, 37);
            this.txtDairesel.Multiline = true;
            this.txtDairesel.Name = "txtDairesel";
            this.txtDairesel.Size = new System.Drawing.Size(433, 371);
            this.txtDairesel.TabIndex = 0;
            // 
            // txtOncelik
            // 
            this.txtOncelik.Location = new System.Drawing.Point(505, 37);
            this.txtOncelik.Multiline = true;
            this.txtOncelik.Name = "txtOncelik";
            this.txtOncelik.Size = new System.Drawing.Size(433, 371);
            this.txtOncelik.TabIndex = 1;
            // 
            // txtTers
            // 
            this.txtTers.Location = new System.Drawing.Point(982, 37);
            this.txtTers.Multiline = true;
            this.txtTers.Name = "txtTers";
            this.txtTers.Size = new System.Drawing.Size(433, 371);
            this.txtTers.TabIndex = 2;
            // 
            // txtDaireselOrt
            // 
            this.txtDaireselOrt.AutoSize = true;
            this.txtDaireselOrt.Location = new System.Drawing.Point(225, 421);
            this.txtDaireselOrt.Name = "txtDaireselOrt";
            this.txtDaireselOrt.Size = new System.Drawing.Size(0, 13);
            this.txtDaireselOrt.TabIndex = 3;
            // 
            // txtOncelikOrt
            // 
            this.txtOncelikOrt.AutoSize = true;
            this.txtOncelikOrt.Location = new System.Drawing.Point(708, 421);
            this.txtOncelikOrt.Name = "txtOncelikOrt";
            this.txtOncelikOrt.Size = new System.Drawing.Size(0, 13);
            this.txtOncelikOrt.TabIndex = 4;
            // 
            // txtTersOrt
            // 
            this.txtTersOrt.AutoSize = true;
            this.txtTersOrt.Location = new System.Drawing.Point(1212, 421);
            this.txtTersOrt.Name = "txtTersOrt";
            this.txtTersOrt.Size = new System.Drawing.Size(0, 13);
            this.txtTersOrt.TabIndex = 5;
            // 
            // txtKazanc
            // 
            this.txtKazanc.Location = new System.Drawing.Point(505, 474);
            this.txtKazanc.Multiline = true;
            this.txtKazanc.Name = "txtKazanc";
            this.txtKazanc.Size = new System.Drawing.Size(433, 145);
            this.txtKazanc.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dairesel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(708, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Öncelik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1212, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Öncelik Ters";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(695, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kazanç";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 631);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKazanc);
            this.Controls.Add(this.txtTersOrt);
            this.Controls.Add(this.txtOncelikOrt);
            this.Controls.Add(this.txtDaireselOrt);
            this.Controls.Add(this.txtTers);
            this.Controls.Add(this.txtOncelik);
            this.Controls.Add(this.txtDairesel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDairesel;
        private System.Windows.Forms.TextBox txtOncelik;
        private System.Windows.Forms.TextBox txtTers;
        private System.Windows.Forms.Label txtDaireselOrt;
        private System.Windows.Forms.Label txtOncelikOrt;
        private System.Windows.Forms.Label txtTersOrt;
        private System.Windows.Forms.TextBox txtKazanc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

