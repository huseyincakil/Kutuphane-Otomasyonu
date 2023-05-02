namespace Kütüphane_Otomasyonu
{
    partial class AnaSayfafrm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUyeListele = new System.Windows.Forms.Button();
            this.btnUyeEkle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.btnKitapListele = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUyeListele);
            this.groupBox1.Controls.Add(this.btnUyeEkle);
            this.groupBox1.Location = new System.Drawing.Point(46, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 294);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye İşlemleri";
            // 
            // btnUyeListele
            // 
            this.btnUyeListele.Location = new System.Drawing.Point(23, 171);
            this.btnUyeListele.Name = "btnUyeListele";
            this.btnUyeListele.Size = new System.Drawing.Size(445, 52);
            this.btnUyeListele.TabIndex = 1;
            this.btnUyeListele.Text = "Üye Listeleme İşlemleri";
            this.btnUyeListele.UseVisualStyleBackColor = true;
            this.btnUyeListele.Click += new System.EventHandler(this.btnUyeListele_Click);
            // 
            // btnUyeEkle
            // 
            this.btnUyeEkle.Location = new System.Drawing.Point(23, 79);
            this.btnUyeEkle.Name = "btnUyeEkle";
            this.btnUyeEkle.Size = new System.Drawing.Size(445, 52);
            this.btnUyeEkle.TabIndex = 0;
            this.btnUyeEkle.Text = "Üye Ekleme İşlemleri";
            this.btnUyeEkle.UseVisualStyleBackColor = true;
            this.btnUyeEkle.Click += new System.EventHandler(this.btnUyeEkle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKitapEkle);
            this.groupBox2.Controls.Add(this.btnKitapListele);
            this.groupBox2.Location = new System.Drawing.Point(614, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 294);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap İşlemleri";
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Location = new System.Drawing.Point(26, 79);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(445, 52);
            this.btnKitapEkle.TabIndex = 2;
            this.btnKitapEkle.Text = "Kitap Ekleme İşlemleri";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // btnKitapListele
            // 
            this.btnKitapListele.Location = new System.Drawing.Point(26, 171);
            this.btnKitapListele.Name = "btnKitapListele";
            this.btnKitapListele.Size = new System.Drawing.Size(445, 52);
            this.btnKitapListele.TabIndex = 0;
            this.btnKitapListele.Text = "Kitap Listeleme İşlemleri";
            this.btnKitapListele.UseVisualStyleBackColor = true;
            this.btnKitapListele.Click += new System.EventHandler(this.btnKitapListele_Click);
            // 
            // AnaSayfafrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1217, 503);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AnaSayfafrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUyeListele;
        private System.Windows.Forms.Button btnUyeEkle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.Button btnKitapListele;
    }
}

