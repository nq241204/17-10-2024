namespace FormTraCuuDiemSV
{
    partial class btntracuu
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
            this.txtmaSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TraCuu = new System.Windows.Forms.Button();
            this.txtThongTin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtmaSV
            // 
            this.txtmaSV.Location = new System.Drawing.Point(144, 39);
            this.txtmaSV.Name = "txtmaSV";
            this.txtmaSV.Size = new System.Drawing.Size(216, 20);
            this.txtmaSV.TabIndex = 0;
            this.txtmaSV.TextChanged += new System.EventHandler(this.txtmasv_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sinh viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TraCuu
            // 
            this.TraCuu.Location = new System.Drawing.Point(176, 90);
            this.TraCuu.Name = "TraCuu";
            this.TraCuu.Size = new System.Drawing.Size(153, 30);
            this.TraCuu.TabIndex = 2;
            this.TraCuu.Text = "Tra Cứu";
            this.TraCuu.UseVisualStyleBackColor = true;
            this.TraCuu.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtThongTin
            // 
            this.txtThongTin.Location = new System.Drawing.Point(144, 169);
            this.txtThongTin.Name = "txtThongTin";
            this.txtThongTin.Size = new System.Drawing.Size(216, 20);
            this.txtThongTin.TabIndex = 3;
            this.txtThongTin.TextChanged += new System.EventHandler(this.txtThongTin_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thông tin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtThongTin);
            this.groupBox1.Controls.Add(this.TraCuu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtmaSV);
            this.groupBox1.Location = new System.Drawing.Point(100, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 256);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form Tra Cứu";
            // 
            // btntracuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "btntracuu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.btntracuu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtmaSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TraCuu;
        private System.Windows.Forms.TextBox txtThongTin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

