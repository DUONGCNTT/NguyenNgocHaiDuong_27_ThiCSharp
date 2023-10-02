namespace NguyenNgocHaiDuong_27_ThiCSharp
{
    partial class dinhdang
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
            this.txtNhapTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radblack = new System.Windows.Forms.RadioButton();
            this.radblue = new System.Windows.Forms.RadioButton();
            this.radred = new System.Windows.Forms.RadioButton();
            this.radgreen = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkunderline = new System.Windows.Forms.CheckBox();
            this.chkitalic = new System.Windows.Forms.CheckBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.lbllaptrinh = new System.Windows.Forms.Label();
            this.txtLapTrinh = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lbllt = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNhapTen
            // 
            this.txtNhapTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtNhapTen.Location = new System.Drawing.Point(241, 34);
            this.txtNhapTen.Name = "txtNhapTen";
            this.txtNhapTen.Size = new System.Drawing.Size(346, 31);
            this.txtNhapTen.TabIndex = 0;
            this.txtNhapTen.TextChanged += new System.EventHandler(this.txtnhapten_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(113, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập tên:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radblack);
            this.groupBox1.Controls.Add(this.radblue);
            this.groupBox1.Controls.Add(this.radred);
            this.groupBox1.Controls.Add(this.radgreen);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBox1.Location = new System.Drawing.Point(118, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 192);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "color";
            // 
            // radblack
            // 
            this.radblack.AutoSize = true;
            this.radblack.Location = new System.Drawing.Point(17, 148);
            this.radblack.Name = "radblack";
            this.radblack.Size = new System.Drawing.Size(60, 21);
            this.radblack.TabIndex = 3;
            this.radblack.TabStop = true;
            this.radblack.Text = "Black";
            this.radblack.UseVisualStyleBackColor = true;
            this.radblack.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radblue
            // 
            this.radblue.AutoSize = true;
            this.radblue.ForeColor = System.Drawing.Color.Blue;
            this.radblue.Location = new System.Drawing.Point(17, 108);
            this.radblue.Name = "radblue";
            this.radblue.Size = new System.Drawing.Size(54, 21);
            this.radblue.TabIndex = 2;
            this.radblue.TabStop = true;
            this.radblue.Text = "Blue";
            this.radblue.UseVisualStyleBackColor = true;
            this.radblue.CheckedChanged += new System.EventHandler(this.radblue_CheckedChanged);
            // 
            // radred
            // 
            this.radred.AutoSize = true;
            this.radred.BackColor = System.Drawing.SystemColors.ControlLight;
            this.radred.ForeColor = System.Drawing.Color.Red;
            this.radred.Location = new System.Drawing.Point(17, 32);
            this.radred.Name = "radred";
            this.radred.Size = new System.Drawing.Size(52, 21);
            this.radred.TabIndex = 1;
            this.radred.TabStop = true;
            this.radred.Text = "Red";
            this.radred.UseVisualStyleBackColor = false;
            this.radred.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radgreen
            // 
            this.radgreen.AutoSize = true;
            this.radgreen.ForeColor = System.Drawing.Color.Lime;
            this.radgreen.Location = new System.Drawing.Point(17, 69);
            this.radgreen.Name = "radgreen";
            this.radgreen.Size = new System.Drawing.Size(66, 21);
            this.radgreen.TabIndex = 1;
            this.radgreen.TabStop = true;
            this.radgreen.Text = "Green";
            this.radgreen.UseVisualStyleBackColor = true;
            this.radgreen.CheckedChanged += new System.EventHandler(this.radgreen_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkunderline);
            this.groupBox2.Controls.Add(this.chkitalic);
            this.groupBox2.Controls.Add(this.chkBold);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBox2.Location = new System.Drawing.Point(464, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(143, 192);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "font";
            // 
            // chkunderline
            // 
            this.chkunderline.AutoSize = true;
            this.chkunderline.Location = new System.Drawing.Point(25, 135);
            this.chkunderline.Name = "chkunderline";
            this.chkunderline.Size = new System.Drawing.Size(96, 21);
            this.chkunderline.TabIndex = 5;
            this.chkunderline.Text = "Gạch chân";
            this.chkunderline.UseVisualStyleBackColor = true;
            this.chkunderline.CheckedChanged += new System.EventHandler(this.chkunderline_CheckedChanged);
            // 
            // chkitalic
            // 
            this.chkitalic.AutoSize = true;
            this.chkitalic.Location = new System.Drawing.Point(25, 83);
            this.chkitalic.Name = "chkitalic";
            this.chkitalic.Size = new System.Drawing.Size(112, 21);
            this.chkitalic.TabIndex = 4;
            this.chkitalic.Text = "Nghiêng Italic";
            this.chkitalic.UseVisualStyleBackColor = true;
            this.chkitalic.CheckedChanged += new System.EventHandler(this.chkitalic_CheckedChanged);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Location = new System.Drawing.Point(28, 33);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(92, 21);
            this.chkBold.TabIndex = 3;
            this.chkBold.Text = " Đậm Bold";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // lbllaptrinh
            // 
            this.lbllaptrinh.AutoSize = true;
            this.lbllaptrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lbllaptrinh.Location = new System.Drawing.Point(98, 307);
            this.lbllaptrinh.Name = "lbllaptrinh";
            this.lbllaptrinh.Size = new System.Drawing.Size(137, 25);
            this.lbllaptrinh.TabIndex = 5;
            this.lbllaptrinh.Text = "Lập trình bởi:";
            this.lbllaptrinh.Click += new System.EventHandler(this.lbllaptrinh_Click);
            // 
            // txtLapTrinh
            // 
            this.txtLapTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtLapTrinh.Location = new System.Drawing.Point(241, 304);
            this.txtLapTrinh.Name = "txtLapTrinh";
            this.txtLapTrinh.Size = new System.Drawing.Size(346, 31);
            this.txtLapTrinh.TabIndex = 4;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(188, 397);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(370, 41);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lbllt
            // 
            this.lbllt.Location = new System.Drawing.Point(238, 348);
            this.lbllt.Name = "lbllt";
            this.lbllt.Size = new System.Drawing.Size(117, 32);
            this.lbllt.TabIndex = 7;
            // 
            // dinhdang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbllt);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lbllaptrinh);
            this.Controls.Add(this.txtLapTrinh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNhapTen);
            this.Name = "dinhdang";
            this.Text = "Định_dạng";
            this.TextChanged += new System.EventHandler(this.Định_dạng_TextChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNhapTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radblue;
        private System.Windows.Forms.RadioButton radred;
        private System.Windows.Forms.RadioButton radgreen;
        private System.Windows.Forms.Label lbllaptrinh;
        private System.Windows.Forms.TextBox txtLapTrinh;
        private System.Windows.Forms.RadioButton radblack;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lbllt;
        private System.Windows.Forms.CheckBox chkunderline;
        private System.Windows.Forms.CheckBox chkitalic;
        private System.Windows.Forms.CheckBox chkBold;
    }
}