namespace uzantı_türleri__96
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbUzanti = new System.Windows.Forms.ListBox();
            this.rbVideo = new System.Windows.Forms.RadioButton();
            this.rbResim = new System.Windows.Forms.RadioButton();
            this.btnKontrol = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.lbUzanti);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uzantı Türü";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.rbResim);
            this.groupBox2.Controls.Add(this.rbVideo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 160);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dosya Türü";
            // 
            // lbUzanti
            // 
            this.lbUzanti.FormattingEnabled = true;
            this.lbUzanti.ItemHeight = 16;
            this.lbUzanti.Items.AddRange(new object[] {
            "MP4",
            "JPG",
            "MOV",
            "PNG"});
            this.lbUzanti.Location = new System.Drawing.Point(6, 34);
            this.lbUzanti.Name = "lbUzanti";
            this.lbUzanti.Size = new System.Drawing.Size(75, 100);
            this.lbUzanti.TabIndex = 2;
            // 
            // rbVideo
            // 
            this.rbVideo.AutoSize = true;
            this.rbVideo.Location = new System.Drawing.Point(6, 45);
            this.rbVideo.Name = "rbVideo";
            this.rbVideo.Size = new System.Drawing.Size(114, 20);
            this.rbVideo.TabIndex = 2;
            this.rbVideo.TabStop = true;
            this.rbVideo.Text = "Video Dosyası";
            this.rbVideo.UseVisualStyleBackColor = true;
            // 
            // rbResim
            // 
            this.rbResim.AutoSize = true;
            this.rbResim.Location = new System.Drawing.Point(6, 97);
            this.rbResim.Name = "rbResim";
            this.rbResim.Size = new System.Drawing.Size(117, 20);
            this.rbResim.TabIndex = 3;
            this.rbResim.TabStop = true;
            this.rbResim.Text = "Resim Dosyası";
            this.rbResim.UseVisualStyleBackColor = true;
            // 
            // btnKontrol
            // 
            this.btnKontrol.BackColor = System.Drawing.Color.Yellow;
            this.btnKontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKontrol.Location = new System.Drawing.Point(12, 383);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(200, 41);
            this.btnKontrol.TabIndex = 2;
            this.btnKontrol.Text = "Kontrol Et";
            this.btnKontrol.UseVisualStyleBackColor = false;
            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(230, 447);
            this.Controls.Add(this.btnKontrol);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbUzanti;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbResim;
        private System.Windows.Forms.RadioButton rbVideo;
        private System.Windows.Forms.Button btnKontrol;
    }
}

