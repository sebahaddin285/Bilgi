namespace Bilgi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.soruText = new System.Windows.Forms.Label();
            this.cvp1Btn = new System.Windows.Forms.Button();
            this.cvp2Btn = new System.Windows.Forms.Button();
            this.cvp3Btn = new System.Windows.Forms.Button();
            this.degistir = new System.Windows.Forms.Button();
            this.scorText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eskorText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // soruText
            // 
            this.soruText.Location = new System.Drawing.Point(40, 40);
            this.soruText.Name = "soruText";
            this.soruText.Size = new System.Drawing.Size(609, 71);
            this.soruText.TabIndex = 0;
            this.soruText.Text = "label1";
            // 
            // cvp1Btn
            // 
            this.cvp1Btn.Location = new System.Drawing.Point(76, 139);
            this.cvp1Btn.Name = "cvp1Btn";
            this.cvp1Btn.Size = new System.Drawing.Size(75, 23);
            this.cvp1Btn.TabIndex = 1;
            this.cvp1Btn.Text = "button1";
            this.cvp1Btn.UseVisualStyleBackColor = true;
            this.cvp1Btn.Click += new System.EventHandler(this.cvp1Btn_Click);
            // 
            // cvp2Btn
            // 
            this.cvp2Btn.Location = new System.Drawing.Point(188, 139);
            this.cvp2Btn.Name = "cvp2Btn";
            this.cvp2Btn.Size = new System.Drawing.Size(75, 23);
            this.cvp2Btn.TabIndex = 2;
            this.cvp2Btn.Text = "button2";
            this.cvp2Btn.UseVisualStyleBackColor = true;
            this.cvp2Btn.Click += new System.EventHandler(this.cvp2Btn_Click);
            // 
            // cvp3Btn
            // 
            this.cvp3Btn.Location = new System.Drawing.Point(307, 139);
            this.cvp3Btn.Name = "cvp3Btn";
            this.cvp3Btn.Size = new System.Drawing.Size(75, 23);
            this.cvp3Btn.TabIndex = 3;
            this.cvp3Btn.Text = "button3";
            this.cvp3Btn.UseVisualStyleBackColor = true;
            this.cvp3Btn.Click += new System.EventHandler(this.cvp3Btn_Click);
            // 
            // degistir
            // 
            this.degistir.Location = new System.Drawing.Point(76, 184);
            this.degistir.Name = "degistir";
            this.degistir.Size = new System.Drawing.Size(306, 25);
            this.degistir.TabIndex = 4;
            this.degistir.Text = "Değiştir";
            this.degistir.UseVisualStyleBackColor = true;
            this.degistir.Click += new System.EventHandler(this.degistir_Click);
            // 
            // scorText
            // 
            this.scorText.AutoSize = true;
            this.scorText.Location = new System.Drawing.Point(24, 274);
            this.scorText.Name = "scorText";
            this.scorText.Size = new System.Drawing.Size(13, 13);
            this.scorText.TabIndex = 5;
            this.scorText.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "en yüksek skor:";
            // 
            // eskorText
            // 
            this.eskorText.AutoSize = true;
            this.eskorText.Location = new System.Drawing.Point(162, 274);
            this.eskorText.Name = "eskorText";
            this.eskorText.Size = new System.Drawing.Size(13, 13);
            this.eskorText.TabIndex = 7;
            this.eskorText.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 339);
            this.Controls.Add(this.eskorText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scorText);
            this.Controls.Add(this.degistir);
            this.Controls.Add(this.cvp3Btn);
            this.Controls.Add(this.cvp2Btn);
            this.Controls.Add(this.cvp1Btn);
            this.Controls.Add(this.soruText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label soruText;
        private System.Windows.Forms.Button cvp1Btn;
        private System.Windows.Forms.Button cvp2Btn;
        private System.Windows.Forms.Button cvp3Btn;
        private System.Windows.Forms.Button degistir;
        private System.Windows.Forms.Label scorText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label eskorText;
    }
}

