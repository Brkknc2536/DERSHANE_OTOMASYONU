﻿namespace Birebir_Etut_Programi
{
    partial class ogretmenler_Sayfasi
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAdSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtBrans = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.TxtSilinecek = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.TxtSilinecek);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.TxtBrans);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtMail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtTelefon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtAdSoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(32, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 585);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğretmen Ekleme İşlemi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(88, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Öğretmen Numara";
            // 
            // TxtId
            // 
            this.TxtId.Font = new System.Drawing.Font("Tahoma", 16.2F);
            this.TxtId.Location = new System.Drawing.Point(55, 64);
            this.TxtId.Multiline = true;
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(289, 39);
            this.TxtId.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(88, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Öğretmen Ad Soyad";
            // 
            // TxtAdSoyad
            // 
            this.TxtAdSoyad.Font = new System.Drawing.Font("Tahoma", 16.2F);
            this.TxtAdSoyad.Location = new System.Drawing.Point(55, 147);
            this.TxtAdSoyad.Multiline = true;
            this.TxtAdSoyad.Name = "TxtAdSoyad";
            this.TxtAdSoyad.Size = new System.Drawing.Size(289, 39);
            this.TxtAdSoyad.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(92, 200);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 27);
            this.label3.TabIndex = 12;
            this.label3.Text = "Öğretmen Telefon";
            // 
            // TxtTelefon
            // 
            this.TxtTelefon.Font = new System.Drawing.Font("Tahoma", 16.2F);
            this.TxtTelefon.Location = new System.Drawing.Point(59, 230);
            this.TxtTelefon.Mask = "(999) 000-0000";
            this.TxtTelefon.Name = "TxtTelefon";
            this.TxtTelefon.Size = new System.Drawing.Size(289, 34);
            this.TxtTelefon.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(92, 280);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 27);
            this.label4.TabIndex = 14;
            this.label4.Text = "Öğretmen Mail";
            // 
            // TxtMail
            // 
            this.TxtMail.Font = new System.Drawing.Font("Tahoma", 16.2F);
            this.TxtMail.Location = new System.Drawing.Point(59, 310);
            this.TxtMail.Multiline = true;
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(289, 39);
            this.TxtMail.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(92, 361);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 27);
            this.label5.TabIndex = 16;
            this.label5.Text = "Öğretmen Branş";
            // 
            // TxtBrans
            // 
            this.TxtBrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtBrans.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBrans.FormattingEnabled = true;
            this.TxtBrans.Location = new System.Drawing.Point(59, 390);
            this.TxtBrans.Margin = new System.Windows.Forms.Padding(2);
            this.TxtBrans.Name = "TxtBrans";
            this.TxtBrans.Size = new System.Drawing.Size(289, 35);
            this.TxtBrans.TabIndex = 6;
            this.TxtBrans.SelectedIndexChanged += new System.EventHandler(this.TxtBrans_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.groupBox2.Location = new System.Drawing.Point(465, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(716, 574);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sistemde Kayıtlı Öğretmenler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(710, 554);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(191)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Birebir_Etut_Programi.Properties.Resources.reload_icon;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button2.Location = new System.Drawing.Point(6, 506);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 58);
            this.button2.TabIndex = 19;
            this.button2.Text = "Düzenleme İşlemi";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxtSilinecek
            // 
            this.TxtSilinecek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(54)))), ((int)(((byte)(12)))));
            this.TxtSilinecek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TxtSilinecek.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.TxtSilinecek.ForeColor = System.Drawing.Color.White;
            this.TxtSilinecek.Image = global::Birebir_Etut_Programi.Properties.Resources.Button_Close_icon;
            this.TxtSilinecek.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.TxtSilinecek.Location = new System.Drawing.Point(212, 506);
            this.TxtSilinecek.Name = "TxtSilinecek";
            this.TxtSilinecek.Size = new System.Drawing.Size(187, 58);
            this.TxtSilinecek.TabIndex = 18;
            this.TxtSilinecek.Text = " Öğretmen Sil";
            this.TxtSilinecek.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TxtSilinecek.UseVisualStyleBackColor = false;
            this.TxtSilinecek.Click += new System.EventHandler(this.TxtSilinecek_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(15)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Birebir_Etut_Programi.Properties.Resources.Button_Add_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.Location = new System.Drawing.Point(93, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 58);
            this.button1.TabIndex = 17;
            this.button1.Text = "Yeni Öğretmen Ekle";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ogretmenler_Sayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 609);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ogretmenler_Sayfasi";
            this.Text = "Öğretmen İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ogretmenler_Sayfasi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TxtBrans;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox TxtTelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button TxtSilinecek;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}